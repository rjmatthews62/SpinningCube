using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject m_source;

    public void Fire() {
        Rigidbody body=GetComponent<Rigidbody>();
        transform.SetPositionAndRotation(m_source.transform.position,m_source.transform.rotation);
        transform.Translate(Vector3.forward*10);
        transform.Translate(Vector3.up*10);
        transform.Rotate(Vector3.left*45);
        Vector3 v = transform.rotation * Vector3.forward;
        body.velocity=v*20f;
    }

}
