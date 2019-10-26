using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObject : MonoBehaviour
{
    public GameObject resetObj;
    Vector3 startPos;


    // Use this for initialization
    void Start()
    {
        startPos = transform.localScale;
        Debug.Log("Initial Position:" + startPos);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void reset()
    {
        resetObj.transform.localScale = startPos;

    }
}
