using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

public class VideoManager_sol : MonoBehaviour
{
    public List<VideoClip> videos = null;

    private bool isPaused = false;
    public bool IsPaused
    {
        get
        {
            return isPaused;
        }

        private set
        {
            isPaused = value;
        }
    }
    private bool isVideoReady = false;
    public bool IsVideoReady
    {
    get
    {
        return isVideoReady;
    }

    private set
    {
        isVideoReady = value;
    }
    }
    private int index = 0;
    private VideoPlayer videoPlayer = null;

    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    public void PauseToggle()
    {
        isPaused = !videoPlayer.isPaused;

        if(isPaused)
            videoPlayer.Pause();
        else
            videoPlayer.Play();
        
    }
}
