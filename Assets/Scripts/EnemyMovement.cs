using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float vSpeed = 1f;
    public float xSpeed = 1f;
    //public float rSpeed = 50f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.up * rSpeed * Time.deltaTime);
        transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * vSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * xSpeed * Time.deltaTime);
    }
}
