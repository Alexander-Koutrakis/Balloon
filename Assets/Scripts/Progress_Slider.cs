using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Progress_Slider : MonoBehaviour
{
    private Slider slider;
    [SerializeField]
    private Player player;
    private int targetScore;
    private void Start()
    {
        slider = GetComponent<Slider>();
        slider.maxValue = (player.lists_to_Spawn.Count * player.colorChangeRate*player.savedID.Count)-1;
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
