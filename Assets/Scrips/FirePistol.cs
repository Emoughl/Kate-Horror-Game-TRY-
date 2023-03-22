using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
  public GameObject TheGun;
  public GameObject BulletFlash;
  public AudioSource GunFire;
  public bool isFiring = false;
  public float targetDistance;
  public int damageAmount = 5;


  void Update()
  {
    if(Input.GetButtonDown("Fire1") && GrobalAmmo.AmmoCount>=1 )
    {
        if(isFiring = true)
        {
          GrobalAmmo.AmmoCount -=1;
        StartCoroutine(firePistol());
        }
    }
  }

  IEnumerator firePistol()
  {
    RaycastHit hit;
    isFiring = true;
    if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit))
    {
      targetDistance = hit.distance;
      hit.transform.SendMessage("DamageZombie", damageAmount , SendMessageOptions.DontRequireReceiver);
    }
    TheGun.GetComponent<Animation>().Play("PistolShot");
    BulletFlash.SetActive(true);
    BulletFlash.GetComponent<Animation>().Play("Shot");
    GunFire.Play();
     yield return new WaitForSeconds(0.5f);
      isFiring = false;
  }
}
