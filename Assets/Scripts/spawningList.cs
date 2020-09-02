using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Jobs;
using UnityEngine;
[CreateAssetMenu(fileName = "New List", menuName = "Spawning List")]
public class spawningList : ScriptableObject
{
    public List<GameObject> GO_List = new List<GameObject>();
    public List<int> colorsID = new List<int>();
    public List<int> savedID = new List<int>();
    public List<Sprite> images = new List<Sprite>();   
    public List<Sprite> SavedSprites = new List<Sprite>();


   

    public void ResetList()
    {
        colorsID.Clear();
        images.Clear();
        foreach (GameObject go in GO_List)
        {
            colorsID.Add(go.GetComponent<ColorCode>().colorID);
            images.Add(go.GetComponent<SpriteRenderer>().sprite);
        }
        //images.Clear();
        //foreach (Sprite i in SavedSprites)
        //{
        //    images.Add(i);
        //}
    }

}
