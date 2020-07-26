using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoToggle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                var selection = hit.transform;
                if (selection.GetComponent<VideoPlayer>())
                {
                    Debug.Log("hasVideo");
                    VideoPlayer video = selection.GetComponent<VideoPlayer>();
                    if (video.isPlaying)
                    {
                        video.Pause();
                    }
                    else
                    {
                        video.Play();
                    }
                }
                
            }
            
        }
    }
}
