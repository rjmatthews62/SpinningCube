using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateObject : MonoBehaviour
{
    public float speed = 10f;
    private int direction = 0;
    private Vector3 myvector = Vector3.up;
    private  Vector3[] vlist={Vector3.up,Vector3.left,Vector3.back,Vector3.down,Vector3.right,Vector3.forward};
    private string[] vnames={"Up","Left","Back","Down","Right","Forward"};
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting Rotate Test");
        transform.Rotate(Vector3.up,45f);
        Debug.Log("Kinda working...");
        direction=0;
        setVector();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(myvector,speed*Time.deltaTime);
    }

    public void doRotateClick() {
        Debug.Log("Clicked.");
        direction=(direction+1) % vlist.Length;
        setVector();
        GameObject label =GameObject.Find("Label");
        if (label!=null) {
            Text tx = label.GetComponent<Text>();
            tx.text=vnames[direction];
        }

    }

    private void setVector() {
        myvector=vlist[direction % vlist.Length];
    }

}
