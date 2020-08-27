using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro_Zone : MonoBehaviour
{
    [SerializeField]
    Image fadeImage = null;

    [SerializeField]
    Text IntroText = null;
    [SerializeField]
    Canvas IntroCanvas = null;
    [SerializeField]
    GameObject introGameobject = null;
    private Rigidbody2D playerBody;

    private void Awake()
    {
        playerBody = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        playerBody.constraints = RigidbodyConstraints2D.FreezeAll;
    }


    public void FadePanel()
    {
        Debug.Log("here");
        StartCoroutine(LoadToNextScene());
        playerBody.constraints = RigidbodyConstraints2D.None;
    }

    private IEnumerator LoadToNextScene()
    {

        while (Mathf.Abs(fadeImage.color.a) > 0.01f)
        {
            float x = Mathf.Lerp(fadeImage.color.a, 0, Time.deltaTime*2);

            fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, x);
            IntroText.color= new Color(IntroText.color.r, IntroText.color.g, IntroText.color.b, x);
            yield return null;
        }
       
        yield return new WaitForSeconds(1);
        Destroy(IntroCanvas.gameObject);
        Destroy(introGameobject);
    }
}
