using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class QuizManager : MonoBehaviour
{

    public GameObject[] Levels;
    public GameObject End;
    public TextMeshProUGUI Scoring;
    private int score;
    public string scene;
    private float durasi;
    public float durasiPenilaian;

    int currentLevel;
    void Start () {
   
        Scoring.text = "";

        durasi = durasiPenilaian;

    }

    private void Update()
    {
        Scoring.text = "" + score;
    }

    public void wrongAnswer()
    {
        // ResetScreen.SetActive(true);
        if(currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);

            currentLevel++;
            Levels[currentLevel].SetActive(true);
            score = score + 0;
        }
        else
        {
            End.SetActive(true);
            Levels[currentLevel].SetActive(false);
            score = score + 0;
        }
    }

    public void NextScene ()
    {
        SceneManager.LoadScene(scene);
    }

    
    public void correctAnswer()
    {
        if(currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);

            currentLevel++;
            Levels[currentLevel].SetActive(true);
            score = score + 14;
        }
        else
        {
            End.SetActive(true);
            Levels[currentLevel].SetActive(false);
            score = score + 14;
        }
    }




}
