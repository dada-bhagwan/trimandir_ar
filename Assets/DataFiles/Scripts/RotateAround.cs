using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    float speed = 0.1f;
    Vector3 mPrevPos = Vector3.zero;
    Vector3 mPosDelta = Vector3.zero;
    public GameObject plane;
    Vector3 planeInitialScale;

    Vector3 startScale;
    Vector3 startPos;
    Quaternion startRotation;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Animation>().Rewind();
        planeInitialScale = plane.transform.localScale;
        startPos = this.transform.position;
        startRotation = transform.rotation;
        startScale = transform.localScale;
        Debug.Log("Start:" + startPos + "\t" + startRotation + "\t" + startScale);
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("############ " + Input.GetMouseButton(0));
        if (Input.GetMouseButton(0))
        {
            if(Input.touches.Length == 1)
            {
                Touch touch = Input.touches[0];
                if (touch.phase == TouchPhase.Began)
                {
                    Debug.Log("##### Touch Began");
                    mPrevPos = Vector3.zero;

                    Animator cachedRef = gameObject.GetComponent<Animator>();
                    Debug.Log("##### Touch cachedRef:" + cachedRef);
                    if (cachedRef != null)
                    {
                        cachedRef.StopPlayback();
                        cachedRef.enabled = false;
                    }
                    if (plane != null)
                    {
                        plane.transform.localScale = new Vector3(0, 0, 0);
                    }
                }

                //Detects Swipe while finger is still moving
                if (touch.phase == TouchPhase.Moved)
                {
                    Debug.Log("##### Touch Moved");
                    rotateModel();
                }

                //Detects swipe after finger is released
                if (touch.phase == TouchPhase.Ended)
                {
                    Debug.Log("##### Touch Ended");
                }
            }
        }
        //mPrevPos = Input.mousePosition;
        //transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
        //transform.Rotate(0, -speed * Time.deltaTime, 0, Space.World);

    }

    /*void rotateModel()
    {
        if(mPrevPos != Vector3.zero)
        {
            Debug.Log("############ Mouse" + Input.mousePosition + "   mPrevPos:" + mPrevPos);
            mPosDelta = Input.mousePosition - mPrevPos;
            Debug.Log("############ " + Vector3.Dot(mPosDelta, Camera.main.transform.up));
            Debug.Log("############ spped" + speed * Vector3.Dot(mPosDelta, Camera.main.transform.up));
            if (Vector3.Dot(transform.up, Vector3.up) >= 0)
            {
                transform.Rotate(transform.up, speed *  -Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);
            }
            else
            {
                transform.Rotate(transform.up, speed *  Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);
            }

            transform.Rotate(Camera.main.transform.right, speed *  Vector3.Dot(mPosDelta, Camera.main.transform.up), Space.World);
        }
        mPrevPos = Input.mousePosition;
    }*/

    void rotateModel()
    {
        if (mPrevPos != Vector3.zero)
        {
            Debug.Log("############ Mouse" + Input.mousePosition + "   mPrevPos:" + mPrevPos);
            mPosDelta = Input.mousePosition - mPrevPos;
            Debug.Log("############ " + Vector3.Dot(mPosDelta, Camera.main.transform.up));
            Debug.Log("############ spped" + speed * Vector3.Dot(mPosDelta, Camera.main.transform.up));
            if (Vector3.Dot(transform.up, Vector3.up) >= 0)
            {
                transform.Rotate(transform.up, speed * -Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);
            }
            else
            {
                transform.Rotate(transform.up, speed * Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);
            }

            transform.Rotate(Camera.main.transform.right, speed * Vector3.Dot(mPosDelta, Camera.main.transform.up), Space.World);
        }
        mPrevPos = Input.mousePosition;
    }

    public void restetAnimation()
    {
        //transform.rotation = startRotation;
        transform.position = startPos;
        transform.localScale = startScale;
        transform.rotation = new Quaternion(-90, 180, 0,0);
        //this.transform.localScale = new Vector3(0.005f, 0.005f, 0.005f);
        Debug.Log("Start:" + gameObject.transform.position + "\t" + gameObject.transform.rotation + "\t" + gameObject.transform.localScale);
        Animator cachedRef = gameObject.GetComponent<Animator> ();
        if (cachedRef != null)
        {
            cachedRef.enabled = true;
            //cachedRef.StartPlayback();
            cachedRef.Rebind();
        }

        if (plane != null)
        {
            plane.transform.localScale = planeInitialScale;
        }
    }
}
