using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObject : MonoBehaviour
{
    public GameObject resetObj;
    Vector3 startScale;
    Vector3 startPos;
    Quaternion startRotation;


    // Use this for initialization
    void Start()
    {
        startPos = resetObj.transform.position;
        startRotation = resetObj.transform.rotation;
        startScale = resetObj.transform.localScale;
        Debug.Log("Initial Position:" + startPos);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void reset()
    {
        resetObj.SetActive(true);
        resetObj.transform.rotation = startRotation;
        resetObj.transform.position = startPos;
        resetObj.transform.localScale = startScale;
        Debug.Log("Reset Position:" + startPos);
    }
}
