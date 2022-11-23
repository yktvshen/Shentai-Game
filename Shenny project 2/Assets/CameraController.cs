using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensitivity = 10f; //1 
    public Transform playerBody; //2
    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = sensitivity * Input.GetAxis("Mouse X") * Time.deltaTime;
        float y = sensitivity * Input.GetAxis("Mouse Y") * Time.deltaTime;
        playerBody.Rotate(Vector3.up * x); //2 
        xRotation -= y; //3 
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); //4 
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); //5
    }
}