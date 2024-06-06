using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class click_vanish : MonoBehaviour
{
    float floatSpeed = 2f; // Speed of floating
    float floatHeight = 10f; // Maximum height of floating

    Vector2 startPos;

    GameObject hand;

    public GameObject gameObj;

    void Start()
    {
        startPos = transform.position;
        hand = GameObject.Find("Mao");
    }

    void Update()
    {
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = new Vector2(transform.position.x, newY);
    }

    public void ClickDestroy()
    {
        gameObj.GetComponent<play_sound>().PLAY();
        hand.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
