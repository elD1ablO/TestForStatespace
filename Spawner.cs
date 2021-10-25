using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject unit;
    //Vector3 spawnPosition;
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 9.5f));

                          //ray.GetPoint(9.4f)
            Instantiate(unit, spawnPosition, Quaternion.identity);                
        }
    }
}
