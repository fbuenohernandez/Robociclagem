using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class follow_2 : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject myObject;
    public BoxCollider2D myCollider;

    bool inside = false;
    string collisionObj = "nada";

    void Start()
    {
        myObject = GameObject.Find(this.name.Split("_")[0]);
        myCollider = GetComponent<BoxCollider2D>();

        //Debug.Log("OBJ " + myObject + "   " + " COL " + myCollider);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = myObject.transform.position;
        myCollider.size = new Vector3(myObject.GetComponent<BoxCollider2D>().size.x, myObject.GetComponent<BoxCollider2D>().size.y, 100);
    }

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        Debug.Log(collision.collider.tag + " " + "Untagged");
        Debug.Log(collision.collider.tag == "Untagged");


        if (collision.collider.tag != "Untagged")
        {
            inside = true;
            collisionObj = collision.gameObject.name;
            Debug.Log(this.name + " " + collisionObj);
        }
    }

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
      {
            Debug.Log(collision.tag + " " + "Untagged");
            Debug.Log(collision.tag == "Untagged");


            if (collision.tag != "Untagged")
            {
                inside = true;
                collisionObj = collision.gameObject.name;
                Debug.Log(this.name + " " + collisionObj);
        }
    }

    public bool isInside()
        { return inside; }

    public string insideObj()
    { return collisionObj; }
}
