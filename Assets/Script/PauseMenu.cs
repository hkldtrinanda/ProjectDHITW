using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private bool gameisPaused;
    public GameObject PanelOn, objectOff;
    // Start is called before the first frame update
    void Start()
    {
        PanelOn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameisPaused)
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Pause();
            }
            {
                Resume();
            }

    }
    
    public void Resume()
    {
        PanelOn.SetActive(false);
        Time.timeScale = 1f;
        gameisPaused = false;
    }
    
    public void Pause()
    {
        PanelOn.SetActive(true);
        Time.timeScale = 0f;
        gameisPaused = true;
    }
}
