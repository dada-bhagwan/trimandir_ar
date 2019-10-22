using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

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

    public void GoTo360()
    {
        Application.OpenURL("https://www.google.com/maps/@23.1775304,72.5719942,3a,90y,19.82h,97.43t/data=!3m7!1e1!3m5!1sAF1QipPlMtvVyGnfo52XZpjLQbQVnMwllaECdGRSeMt0!2e10!3e12!7i13312!8i6656");
    }
}
