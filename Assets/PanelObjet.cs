using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelObjet : MonoBehaviour
{
    public GameObject PanelOn, objectOff;
   
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
    }
    
    public void OffClickOff()
    {
        PanelOn.SetActive(false);
        
        objectOff.SetActive(true);
    }


    
}
