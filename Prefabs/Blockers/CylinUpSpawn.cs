using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinUpSpawn : MonoBehaviour
{
    void Start()
    {
        transform.position = transform.position + Vector3.up * 4;
    }
}
