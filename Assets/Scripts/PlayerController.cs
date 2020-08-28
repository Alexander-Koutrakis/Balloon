using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 target_Pos;
    public static PlayerController Instance;
    private Vector3 mouseDownPos;
    public Vector3 direction;
    public Vector3 mouseDelta = Vector3.zero;
    private Vector3 lastMousePosition = Vector3.zero;
    private void Awake()
    {
        Instance = this;
    }
    //private void OnMouseDown()
    //{      
    //    target_Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    target_Pos = new Vector3(target_Pos.x, 0, 0);     
    //}

    //private void OnMouseUp()
    //{
    //    target_Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    target_Pos = new Vector3(target_Pos.x, 0, 0);
    //}

    //private void OnMouseDrag()
    //{
    //    target_Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    target_Pos = new Vector3(target_Pos.x, 0, 0);
    //}

    //private void OnMouseDown()
    //{
    //    mouseDownPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //}


    private void OnMouseUp()
    {
        direction = Vector3.zero;
    }


    private void Update()
    {






        if (Input.GetMouseButtonDown(0))
        {
            mouseDownPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0))
        {



            mouseDelta = Input.mousePosition - lastMousePosition;

            lastMousePosition = Input.mousePosition;

            if(mouseDelta == Vector3.zero)
            {
                mouseDownPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }


            if ((Camera.main.ScreenToWorldPoint(Input.mousePosition).x - mouseDownPos.x)>0.1f&&mouseDelta!=Vector3.zero)
            {
                Debug.Log("You dragged Right!");
                direction = Vector3.right;
            }
            else if ((Camera.main.ScreenToWorldPoint(Input.mousePosition).x - mouseDownPos.x)<-0.1f && mouseDelta != Vector3.zero)
            {
                Debug.Log("You dragged Left!");
                direction = Vector3.left;
            }
            else
            {
                Debug.Log("You stop dragging!");
                direction = Vector3.zero;
            }
        }
    }

    private bool MouseIsMoving()
    {



        return true;
    }
}
