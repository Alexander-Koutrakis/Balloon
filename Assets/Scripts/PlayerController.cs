using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 target_Pos;
    public static PlayerController Instance;


    private void Awake()
    {
        Instance = this;
    }
    private void OnMouseDown()
    {

        target_Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target_Pos = new Vector3(target_Pos.x, 0, 0);
       
    }

    private void OnMouseUp()
    {
        target_Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target_Pos = new Vector3(target_Pos.x, 0, 0);
    }

    private void OnMouseDrag()
    {
        target_Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target_Pos = new Vector3(target_Pos.x, 0, 0);
    }
}
