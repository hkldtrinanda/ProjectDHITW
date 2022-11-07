using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelObjet : MonoBehaviour
{
    public GameObject PanelOn, objectOff;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
        PanelOn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnClickOn()
    {
        PanelOn.SetActive(true);
        gameManager.counter++;
        objectOff.SetActive(false);
    }
    
}
