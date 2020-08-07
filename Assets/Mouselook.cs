using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Mouselook : MonoBehaviour
{

    public float mouseSpeed = 1500f;
    public float xRotation = 0.0f;

    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90.0f, 90.0f);


        transform.localRotation = Quaternion.Euler(xRotation, 0.0f, 0.0f);
        player.Rotate(Vector3.up * mouseX);
    }
}
