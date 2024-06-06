using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using static UnityEditor.Experimental.GraphView.Port;

public class trash_2 : MonoBehaviour
{
    private float shakeSpeed = 30; // Speed of the shake movement
    private float shakeIntensity = 5; // Intensity of the shake movement
    private float shakeDuration = 0.5f; // Duration of the shake in seconds
    private Quaternion originalRotation; // Original rotation of the sprite
    private bool isShaking = false; // Flag to indicate if shaking is in progress
    private Vector2 pos;

    public bool onTop;

    public float alpha = 0.5f;

    void Start()
    {
        originalRotation = transform.rotation; // Store the original rotation of the sprite
        pos = transform.localPosition;
    }

    void Update()
    {
        if (isShaking)
        {
            // Calculate shake rotation using sine function
            float shakeAmount = Mathf.Sin(Time.time * shakeSpeed) * shakeIntensity;
            // Apply the shake rotation to the sprite's rotation
            transform.rotation = originalRotation * Quaternion.Euler(0f, 0f, shakeAmount);

            shakeIntensity -= Time.deltaTime * (shakeIntensity / shakeDuration);

        }
    }

    // Function to start the shaking

    public void StartShaking()
    {
        isShaking = true;
        Invoke("StopShaking", shakeDuration); // Invoke StopShaking after shakeDuration seconds
    }

    // Function to stop the shaking
    void StopShaking()
    {
        isShaking = false;
        // Reset the sprite's rotation to its original rotation
        transform.rotation = originalRotation;
        shakeIntensity = 5;
    }

    public void OnTop()
    {
        Debug.Log("IN");
        Color col = GetComponent<Image>().color;
        col.a = alpha;
        GetComponent<Image>().color = col;
        onTop = true;
    }
    public void OutTop()
    {
        Debug.Log("OUT");
        Color col = GetComponent<Image>().color;
        col.a = 1;
        GetComponent<Image>().color = col;
        onTop = false;
    }

    public bool GetBool()
    {
        return onTop;
    }
    public void Teste()
    {
        Debug.Log("TESTE");
    }

    public string Name()
    {
        return this.name;
    }

}