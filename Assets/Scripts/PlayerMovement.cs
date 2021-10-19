using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 500f;

    public float rotateSpeed = 200f;
    public Vector2 screenCenter, lookInput, mouseDistance;

    private void Start()
    {
        screenCenter.y = Screen.height * 0.5f;
        screenCenter.x = Screen.width * 0.5f;
    }

    void Update()
    {
        lookInput.y = Input.mousePosition.y;
        lookInput.x = Input.mousePosition.x;
        float h = CrossPlatformInputManager.GetAxis("Horizontal");
        float v = CrossPlatformInputManager.GetAxis("Vertical");

        //float yRotationOffset = h * Time.deltaTime * rotateSpeed;
        float yRotationOffset = ((screenCenter.x - Input.mousePosition.x) / screenCenter.x) * Time.deltaTime * rotateSpeed;
        float xRotationOffset = ((screenCenter.y - Input.mousePosition.y) / screenCenter.y) * Time.deltaTime * rotateSpeed;
        float yOffset = Math.Abs(v) * Time.deltaTime * speed;

        Vector3 move = yOffset * transform.forward;
        Vector3 rotate = new Vector3(xRotationOffset, -yRotationOffset, 0);

        transform.position += move;
        transform.Rotate(rotate);
    }
}
