using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int colorChangeRate = 5;
    public float speed = 15;
    public float mapWidth = 5;
    public int ChosenColor;
    private Rigidbody2D rb;
    public int score = 0;
    public int colorChange;
    public List<int> colorsID = new List<int>();
    public List<int> savedID = new List<int>();
    public List<Sprite> Images = new List<Sprite>();
    public List<Sprite> SavedSprites = new List<Sprite>();
    public GameObject explosion;
    public Image targetImage;
    private Tail_Control tail_Control;

    [SerializeField]
    private Image fadeImage = null;
    public List<spawningList> lists_to_Spawn = new List<spawningList>();
    [SerializeField]
    private List<RandomSpawn2Script> spawners = new List<RandomSpawn2Script>();
    [SerializeField]
    private List<spawningList> Endless_List = new List<spawningList>();
    
    void Start()
    {
       
        SpawnNewList(lists_to_Spawn[lists_to_Spawn.Count - 1]);
        lists_to_Spawn.RemoveAt(lists_to_Spawn.Count - 1);
        rb = GetComponent<Rigidbody2D>();
        tail_Control = GetComponent<Tail_Control>();
        int x = Random.Range(0, colorsID.Count);
        ChosenColor = colorsID[x];
        colorChange = 0;
        targetImage.sprite = Images[x];
        
    }


    private void Update()
    {
        if (PlayerController.Instance != null)
        {
            transform.Translate(PlayerController.Instance.direction * Time.deltaTime * 50);
        }
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -4, 4), 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.transform.tag == "Obstacle")
        {

            if (collision.transform.GetComponent<ColorCode>().colorID == ChosenColor)
            {
                // dwse vathmous
                score++;
                colorChange++;
                Destroy(collision.gameObject);
                tail_Control.Add_To_Tail(targetImage.sprite);
                Instantiate(explosion, collision.transform.position, Quaternion.identity);
            }

            if (colorChange >= colorChangeRate)
            {
                //allaxe xrwma
                Images.RemoveAt(colorsID.IndexOf(ChosenColor));
                colorsID.Remove(ChosenColor);
                // player feedback
                //play sound

                if (colorsID.Count <= 0)
                {
                    // end level 
                    if (lists_to_Spawn.Count <= 0)
                    {
                      //  GetComponent<Animator>().SetTrigger("Win");
                      foreach(spawningList sList in Endless_List)
                      {
                            lists_to_Spawn.Add(sList);
                      }
                        lists_to_Spawn[lists_to_Spawn.Count - 1].ResetList();
                        SpawnNewList(lists_to_Spawn[lists_to_Spawn.Count - 1]);
                        lists_to_Spawn.RemoveAt(lists_to_Spawn.Count - 1);
                    }
                    else
                    {
                        lists_to_Spawn[lists_to_Spawn.Count - 1].ResetList();
                        SpawnNewList(lists_to_Spawn[lists_to_Spawn.Count - 1]);
                        lists_to_Spawn.RemoveAt(lists_to_Spawn.Count - 1);
                    }

                }

                if (colorsID.Count > 0)
                {
                    int x = Random.Range(0, colorsID.Count);
                    ChosenColor = colorsID[x];

                    targetImage.sprite = Images[x];

                }
                colorChange = 0;
            }
        }
    }

    public void LoadLevel()
    {
        StartCoroutine(LoadToNextScene());
    }


    private IEnumerator LoadToNextScene()
    {
        Debug.Log(fadeImage.color.a);
        while (Mathf.Abs(fadeImage.color.a - 1) > 0.01f)
        {
            float x = Mathf.Lerp(fadeImage.color.a, 1, Time.deltaTime);

            fadeImage.color = new Color(0, 0, 0, x);
            yield return null;
        }

        yield return null;
    }


    public void SpawnNewList(spawningList thisList)
    {
       
        savedID = thisList.savedID;        
        SavedSprites = thisList.SavedSprites;
        colorsID = thisList.colorsID;
        Images = thisList.images;
        foreach (RandomSpawn2Script spawner in spawners)
        {
            spawner.spawnGameobjects = thisList.GO_List;
        }

    }
}
