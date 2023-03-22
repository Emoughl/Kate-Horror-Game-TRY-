using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAttack : MonoBehaviour
{
 [SerializeField] GameObject zombie;
 [SerializeField] AudioSource zombieSound;

 private void OnTriggerEnter(Collider other )
 {
    GetComponent<BoxCollider>().enabled = false;
    zombieSound.Play();
    zombie.SetActive(true);
    zombie.GetComponent<Animation>().Play("Z_Run_InPlace");
 }
}
