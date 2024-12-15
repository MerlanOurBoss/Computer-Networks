using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;


    private void Update()
    {
        scoreText.text = "Подключено компьютеров к коммутатору: " + score;
        Debug.Log(score);
    }
}
