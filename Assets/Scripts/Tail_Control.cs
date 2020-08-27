using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tail_Control : MonoBehaviour
{   [SerializeField]
    private List<SpriteRenderer> tail_Sprite_list = new List<SpriteRenderer>();
    private int list_Length=0;
  


    public void Add_To_Tail(Sprite sprite)
    {
        if (list_Length >= tail_Sprite_list.Count)
        {
            list_Length = 0;
        }

        tail_Sprite_list[list_Length].sprite = sprite;
        list_Length++;
    }
}
