using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class UnitBehavior : Unit
{
    Transform target;
    public float speed = 1f;
    
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Turret") != null)
        {
           SearchTarget();
        }              
    }
    
    public void SearchTarget()
    {
        target = GameObject.FindGameObjectWithTag("Turret").transform;
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }
}
