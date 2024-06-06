using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trash : MonoBehaviour
{
    private float shakeSpeed = 30; // Speed of the shake movement
    private float shakeIntensity = 5; // Intensity of the shake movement
    private float shakeDuration = 0.5f; // Duration of the shake in seconds
    private Quaternion originalRotation; // Original rotation of the sprite
    private bool isShaking = false; // Flag to indicate if shaking is in progress

    void Start()
    {
        originalRotation = transform.rotation; // Store the original rotation of the sprite
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
}