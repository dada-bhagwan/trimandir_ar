using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public bool isWithoutTarget = false; 
    float speed = 0.1f;
    Vector3 mPrevPos = Vector3.zero;
    Vector3 mPosDelta = Vector3.zero;
    DateTime prevTime;
    public GameObject plane;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Animation>().Rewind();
        
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("############ " + Input.GetMouseButton(0));
        if (Input.GetMouseButton(0))
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                {
                    Debug.Log("##### Touch Began");
                    mPrevPos = Vector3.zero;

                    Animator cachedRef = gameObject.GetComponent<Animator> ();

                    if ( cachedRef != null)
                    {
                        cachedRef.StopPlayback (); ;
                    }
                    if(plane != null)
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

    void rotateModel()
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
    }

    public void restetAnimation()
    {
        Animator cachedRef = gameObject.GetComponent<Animator> ();
        if (cachedRef != null)
        {
            cachedRef.StartPlayback (); ;
        }

        if (plane != null)
        {
            if(isWithoutTarget)
            {
                plane.transform.localScale = new Vector3(2.460715f, 4.101191f, 1.640476f);
            }
            else
            {
                plane.transform.localScale = new Vector3(0.16453f, 0.16453f, 0.16453f);
            }
            
        }
    }
}
