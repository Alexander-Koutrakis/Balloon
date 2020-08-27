using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class SpawningGameobjectList 
{   
    private List<GameObject> GO_List;
    private List<int> colorsID;
    private List<int> savedID;
    private List<Sprite> Images;
    private List<Sprite> SavedSprites;
  

    public SpawningGameobjectList(List<GameObject> go_List, List<int> colors_id, List<int> saved_id, List<Sprite> images , List<Sprite> savedsprites)
    {
        GO_List = go_List;
        colorsID = colors_id;
        savedID = saved_id;
        Images = images;
        SavedSprites = savedsprites;
    }

    public List<GameObject> GetGoList()
    {
        return GO_List;
    }

    public List<int> GetColorID()
    {
        return colorsID;
    }

    public List<int> GetsavedID()
    {
        return savedID;
    }

    public List<Sprite> GetImages()
    {
        return Images;
    }

    public List<Sprite> GetSavedSprites()
    {
        return SavedSprites;
    }
}
