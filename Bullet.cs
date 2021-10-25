using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float bulletLifetime = 2f;   
    void FixedUpdate()
    {
        Destroy(gameObject, bulletLifetime);
    }
    
}
