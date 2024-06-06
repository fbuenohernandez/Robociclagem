using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody2D rb;
    public float amount = 100f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("j")) rb.velocity = Vector2.left * amount;
        else if (Input.GetKey("l")) rb.velocity = Vector2.right * amount;
        else rb.velocity = Vector2.zero;
    }
}
