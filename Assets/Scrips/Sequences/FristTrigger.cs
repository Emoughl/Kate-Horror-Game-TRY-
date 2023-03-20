using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FristTrigger : MonoBehaviour
{
    public GameObject PlayerScripts;
    public GameObject TextBox;
    public GameObject GuiArrow;
    private void OnTriggerEnter(Collider other)
    {
         PlayerScripts.GetComponent<FirstPersonController>().enabled = false;
         StartCoroutine(ScencePlayer());
    }

    IEnumerator ScencePlayer()
    {
        TextBox.GetComponent<Text>().text="Nhìn vào mũi tên";
        yield return new WaitForSeconds(2f);
        TextBox.GetComponent<Text>().text="";
        PlayerScripts.GetComponent<FirstPersonController>().enabled = true;
        GuiArrow.SetActive(true);
    }
}
