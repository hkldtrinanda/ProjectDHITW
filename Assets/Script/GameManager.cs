using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int counter;
    
    public TextMeshProUGUI counterText;

    private void Start()
    {
        counter = 7;
        counterText.text = counter.ToString() ;
    }

    public void AddCounter()
    {
        counter--;
        counterText.text = counter.ToString();

    }
}
