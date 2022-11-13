using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelObjet : MonoBehaviour
{
    public GameObject PanelOn, objectOff;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
        PanelOn.SetActive(false);
    }

    // Update is called once per frame

    
    public void OnClickOn()
    {
        PanelOn.SetActive(true);
        
        objectOff.SetActive(false);
        audioSource.Play();
    }
    
    public void OffClickOff()
    {
        PanelOn.SetActive(false);
        
        objectOff.SetActive(true);
        
    }


    
}
