using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeScripot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(90, 0, 0);
        transform.position += (Vector3.down * 1.5f) + (Vector3.left *1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
