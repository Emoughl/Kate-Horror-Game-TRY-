using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequences_01 : MonoBehaviour
{
    public GameObject PlayerScripts;
    public GameObject FadeScreenIn;
    public GameObject TextBox;
    void Start()
    {
        PlayerScripts.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScencePlayer());
    }

    IEnumerator ScencePlayer()
    {
        yield return new WaitForSeconds(1.5f);
        FadeScreenIn.SetActive(false);
        TextBox.GetComponent<Text>().text ="Tôi cần ra khỏi đây";
        yield return new WaitForSeconds(2f);
        TextBox.GetComponent<Text>().text ="";
        PlayerScripts.GetComponent<FirstPersonController>().enabled = true;
    }
}
