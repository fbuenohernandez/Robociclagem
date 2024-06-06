using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_controller2 : MonoBehaviour
{
    GameObject obj1;
    GameObject obj2;
    GameObject obj3;
    GameObject obj4;
    GameObject obj5;
    GameObject obj6;

    //[SerializeField] SceneAsset scene;
 
    void Start()
    {
        obj1 = GameObject.Find("Papel");
        obj2 = GameObject.Find("Papel2");
        obj3 = GameObject.Find("Lata");
        obj4 = GameObject.Find("Lata2");
        obj5 = GameObject.Find("Garrafa");
        obj6 = GameObject.Find("Garrafa2");
    }

    void Update()
    {
       //Debug.Log(scene.name);

        if (
            !obj1.activeSelf &&
            !obj2.activeSelf &&
            !obj3.activeSelf &&
            !obj4.activeSelf &&
            !obj5.activeSelf &&
            !obj6.activeSelf)
        {
        //    Debug.Log(scene.name);
        //    SceneManager.LoadScene(scene.name);
        }
            
    }
}
