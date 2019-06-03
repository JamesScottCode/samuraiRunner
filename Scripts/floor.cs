using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{

    public GameObject toSpawn;
   
 
    //public Vector3 spawnValues = (0.0f, -3.5f, 40.0f);


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(toSpawn, transform.position, transform.rotation);

        print("Spawned");

    }

    // Update is called once per frame
    void Update()
    {
     
        {
           // Destroy(gameObject, 3);
        }
       
    }


    



}
