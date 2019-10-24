using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceOrientation : MonoBehaviour
{

    public bool iaLandscapeLeft = true;
    public bool autoRotation = false;
    // Start is called before the first frame update
    void Start()
    {
        if(autoRotation)
        {
            Screen.orientation = ScreenOrientation.AutoRotation;
        } else
        {
            if (iaLandscapeLeft)
                Screen.orientation = ScreenOrientation.LandscapeLeft;
            else
                Screen.orientation = ScreenOrientation.Portrait;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
