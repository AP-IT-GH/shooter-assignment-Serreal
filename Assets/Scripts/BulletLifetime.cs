using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLifetime : MonoBehaviour
{
    private float timer = 0;
    public float lifeTime = 0.2f;

    void Update()
    {
        if (timer < lifeTime)
        {
            timer += Time.deltaTime;
        }   else
        {
            Destroy(gameObject);
        }
    }
}
