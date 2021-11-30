using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Turret")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
