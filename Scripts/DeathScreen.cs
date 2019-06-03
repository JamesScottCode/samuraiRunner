using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreen : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
    }

    void ShowDeathScreen()
    {
        gameObject.SetActive(true);
    }
}
