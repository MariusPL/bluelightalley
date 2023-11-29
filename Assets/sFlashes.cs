using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class sFlashes: MonoBehaviour
{
    public Animator Anim;
    public GameObject fade;



    private void Start()
    {
        fade.SetActive(false);
    }

    public void Decieve()
    {
        StartCoroutine(DPanel());

    }
    public void Truth()
    {
        StartCoroutine(TPanel());

    }
    public void Flirt()
    {
        StartCoroutine(FPanel());

    }
    public void Intimidate()
    {
        StartCoroutine(IPanel());
        
    }

    IEnumerator DPanel()
    {
        fade.SetActive(true);
        Anim.SetTrigger("d");
        yield return new WaitForSeconds(0.15f);
        fade.SetActive(false);
    }
    IEnumerator TPanel()
    {
        fade.SetActive(true);
        Anim.SetTrigger("t");
        yield return new WaitForSeconds(0.15f);
        fade.SetActive(false);
    }
    IEnumerator FPanel()
    {
        fade.SetActive(true);
        Anim.SetTrigger("f");
        yield return new WaitForSeconds(0.15f);
        fade.SetActive(false);
    }
    IEnumerator IPanel()
    {
        fade.SetActive(true);
        Anim.SetTrigger("i");
        yield return new WaitForSeconds(0.15f);
        fade.SetActive(false);
    }




}
