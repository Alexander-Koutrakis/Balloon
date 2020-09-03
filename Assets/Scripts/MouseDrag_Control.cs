using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag_Control : MonoBehaviour
{

    [SerializeField]
    private Player player;
    [SerializeField]
    private Player_Levels player_Levels;

    public void OnMouseDown()
    {
        if (player != null)
        {
            player.MoveToPosition();
        }
        else
        {
            player_Levels.MoveToPosition();
        }

    }

    public void OnMouseDrag()
    {
        if (player != null)
        {
            player.MoveToPosition();
        }
        else
        {
            player_Levels.MoveToPosition();
        }
     
    }
}
