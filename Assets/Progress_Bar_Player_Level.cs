﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Progress_Bar_Player_Level : MonoBehaviour
{
    private Slider slider;
    [SerializeField]
    private Player_Levels player;
    private int targetScore;

    private void Start()
    {
        slider = GetComponent<Slider>();
        slider.maxValue = ((player.lists_to_Spawn.Count+1) * player.colorChangeRate * player.savedID.Count) - 1;
    }


    public void Add_Score(int score)
    {
        StopAllCoroutines();
        targetScore = score;
        StartCoroutine(LerpScore());
    }

    private IEnumerator LerpScore()
    {
        while (slider.value < targetScore * 0.95f)
        {
            slider.value = Mathf.Lerp(slider.value, targetScore, Time.deltaTime);
            yield return null;
        }
    }

   
}
