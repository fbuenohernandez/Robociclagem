using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class floating_items1 : MonoBehaviour
{
    bool follow = false;

    public bool inside = false;
    string collisionObj;

    //private GameObject collisionPair;
    //private GameObject trashPair;

    BoxCollider2D box;

    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (follow)
        {
            transform.position = Input.mousePosition;
            //transform.position = Input.mousePosition;
        }

    }

    public void press()
    {
        follow = true;
    }

    public void release()
    {
        follow = false;

        if (inside)
        //if (collisionPair.GetComponent<follow>().isInside() && collisionPair.GetComponent<follow>().insideObj().Split("_")[0] == gameObject.name)
        {
            //Debug.Log(collisionPair.GetComponent<follow>().insideObj());
            //Debug.Log(gameObject.name);
            //collisionPair.SetActive(false);
            gameObject.SetActive(false);

            //Debug.Log(trashPair.name);

            //trashPair.GetComponent<trash>().StartShaking();
        }
    }

    void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        inside = true;
        collisionObj = collision.gameObject.name;
        Debug.Log(collisionObj);
    }

    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        inside = true;
        collisionObj = collision.gameObject.name;
        Debug.Log(collisionObj);
    }


}
