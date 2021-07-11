using System.Collections;
using System.Collections.Generic;
using System;

using UnityEngine;

public class AnimationTest : MonoBehaviour
{

    Animator m_Animator;


    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        AnimatorStateInfo st=m_Animator.GetCurrentAnimatorStateInfo(0);
        if (st.IsName("Fly") && frac(st.normalizedTime)<=0.80f) {
           transform.Rotate(Vector3.up,25.0f*Time.deltaTime);
            transform.Translate(Vector3.forward*Time.deltaTime*25.0f,Space.Self);


        } else if (st.IsTag("Walking")) {
            transform.Translate(Vector3.forward*Time.deltaTime*10.0f,Space.Self);
        } else if (st.IsTag("Run")) {
            transform.Translate(Vector3.forward*Time.deltaTime*15.0f,Space.Self);
        }
    }

    public void onFlyClick() {
        Debug.Log("Animator="+m_Animator.ToString());
        m_Animator.Play("Fly");
    }

    float frac(float f) {
        return f-(float) Math.Truncate(f);
    }

}
