using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBehavior : MonoBehaviour
{
    public float rotationSpeed = 2f;
    public float range = 6f;
    public int hitPoints = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (GameObject.FindGameObjectWithTag("Unit") != null)
        {
            Vector3 target = GameObject.FindGameObjectWithTag("Unit").transform;
            transform.LookAt(target);
        }

    }
    //private void OnCollisionEnter(Collision collision)
   // {
        
    //}
}
