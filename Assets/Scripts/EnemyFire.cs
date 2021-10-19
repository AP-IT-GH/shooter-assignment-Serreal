using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject bullet;
    private float timer = 10f;
    private bool start = false;
    public float shootRate = 0.5f;
    public float bulletSpeed = 2500f;

    void Update()
    {        
        if (timer >= shootRate)
        {
            GameObject newBullet = Instantiate(bullet, transform.position + transform.forward, transform.rotation);
            newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed, ForceMode.VelocityChange);
            start = true;
            timer = 0f;
        }
        if(start)
        {
            if (timer < shootRate)
            {
                timer += Time.deltaTime;
            } else
            {
                timer = shootRate;
                start = false;
            }
        }
    }
}
