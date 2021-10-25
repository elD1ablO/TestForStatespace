using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class UnitBehavior : MonoBehaviour
{
    Transform target;
    public float speed = 1f;
    
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Turret") != null)
        {
            target = GameObject.FindGameObjectWithTag("Turret").transform;
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        }
              
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Turret")
        {
            Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }

    }
}
