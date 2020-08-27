using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevel : MonoBehaviour
{
    public void Colors_Level()
    {
        SceneManager.LoadScene("Colors_Level_1");
    }

    public void Letters_Level()
    {
        SceneManager.LoadScene("Letters_Level_1");
    }

    public void Shapes_Level()
    {
        SceneManager.LoadScene("Shapes_Level_1");
    }
}
