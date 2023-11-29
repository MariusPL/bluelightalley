using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_next : MonoBehaviour
{
    public scr_phone Phone;
    public scr_notebook Note;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Phone.phoneout || Note.noteshowing)
        { }
        else
        {
            
            if (Input.GetKeyDown(KeyCode.Z))
            {
                FindObjectOfType<SceneDialogueManager>().DisplayNextSentence();


            }
        }

    }
    public void PressNext()
    {
        if (Note.p_selectingwords)
        { }
        else
        {

           
                FindObjectOfType<SceneDialogueManager>().DisplayNextSentence();



        }

    }
}
    