using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrobalAmmo : MonoBehaviour
{
    public static int AmmoCount;
    public GameObject AmoDisplay;
    public int InternalAmmo;


    void Update()
    {
        InternalAmmo = AmmoCount;
        AmoDisplay.GetComponent<Text>().text = "" + InternalAmmo;
    }
}
