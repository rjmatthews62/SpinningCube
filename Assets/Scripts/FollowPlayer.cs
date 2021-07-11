using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform targetObject;
    public Vector3 cameraOffset;
    public float smoothFactor = 0.5f;
    public bool lookAtTarget = false;

    // Start is called before the first frame update
    void Start()
    {
      cameraOffset = transform.position - targetObject.transform.position;   
    }

    void LateUpdate()
    {
        Vector3 newPosition = targetObject.transform.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position,newPosition,smoothFactor);
        if (lookAtTarget) {
            transform.LookAt(targetObject);
        }

    }

    public void SpinCamera(float degrees) {
        transform.RotateAround(targetObject.position,Vector3.up,degrees);
        cameraOffset = transform.position - targetObject.transform.position;
        transform.LookAt(targetObject);
    }
}