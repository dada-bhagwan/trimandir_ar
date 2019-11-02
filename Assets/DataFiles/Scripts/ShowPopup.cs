using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPopup : MonoBehaviour
{
    public GameObject PlaneObject ;

    public void DisableCanvas()
    {
        PlaneObject.SetActive(false);
    }

    public void EnableCanvas()
    {
        PlaneObject.gameObject.SetActive(true);
    }
    void ChangeCanvasProperty(GameObject yourCanvas, bool disable)
    {
        if (!disable)
            yourCanvas.SetActive(false);
        else
            yourCanvas.SetActive(true);
    }
}
