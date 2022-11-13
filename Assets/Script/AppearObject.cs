using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearObject : MonoBehaviour
{

    public int counterNeeded;
    public GameManager gameManager;

    public GameObject gameObject, Panelpertanyaan, dissapearObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.counter == counterNeeded)
        {
            gameObject.SetActive(true);
        }

    }
    
    public void Pertanyaan()
    {
        Panelpertanyaan.SetActive(true);
        dissapearObject.SetActive(false);
    }
}
