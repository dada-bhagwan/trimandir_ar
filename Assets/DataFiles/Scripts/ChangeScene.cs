using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public GameObject PopupObj;
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GoToTrimandir()
    {
        SceneManager.LoadScene("Trimandir");
    }


    public void GoToVideo()
    {
        SceneManager.LoadScene("Video");
    }

    public void GoToHelp()
    {
        SceneManager.LoadScene("Help");
    }
	
	public void GoToWithoutImage()
    {
        SceneManager.LoadScene("WithoutTarget");
    }

    public void GoTo360()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        //Trimandir Start
        //Application.OpenURL("https://www.google.com/maps/@23.1775304,72.5719942,3a,90y,19.82h,97.43t/data=!3m7!1e1!3m5!1sAF1QipPlMtvVyGnfo52XZpjLQbQVnMwllaECdGRSeMt0!2e10!3e12!7i13312!8i6656");
        //Simandhar Swami
        Application.OpenURL("https://www.google.com/maps/@23.1787268,72.5714158,3a,90y,14.98h,99.54t/data=!3m7!1e1!3m5!1sAF1QipP6g20tOQj-4VvjHbxx53gbc4gaHHt484f6Sqa_!2e10!3e12!7i13312!8i6656");
        //Application.OpenURL("https://www.google.com/maps/contrib/108262517483979483446/photos/@23.1779906,72.5719269,3a,75y,4.18h,76.91t/data=!3m7!1e1!3m5!1sAF1QipPPpLqBE0RoW-7X3Oy5qY4_wSRGQJK0TIxnJT-K!2e10!6shttps:%2F%2Flh5.googleusercontent.com%2Fp%2FAF1QipPPpLqBE0RoW-7X3Oy5qY4_wSRGQJK0TIxnJT-K%3Dw365-h260-k-no-pi-20.13373-ya203.70383-ro0-fo100!7i13312!8i6656!4m3!8m2!3m1!1e1");
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    public void OpenTrimandirORG()
    {
        Application.OpenURL("https://www.trimandir.org");
    }
	
	public void OpenDadabhagwanORGSite()
    {
        Application.OpenURL( "https://www.dadabhagwan.org/");
    }

    public void FeedbackMail()
    {
        Application.OpenURL("mailto:dadabhagwanapps@googlegroups.com?subject=Feedback/Bug%20Report%20of%20Trimandir%20AR");
    }
	
    public void GoToHindiIntro()
    {
        Application.OpenURL("https://youtu.be/ZCguZTejSho");
        if(PopupObj != null)
        {
            PopupObj.SetActive(false);
        }
            
    }

    public void GoToEngIntro()
    {
        Application.OpenURL("https://youtu.be/z0Qmk-TtPNs");
        if (PopupObj != null)
        {
            PopupObj.SetActive(false);
        }
    }

}
