using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevel : MonoBehaviour
{
    public void Colors_Level()
    {
        SceneManager.LoadScene("Colors_Endless");
    }

    public void Letters_Level()
    {
        SceneManager.LoadScene("Letters_Endless");
    }

    public void Shapes_Level()
    {
        SceneManager.LoadScene("Shapes_Endless");
    }
}
