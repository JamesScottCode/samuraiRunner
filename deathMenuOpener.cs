using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathMenuOpener : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void ToggleDeathScreen()
    {
        gameObject.SetActive(true);
    }
}
