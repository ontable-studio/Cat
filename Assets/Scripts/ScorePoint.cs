using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScorePoint : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Teks yang akan menampilkan skor
    private float currentTime = 0f;
    private int currentScore = 0;

    private void Start()
    {
        currentTime = 0f;
        currentScore = 00;
        UpdateScoreText();
    }

    private void Update()
    {
        // Perhitungan waktu berdasarkan frame time
        currentTime += Time.deltaTime;

        // Lakukan pembaruan skor berdasarkan waktu (misalnya, tambah 1 skor setiap 1 detik)
        if (currentTime >= 0.1f)
        {
            currentTime = 0f;
            currentScore++;
            UpdateScoreText();
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + currentScore;
    }
}
