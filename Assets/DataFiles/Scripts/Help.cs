using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Help : MonoBehaviour
{
    public Text my_text;
    // Start is called before the first frame update
    void Start()
    {
        my_text = GameObject.Find("version").GetComponent<Text>();
        my_text.text = Application.version;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DownloadImage()
    {
        Application.OpenURL("https://rebrand.ly/trimandirar");
    }

    public void OpenHelpVideo()
    {
        Application.OpenURL("https://rebrand.ly/trimandirarhelp");
    }
}
