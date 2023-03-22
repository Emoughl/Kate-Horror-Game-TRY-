using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeaths : MonoBehaviour
{
   public int ZombieHelth = 25;
   public GameObject zombie;

   public void DamageZombie(int damage)
   {
    ZombieHelth -= damage;
   }

    void Update()
    {
        if(ZombieHelth <= 0)
        {
            zombie.GetComponent<Animation>().Stop("Z_Run_InPlace");
            zombie.GetComponent<Animation>().Play("Z_FallingBack");

            StartCoroutine(HideTime());
        }   
    }
    IEnumerator HideTime()
    {
        yield return new WaitForSeconds(2f);
        zombie.SetActive(false);
    }
}
