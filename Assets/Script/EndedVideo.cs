using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class EndedVideo : MonoBehaviour
{
    public VideoPlayer VideoPlayer;
    public string scene;// Drag & Drop the GameObject holding the VideoPlayer component

    public float FrameRate = 60f;
    public double Fframerate = 60f;
    void Start()
    {
        VideoPlayer.loopPointReached += LoadScene;
        FrameRate = VideoPlayer.frameRate;
        Fframerate = VideoPlayer.frameRate;
    }
    void LoadScene(VideoPlayer vp)
    {
        SceneManager.LoadScene(scene);
    }
}