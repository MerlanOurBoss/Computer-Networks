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
        scoreText.text = "���������� ����������� � �����������: " + score;
        Debug.Log(score);
    }
}
