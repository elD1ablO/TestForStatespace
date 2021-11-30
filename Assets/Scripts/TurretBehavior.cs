using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBehavior : MonoBehaviour
{
    public float rotationSpeed = 80f;
    private float range = 6f;
    private int hitPoints = 3;
    
    float bulletForce = 2f;
    float fireRate = 1f;
    float nextFire = 0f;
    bool canShoot = false;
    bool targetLocked = false;

    public Transform shootingPoint;
    public GameObject bulletPrefab;
    
    GameObject target;
    Quaternion lookAtUnit;  
    
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Unit")
        {            
            Destroy(collision.gameObject);
            hitPoints--;
            Debug.Log("Collision!! HP left = "+hitPoints);
            if (hitPoints < 1)
            {
                
                Destroy(gameObject);
                GameManager.instance.EndGame();
            }
        }
    }

   
    void FixedUpdate()
    {
        target = GameObject.FindGameObjectWithTag("Unit");
        if (target == null)
        {
            canShoot = false;
        }

        else if (target != null)
        {
            LockOnTarget();
        }

        if (targetLocked && canShoot && Time.time > nextFire)
        {
            Shoot();
        }
    }

    
    void Shoot()
    {        
        GameObject bullet = Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation);        
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(shootingPoint.forward * bulletForce, ForceMode.Impulse);
        canShoot = false;
        nextFire = Time.time + fireRate;
    }    

    void LockOnTarget()
    {
        float distanceToTurret = Vector3.Distance(transform.position, target.transform.position);

        if (range > distanceToTurret)
        {
            targetLocked = false;
            Vector3 direction = target.transform.position - transform.position;
            lookAtUnit = Quaternion.LookRotation(direction);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, lookAtUnit, rotationSpeed * Time.deltaTime);
            if (transform.rotation == lookAtUnit)
            {
                targetLocked = true;
                canShoot = true;
            }

        }
    }
    
}
