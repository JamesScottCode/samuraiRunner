using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorSpawner : MonoBehaviour
{
    public GameObject tiledFloor;
    private Vector3 startPos;
    private Vector3 spawnPos;
    private int floorLength = 20;
    public GameObject startFloor;

    // Start is called before the first frame update
    void Start()
    {
        startPos = startFloor.transform.position;
        spawnPos = startFloor.transform.position + Vector3.forward * floorLength;
        Instantiate(tiledFloor, spawnPos, transform.rotation);
    }
}
