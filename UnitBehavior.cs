using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class UnitBehavior : MonoBehaviour
{
    Transform target;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
        if (GameObject.FindGameObjectWithTag("Turret") != null)
        {
            target = GameObject.FindGameObjectWithTag("Turret").transform;
        }
                
    }

    // Update is called once per frame
    void Update()
    {    
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        
    }
}
