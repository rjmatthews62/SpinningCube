using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public void LoadDragon() {
        SceneManager.LoadScene("Dragon",LoadSceneMode.Single);
    }

    public void LoadCube() {
        SceneManager.LoadScene("RotationScene",LoadSceneMode.Single);
    }

    public void QuitGame() {
        Debug.Log("Quitting...");
        Application.Quit(0);
    }

    public void LoadMenu() {
        SceneManager.LoadScene("Menu",LoadSceneMode.Single);
    }

    public void AddCube() {
        GameObject cube =  GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.localScale=new Vector3(10,10,10);
        float x=Random.Range(-100f,100f);
        float y=Random.Range(-100f,100f);
        cube.transform.Translate(new Vector3(x,5,y),Space.World);
        Color c = new Color(Random.value, Random.value, Random.value);
        cube.GetComponent<Renderer>().material.color=c;
        Debug.Log(string.Format("Cube={0} {1} {2}",x,y,c));
    }
}
