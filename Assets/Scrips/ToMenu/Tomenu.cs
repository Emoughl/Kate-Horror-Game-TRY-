using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tomenu : MonoBehaviour
{
   void Start()
   {
    StartCoroutine(TakeToMenu());
   }
   IEnumerator TakeToMenu()
   {
    yield return new WaitForSeconds(4f);
    SceneManager.LoadScene(1);

   }
}
