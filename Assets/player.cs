using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public GameObject triggeringNPC;
    public GameObject triggeringDecoBox;
    public GameObject triggeringAudioBox;
    private bool triggering;
    private bool triggeringDeco;
    private bool triggeringAudio;
  //  public GameObject npcText;

    //first time enter bool




    private GameObject Receptor;
    private SpriteRenderer parentRenderer;


    private void Start()
    {
        parentRenderer = transform.GetComponent<SpriteRenderer>();
        FindObjectOfType<DialogueManager>().ResetVars();
    }

    void Update () {

        if (triggering)
        {

            
           
            
            if (Input.GetKeyDown(KeyCode.F) && FindObjectOfType<Movement>().talking == false)
            {
                //FindObjectOfType<DialogueManager>().DialogueBox.SetActive(true);
                
                //npcText.SetActive(false);

                if (triggeringNPC.tag == "NPC")
                {
                    FindObjectOfType<Movement>().talking = true;
                    triggeringNPC.GetComponent<sNPC>().chat();
                }
                
                
                if (triggeringNPC.name == "NPC")
                {
                    print("Hello table, you're looking good today");
                }
                if (triggeringNPC.name == "ExitBar")
                {
                    FindObjectOfType<GameMaster>().PassDay();
                }

            }
            ;
        }
        else
        {
            //npcText.SetActive(false);
            FindObjectOfType<DialogueManager>().ResetVars();


        }
        if (triggeringAudioBox)
        {
            if (triggeringAudioBox.name == "LBarConnect")
            {
                this.GetComponent<scrPlayerAudioManager>().leftconnect = true;
                this.GetComponent<scrPlayerAudioManager>().rightconnect = false;
                this.GetComponent<scrPlayerAudioManager>().leftoutside = false;
                this.GetComponent<scrPlayerAudioManager>().rightoutside = false;

            }
            else if (triggeringAudioBox.name == "LBarOutside")
            {

                this.GetComponent<scrPlayerAudioManager>().leftconnect = false;
                this.GetComponent<scrPlayerAudioManager>().rightconnect = false;
                this.GetComponent<scrPlayerAudioManager>().leftoutside = true;
                this.GetComponent<scrPlayerAudioManager>().rightoutside = false;
            }
            else if (triggeringAudioBox.name == "RBarConnect")
            {

                this.GetComponent<scrPlayerAudioManager>().leftconnect = false;
                this.GetComponent<scrPlayerAudioManager>().rightconnect = true;
                this.GetComponent<scrPlayerAudioManager>().leftoutside = false;
                this.GetComponent<scrPlayerAudioManager>().rightoutside = false;
            }
            else if (triggeringAudioBox.name == "RBarOutside")
            {

                this.GetComponent<scrPlayerAudioManager>().leftconnect = false;
                this.GetComponent<scrPlayerAudioManager>().rightconnect = false;
                this.GetComponent<scrPlayerAudioManager>().leftoutside = false;
                this.GetComponent<scrPlayerAudioManager>().rightoutside = true;
            }
            else if (triggeringAudioBox.name == "BarInner")
            {

                this.GetComponent<scrPlayerAudioManager>().leftconnect = false;
                this.GetComponent<scrPlayerAudioManager>().rightconnect = false;
                this.GetComponent<scrPlayerAudioManager>().leftoutside = false;
                this.GetComponent<scrPlayerAudioManager>().rightoutside = false;
            }
        }
        if (triggeringDeco)
        {
            if (triggeringDecoBox.name == "Wall")
            {
                Color tmp = triggeringDecoBox.GetComponent<SpriteRenderer>().color;
                tmp.a = 0.5f;
                triggeringDecoBox.GetComponent<SpriteRenderer>().color = tmp;

            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "BarAudio")
        {

            triggeringAudio = true;
            triggeringAudioBox = collision.gameObject;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "NPC")
        {
            
                triggering = true;
                triggeringNPC = other.gameObject;


        }
        if (other.gameObject.tag == "Door")
        {

            triggering = true;
            triggeringNPC = other.gameObject;
        }
        if (other.gameObject.tag == "Foreground")
        {

            triggeringDeco = true;
            triggeringDecoBox = other.gameObject;


        }
        if (other.gameObject.tag == "BarAudio")
        {

            triggeringAudio = true;
            triggeringAudioBox = other.gameObject;
        }

    }


    private void OnTriggerExit2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "NPC")
        {
            
                triggering = false;
                triggeringNPC = null;

        }
        if (other.gameObject.tag == "BarAudio")
        {
            

            triggeringAudio = false;

        }
        if (other.gameObject.tag == "Door")
        {

            triggering = false;
            triggeringNPC = other.gameObject;
        }
        if (other.gameObject.tag == "Foreground")
        {

            triggeringDeco = false;
            Color tmp = triggeringDecoBox.GetComponent<SpriteRenderer>().color;
            tmp.a = 1f;
            triggeringDecoBox.GetComponent<SpriteRenderer>().color = tmp;
            triggeringDecoBox = other.gameObject;
            
        }

    }
}
