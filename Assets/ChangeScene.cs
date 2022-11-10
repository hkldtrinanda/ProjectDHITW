using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public string sceneName, sceneName2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    
    public void OnClickOn()
    {
        SceneManager.LoadScene(sceneName2);
    }
    
    public void ExitAps()
    {
        Application.Quit();
    }
    
}
