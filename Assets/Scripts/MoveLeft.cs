using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private void OnMouseDown()
    {
        gameObject.GetComponentInParent<Rigidbody2D>().velocity = new Vector3(-30, 0, 0);
        Debug.Log("Here");
    }

    private void OnMouseUpAsButton()
    {
        gameObject.GetComponentInParent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
    }
}
