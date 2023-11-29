using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneDialogueManager : MonoBehaviour {

    public Text dialogueText;
    private Queue<string> sentences;
    public AudioSource keysound;
    public List<AudioClip> keysounds;
    public AudioSource ring;
    public float Talkspeed = 1;
    public AudioSource voice;
    public GameObject NPCFace;

    public List<Sprite> Faces;

    public GameObject next;
    public GameObject optionManager;
    public int FaceID;
    public bool faceChange = false;
    public bool aux;
    public bool endScene;
    public string sArrestName;
    public bool choosing;

    public scr_phone Phone;



    public Animator fade;
    public GameObject gofade;

    public int CounterDialogues;

    public GameObject DialogueBox;

    public int convonumber;
    public bool NextDialogue;





    public void ResetVars()
    {

        next.SetActive(false);
        optionManager.SetActive(false);
        DialogueBox.SetActive(false);

        NPCFace.SetActive(false);

    }

    // Use this for initialization
    void Start()
    {   
        sentences = new Queue<string>();
        Phone.SetCall(convonumber);
    }


    public void NextConvo()
    {
        convonumber++;
        StartCoroutine(FadeInOut());

    }

    IEnumerator FadeInOut()
    {
        
        FadeOut();
        yield return new WaitForSecondsRealtime(2f);

        fade.SetTrigger("fadein");
        ring.Play();
        yield return new WaitForSecondsRealtime(2f);
        gofade.SetActive(false);
        Phone.SetCall(convonumber);
    }


    private void FadeOut()
    {
        gofade.SetActive(true);
        fade.SetTrigger("fadeout");
    }

    public void SwapFace(Sprite spr)
    {

        NPCFace.GetComponent<SpriteRenderer>().sprite =spr;
    }
    public void StartDialogue(List<string> texts, float ts, float vp, Sprite spr)
    {
        AssignTalkVars(ts, vp);
        //dialogue starts
        NPCFace.SetActive(true);
        SwapFace(spr);
        sentences.Clear();
        DialogueBox.SetActive(true);
        foreach (string sentence in texts)
        {
            sentences.Enqueue(sentence);
        }
        next.SetActive(false);
        DisplayNextSentence();
    }
    public void AssignTalkVars(float ts, float vp)
    {
        Talkspeed = ts;
        voice.pitch = vp;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Talkspeed = 0;
        }

        if (faceChange)
        {
            SwapFace(Faces[FaceID]);
            faceChange = false;
        }
	}

    public void DisplayNextSentence()
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


        string sentence = sentences.Dequeue();


        StopAllCoroutines();
        Debug.Log(sentence);
        StartCoroutine(TypeSentence(sentence));


    }

    public void RespriteInTextMM(int num)
    {
        faceChange = true;
        FaceID = num;

    }
    //option change name middleman
    public void ChangeOptionMM(string atext, string btext)
    {
        optionManager.GetComponent<scr_optman>().ChangeName(atext, btext);

    }

    IEnumerator TypeSentence(string sentence)
    {
        next.SetActive(false);
        dialogueText.text = "";
        
        foreach (char letter in sentence.ToCharArray())
        {
            float auxf = voice.pitch;
            if (letter == '+') { Choose(); }
            else if (letter == '_') { next.SetActive(true); }
            else if (letter == '¡') { aux = true; }
            else if (aux)
            {
                if (letter == '0') { RespriteInTextMM(0); }
                if (letter == '1') { RespriteInTextMM(1); }
                if (letter == '2') { RespriteInTextMM(2); }
                if (letter == '3') { RespriteInTextMM(3); }
                if (letter == '4') { RespriteInTextMM(4); }
                if (letter == '5') { RespriteInTextMM(5); }
                if (letter == '6') { RespriteInTextMM(6); }
                if (letter == '7') { RespriteInTextMM(7); }
                if (letter == '8') { RespriteInTextMM(8); }
                if (letter == '9') { RespriteInTextMM(9); }
                if (letter == 's') { yield return new WaitForSecondsRealtime(Talkspeed * 0.1F + 0.2F); }
                if (letter == 'd') { yield return new WaitForSecondsRealtime(Talkspeed * 0.1F + 0.5F); }
                aux = false;
            }
            else
            {
                
                
                
                dialogueText.text += letter;

                if (letter == ',') { yield return new WaitForSecondsRealtime(Talkspeed * 0.1F + 0.2F); }

                if (!keysound.isPlaying)
                {
                    keysound.clip = keysounds[Random.Range(0, keysounds.Count - 1)];
                    keysound.Play();
                }
                voice.pitch = voice.pitch + Random.Range(-0.10f, 0.10f);

                if (!voice.isPlaying)
                { voice.Play(); }
                
                
                yield return new WaitForSecondsRealtime(Talkspeed * 0.1F);
                
            }
            voice.pitch = auxf;
        }
        if (choosing)
        { choosing = false; }
        else
        { next.SetActive(true); }
        
    }
    public void Choose()
    {
        optionManager.SetActive(true);

        
        choosing = true;
        


    }

    public void EndDialogue()
    {
        DialogueBox.SetActive(false);
        ResetVars();
        StopAllCoroutines();
        NextDialogue = true;
        CounterDialogues++;

    }

    public void LastDialogue()
    {
        //next.SetActive(false);
    }


    

}
