using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Unity.VisualScripting;
using UnityEngine;

public class floating_items : MonoBehaviour
{ 
    private float floatSpeed = 2.5f; // Speed of floating
    private float floatHeight = 5f; // Maximum height of floating

    private Vector2 startPos;

    private bool stopFloat = false;
    private bool follow = false;

    [SerializeField] GameObject collisionPair;
    [SerializeField] GameObject trashPair;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        //collisionPair = GameObject.Find(this.name + "_collider");
        //trashPair = GameObject.Find(Regex.Replace(this.name, @"\d", "") + "_");

        //Debug.Log("NAME " + this.name + "   " + "COL " + collisionPair + "   " + "TRASH " + trashPair);
    }

    void setPosition()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, this.transform.position.z));
        this.transform.position = new Vector3(pos.x, pos.y, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!stopFloat)
        {

            // Calculate the new Y position based on sine wave
            float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;

            // Move the object smoothly using Rigidbody's MovePosition
            transform.position = new Vector2(transform.position.x, newY);
        }
        else if (follow) transform.position = Input.mousePosition;

    }

    public void press()
    {
        stopFloat = true;
        follow = true;
    }

    public void release()
    {
        follow = false;

        string match = Regex.Replace(collisionPair.GetComponent<follow_2>().insideObj().Split("_")[0], @"\d", "") + "_";

        if (collisionPair.GetComponent<follow_2>().isInside() && GameObject.Find(match).name  == gameObject.name)
        {
            //Debug.Log(collisionPair.GetComponent<follow>().insideObj());
            //Debug.Log(gameObject.name);
            collisionPair.SetActive(false);
            gameObject.SetActive(false);

            //Debug.Log(trashPair.name);

            trashPair.GetComponent<trash>().StartShaking();
        }
        else transform.position = startPos;
    }


}
