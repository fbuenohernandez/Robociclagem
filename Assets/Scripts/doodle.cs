using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doodle : MonoBehaviour
{
    public float floatSpeed = 5f; // Velocidade de flutua��o
    public float floatAngle = 15f; // �ngulo m�ximo de flutua��o

    private float startAngle;
    private Quaternion startRotation;


    // Start is called before the first frame update
    void Start()
    {
        startAngle = transform.rotation.eulerAngles.z;
        startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        // Calcula o novo �ngulo baseado em uma onda senoidal
        float newAngle = startAngle + (float) Math.Round(Mathf.Sin(Time.time * floatSpeed)) * floatAngle;

        if (newAngle != 0)
        {
            // Converte o �ngulo para um valor entre -180 e 180 graus
            newAngle = Mathf.Clamp(newAngle, -180f, 180f);

            // Define a rota��o do objeto
            transform.rotation = startRotation * Quaternion.Euler(0f, 0f, newAngle);
        }
    }
}
