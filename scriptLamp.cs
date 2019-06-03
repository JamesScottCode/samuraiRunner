using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class scriptLamp : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        

        transform.position = transform.position + Vector3.up * 2.4f;
        transform.Rotate(90, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
