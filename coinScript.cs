using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour
{
    public AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = transform.position + Vector3.up * 4;

        audioData = GetComponent<AudioSource>();

    }

 

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(3, 3, 3);
    }
}
