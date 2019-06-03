using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = transform.position + Vector3.up * 1.2f;
    }
}
