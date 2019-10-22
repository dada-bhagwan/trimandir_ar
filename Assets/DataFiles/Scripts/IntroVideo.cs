using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class IntroVideo : MonoBehaviour
{

    public bool isEng = false;
    public VideoPlayer VideoPlayerObj;
    public AudioSource engClip;
    public AudioSource hinClip;
    public Button engBtn;
    public Button hinBtn;

    //Color BtnDefaultColor = new Color(255,0,0,255);
    Color BtnDefaultColor = Color.blue;
    void Start()
    {
        hinBtn.GetComponent<Image>().color = BtnDefaultColor;
    }

    
    void Update()
    {
        
    }

    public void OnEngClick()
    {
        if(!isEng)
        {
            isEng = true;
            SwitchAudio(isEng);
        }
    }

    public void OnHinClick()
    {
        if (isEng)
        {
            isEng = false;
            SwitchAudio(isEng);
        }
    }

    void SwitchAudio(bool isEng)
    {
        VideoPlayerObj.Stop();
        if (isEng)
        {
            hinClip.Stop();
            engClip.Play();
            engBtn.GetComponent<Image>().color = BtnDefaultColor;
            hinBtn.GetComponent<Image>().color = Color.white;
        } else
        {
            engClip.Stop();
            hinClip.Play();
            hinBtn.GetComponent<Image>().color = BtnDefaultColor;
            engBtn.GetComponent<Image>().color = Color.white;
        }

        VideoPlayerObj.Play();
    }
}
