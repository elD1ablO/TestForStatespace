using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBehavior : MonoBehaviour
{
    public float rotationSpeed = 100f;
    public float range = 6f;
    public int hitPoints = 3;

    public GameObject shootingPoint;
    public GameObject bullet;
    //GameObject[] units;
    //GameObject closestUnit;
    GameObject target;
    Quaternion lookAtUnit;
    
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Unit")
        {
            Debug.Log("Collision!!");
            Destroy(collision.gameObject);
            hitPoints--;
            Debug.Log(hitPoints);
        }
    }

   
    void Update()
    {
        target = GameObject.FindGameObjectWithTag("Unit");
        
        if (target != null)
        {
            float distanceToTurret = Vector3.Distance(transform.position, target.transform.position);

            if(range > distanceToTurret)
            {
                Vector3 direction = target.transform.position - transform.position;
                lookAtUnit = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, lookAtUnit, rotationSpeed * Time.deltaTime);
            }
        }
        
    }
        
}
