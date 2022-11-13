using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    /*public string sceneName;*/
    static public Main Instance;

    public int switchCount;
    public GameObject winPanel;
    private int onCount = 0;

    private void Awake()
    {
        Instance = this;
    }
    public void SwitchChange(int points) {
        onCount = onCount + points;
        if (onCount == switchCount)
        {
            /*SceneManager.LoadScene(sceneName);*/
            winPanel.SetActive(true);
        }
    }
    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }*/
    }
}
