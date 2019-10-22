using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneFigureRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float rotationSpeed = 0.03f;

    void OnMouseDrag()
    {
        Debug.Log("######## onMouseDrag" + Input.GetAxis("Mouse X"));

        float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;
        Debug.Log("######## rotationvalue:" + XaxisRotation + " " + YaxisRotation);
        // select the axis by which you want to rotate the GameObject
        transform.Rotate(Vector3.down, XaxisRotation);
        transform.Rotate(Vector3.right, YaxisRotation);
        /*float rotationX = Input.GetAxis("Mouse X") * rotationSpeed * Mathf.Deg2Rad;
        transform.Rotate(Vector3.down, -rotationX, Space.World);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
