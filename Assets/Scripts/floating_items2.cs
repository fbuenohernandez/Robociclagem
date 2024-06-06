using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class floating_items2 : MonoBehaviour
{
    bool follow = false;

    public bool inside = false;
    string collisionObj;

    public float rayDistance = 10f;  // Distance for the ray to check

    void CheckContacts()
    {
        Vector3[] directions = new Vector3[]
        {
            Vector3.down,  // Downward direction
            Vector3.up,    // Upward direction
            Vector3.left,  // Left direction
            Vector3.right, // Right direction
            Vector3.forward, // Forward direction
            Vector3.back   // Backward direction
        };

        foreach (Vector3 direction in directions)
        {
            // Origin of the ray is the object's position
            Vector3 origin = transform.position;

            // Perform the raycast
            RaycastHit hit;
            if (Physics.Raycast(origin, direction, out hit, rayDistance))
            {
                // The object is in contact with another object in this direction
                Debug.Log("Object is in contact with: " + hit.collider.name + " in direction: " + direction);
                // Additional logic if needed
            }

            // Optional: Draw the ray in the scene view for debugging purposes
            Debug.DrawRay(origin, direction * rayDistance, UnityEngine.Color.red);
        }
    }

// Update is called once per frame
    void Update()
    {
        
    CheckContacts();
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
        {
            gameObject.SetActive(false);
        }
    }
}
