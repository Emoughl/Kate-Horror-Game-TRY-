using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnimation : MonoBehaviour
{
    public int LightMode;//cong tac
    public GameObject FlameLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Update is called once per frame
    void Update()
    {
        if(LightMode == 0)
        {
            StartCoroutine(AnimateLight());
        }
        
    }
    IEnumerator AnimateLight()
    {
        LightMode = Random.Range(1,4);
        if (LightMode == 1)
        {
            FlameLight.GetComponent<Animation>().Play("TorchLight01");
        }
         if (LightMode == 2)
        {
            FlameLight.GetComponent<Animation>().Play("TorchLight02");
        }
         if (LightMode == 3)
        {
            FlameLight.GetComponent<Animation>().Play("TorchLight03");
        }
        yield return new WaitForSeconds(0.99f);
        LightMode = 0;
    }
 }

