using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow1 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject myObject;
    BoxCollider2D myCollider;

    public bool inside = false;
    string collisionObj;

    void Start()
    {
        myCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = myObject.transform.position;
        //myCollider.size = new Vector2(myObject.GetComponent<BoxCollider2D>().size.x, myObject.GetComponent<BoxCollider2D>().size.y);
    }

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        inside = true;
        collisionObj = collision.gameObject.name;
        Debug.Log(collisionObj);
    }

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        inside = true;
        collisionObj = collision.gameObject.name;
        Debug.Log(collisionObj);
    }

    public bool isInside()
    { return inside; }

    public string insideObj()
    { return collisionObj; }
}
