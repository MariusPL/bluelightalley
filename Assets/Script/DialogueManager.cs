using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public Text dialogueText;
    public Text option1;
    public Text option2;

    public List<Sprite> Brains;
    public GameObject lBrain;
    public GameObject rBrain;
    private Queue<string> sentences;

    public Dialogue dialogue;
    private bool aux;

    public AudioSource keysound;
    public float Talkspeed = 1;
    public AudioSource voice;

    public GameObject decieve;
    public GameObject truth;
    public GameObject flirt;
    public GameObject intimidate;
    public GameObject next;
    public GameObject ok;
    public GameObject focus;
    public GameObject Yes;
    public GameObject No;
    public GameObject NPCFace;

    public GameObject DialogueBox;

    public GameObject oPlayer;
    public Sprite SNPCFace;


    public bool LastD;




    // Use this for initialization
    void Start() {
        sentences = new Queue<string>();
        SNPCFace = NPCFace.GetComponent<Image>().sprite;
    }



    public void ResetVars()
    {

        next.SetActive(true);
        decieve.SetActive(false);
        truth.SetActive(false);
        flirt.SetActive(false);
        intimidate.SetActive(false);
        DialogueBox.SetActive(false);
        ok.SetActive(false);
        focus.SetActive(false);
        Yes.SetActive(false);
        No.SetActive(false);
        NPCFace.SetActive(false);

        FindObjectOfType<Movement>().talking = false;
    }
    public void StartDialogue (List<string> texts)
    {
        AssignTalkVars();
        //dialogue starts
        NPCFace.SetActive(true);
        oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().RespriteMM();
        sentences.Clear();
        DialogueBox.SetActive(true);
        ok.SetActive(true);
        focus.SetActive(true);


        foreach (string sentence in texts)
        {
            sentences.Enqueue(sentence);
        }

        if (sentences.Count > 0) { next.SetActive(true); }

        
        DisplayNextSentence();
        


    }


    public void DisplayNextSentence ()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();

            return;

        }
        else if (sentences.Count == 1)
        {
            LastDialogue();
        }
        oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().RespriteMM();


        string sentence = sentences.Dequeue();


        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));


    }


    public void Decieve()
    {
        oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().DDecieve();
        

    }

    public void Truth()
    {

        oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().DTruth();
        
    }

    public void Flirt()
    {

        oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().DFlirt();
        
    }

    public void Intimidate()
    {

        oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().DIntimidate();
        
    }
    public void Yay()
    {

        oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().DY();

    }
    public void Nay()
    {

        oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().DN();

    }



    public void AssignTalkVars()
    {
        Talkspeed= oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().sNPCTalkspeed;
        voice.pitch = oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().sNPCPitch;
    }




    //typing effect
    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        
        foreach (char letter in sentence.ToCharArray())
        {
            float auxf = voice.pitch;
            if (letter == '+') { Choose(); }
            else if (letter == 'ç') { Choose1(); }
            else if (letter == '¡') { aux = true; }
            else if (aux)
            {
                if (letter == '0') { oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().RespriteInTextMM(0); }
                if (letter == '1') { oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().RespriteInTextMM(1); }
                if (letter == '2') { oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().RespriteInTextMM(2); }
                if (letter == '3') { oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().RespriteInTextMM(3); }
                if (letter == '4') { oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().RespriteInTextMM(4); }
                if (letter == '5') { oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().RespriteInTextMM(5); }
                if (letter == '6') { oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().RespriteInTextMM(6); }
                if (letter == '7') { oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().RespriteInTextMM(7); }
                if (letter == '8') { oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().RespriteInTextMM(8); }
                if (letter == '9') { oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().RespriteInTextMM(9); }
                aux = false;
            }
            else {
                keysound.Play();

                
                voice.pitch = voice.pitch + Random.Range(-0.050f, 0.050f);
                
                

                dialogueText.text += letter;
                
                if (letter == ',') { yield return new WaitForSecondsRealtime(Talkspeed * 0.1F + 0.2F); }
                else if (letter == '.' || letter == '?' || letter == '!') { yield return new WaitForSecondsRealtime(Talkspeed * 0.1F + 0.5F); }

                else { voice.Play(); yield return new WaitForSecondsRealtime(Talkspeed * 0.1F); }
            }
            voice.pitch = auxf;
        }
        

    }



    public void EndDialogue()
    {
        //dialogue ends xd
        DialogueBox.SetActive(false);
        ResetVars();
        StopAllCoroutines();
    }

    public void LastDialogue()
    {
        oPlayer.GetComponent<player>().triggeringNPC.GetComponent<sNPC>().DChoice();

        next.SetActive(false);

    }

    public void Choose()
    {

        Yes.SetActive(true);
        No.SetActive(true);

    }
    public void Choose1()
    {

        Yes.SetActive(true);

    }

    //WHEN DISABLED



    // Update is called once per frame

}
