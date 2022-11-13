using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveData : MonoBehaviour
{
    public GameObject[] data;

    public GameObject[] dataActive;
    
    public GameManager gameManager;

    public void Remove()
    {
        
            
        for (int i = 0; i < data.Length; i++)
        { 
            data[i].SetActive(false);
        }

        for (int i = 0; i < dataActive.Length; i++)
        {
            dataActive[i].SetActive(true);
        }
    }
}
