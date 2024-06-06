using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class floating_items_nofloat : MonoBehaviour
{

    public GameObject gameObj;

    public float floatSpeed = 5f; // Velocidade de flutuação
    public float floatAngle = 15f; // Ângulo máximo de flutuação

    private float startAngle;
    private Quaternion startRotation;


    // Start is called before the first frame update
   
    //private float floatSpeed = 2.5f; // Speed of floating
    //private float floatHeight = 5f; // Maximum height of floating

    private Vector2 startPos;

    private bool stopFloat = false;
    private bool follow = false;

    //[SerializeField] GameObject collisionPair;
    [SerializeField] GameObject trashPair;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        //collisionPair = GameObject.Find(this.name + "_collider");
        //trashPair = GameObject.Find(Regex.Replace(this.name, @"\d", "") + "_");

        //Debug.Log("NAME " + this.name + "   " + "COL " + collisionPair + "   " + "TRASH " + trashPair);

        startAngle = transform.rotation.eulerAngles.z;
        startRotation = transform.rotation;
    }

    //void setPosition()
    //{
    //    Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, this.transform.position.z));
    //    this.transform.position = new Vector3(pos.x, pos.y, 1.5f);
    //}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("r")) SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        if (!stopFloat)
        {

            // Calculate the new Y position based on sine wave
            //float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;

            // Move the object smoothly using Rigidbody's MovePosition
            //transform.position = new Vector2(transform.position.x, newY);

            // Calcula o novo ângulo baseado em uma onda senoidal
            float newAngle = startAngle + (float) Math.Round(Mathf.Sin(Time.time * floatSpeed)) * floatAngle;

            if (newAngle != 0)
            {
                // Converte o ângulo para um valor entre -180 e 180 graus
                newAngle = Mathf.Clamp(newAngle, -180f, 180f);

                // Define a rotação do objeto
                transform.rotation = startRotation * Quaternion.Euler(0f, 0f, newAngle);
            }
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

        Debug.Log(trashPair.GetComponent<trash_2>().GetBool() && Regex.Replace(this.name.Split("_")[0], @"\d", "") + "_" == trashPair.GetComponent<trash_2>().Name());

        if (trashPair.GetComponent<trash_2>().GetBool() && Regex.Replace(this.name.Split("_")[0], @"\d", "") + "_" == trashPair.GetComponent<trash_2>().Name())
        {
            //Debug.Log(collisionPair.GetComponent<follow>().insideObj());
            //Debug.Log(gameObject.name);
            //collisionPair.SetActive(false);
            gameObject.SetActive(false);

            //Debug.Log(trashPair.name);

            gameObj.GetComponent<play_sound>().PLAY();

            trashPair.GetComponent<trash_2>().StartShaking();
        }
        else
        {
            transform.position = startPos;
            stopFloat = false;
        }
    }

}
