using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammopickup : MonoBehaviour
{
    public GameObject AmoDisplay;
    public GameObject AmmoBox;

    private void OnTriggerEnter(Collider other)
    {
        AmmoBox.SetActive(false);
        AmoDisplay.SetActive(true);
        GrobalAmmo.AmmoCount += 10;
    }
}
