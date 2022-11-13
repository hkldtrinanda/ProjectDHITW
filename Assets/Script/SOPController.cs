using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SOPController : MonoBehaviour
{
    public static SOPController instance;
    [SerializeField] Button doneButton;
    [SerializeField] int totalSOP;
    [SerializeField] int completedSOP;

    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        completedSOP = 0;
        doneButton.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addCompletedSOP()
    {
        completedSOP++;

        if (completedSOP == totalSOP)
        {
            doneButton.interactable = true;
        }
    }

    
}
