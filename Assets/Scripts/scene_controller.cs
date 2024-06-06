using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_controller : MonoBehaviour
{
    GameObject obj1;
    GameObject obj2;
    GameObject obj3;
    GameObject obj4;
    GameObject obj5;
    GameObject obj6;

    GameObject menu;

    void Start()
    {
        obj1 = GameObject.Find("Papel");
        obj2 = GameObject.Find("Papel2");
        obj3 = GameObject.Find("Lata");
        obj4 = GameObject.Find("Lata2");
        obj5 = GameObject.Find("Garrafa");
        obj6 = GameObject.Find("Garrafa2");
        menu = GameObject.Find("Menu");
    }

    void Update()
    {
        if (
            !obj1.activeSelf &&
            !obj2.activeSelf &&
            !obj3.activeSelf &&
            !obj4.activeSelf &&
            !obj5.activeSelf &&
            !obj6.activeSelf)
            menu.SetActive(true);
    }
}
