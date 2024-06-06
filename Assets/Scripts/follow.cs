using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject myObject;
    private BoxCollider myCollider;

    public bool inside = false;
    public string collisionObj;

    void Start()
    {
        myObject = GameObject.Find(this.name.Split("_")[0]);
        myCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = myObject.transform.position;
        myCollider.size = new Vector3(myObject.GetComponent<BoxCollider>().size.x, myObject.GetComponent<BoxCollider>().size.y, 100);
    }

    private void OnCollisionEnter(Collision collision)
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
