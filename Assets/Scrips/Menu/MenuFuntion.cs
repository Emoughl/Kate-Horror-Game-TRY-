using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFuntion : MonoBehaviour
{
    public GameObject Fadeout;
    public GameObject LoadingText;
    public AudioSource ButtonClick;


    public void NewGameButton()
    {
        StartCoroutine(NewGameStart());
    }

    IEnumerator NewGameStart()
    {
        ButtonClick.Play();
        Fadeout.SetActive(true);

        yield return new WaitForSeconds(3);
        LoadingText.SetActive(true);
        SceneManager.LoadScene(2);
    }
}
