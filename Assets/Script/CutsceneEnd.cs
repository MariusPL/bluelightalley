using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CutsceneEnd : MonoBehaviour {
    public Animator transitionAnim;
    // Use this for initialization
    void Start () {



        
	}




    IEnumerator JumptoScene()
    {
        transitionAnim.SetTrigger("fadeout");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Day1");
    }

    // Update is called once per frame
    void Update () {

        if (FindObjectOfType<SceneDialogueManager>().endScene)
        {
            Debug.Log("endscene");
            StartCoroutine(JumptoScene());
        }
        


    }
}
