using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class sNPC : MonoBehaviour {
    public Dialogue dialogue;
    public bool disabled = false;

    public GameObject GM;

    public bool ded, trd, fld, ind, yd, nd;
    public bool frs;//first resprite
    public float sNPCTalkspeed;
    public float sNPCPitch;
    private Queue<string> auxQueue;
    public bool daychanged;
    private bool lasttalk;
    public AudioSource themeSong;


    
    public bool FaceChangeInText;
    public int FaceChangeInTextID;




    private int innerdaycount;

    public void RespriteMM()//Resprite Middleman
    {
        frs = true;

    }
    public void RespriteInTextMM(int num)//Resprite Middleman
    {
        FaceChangeInText = true;
        FaceChangeInTextID = num;

    }





    public void chat()
    {
        if (themeSong)
        { themeSong.Play(); }
        
        if ((ded || trd) && (fld || ind))
        { FindObjectOfType<DialogueManager>().StartDialogue(dialogue.disabledText);
          //  lasttalk = true;
        }
     //   else if ((ded || trd) && (fld || ind) && lasttalk)
     //   {
    //        ;
     //   }
        else
        { FindObjectOfType<DialogueManager>().StartDialogue(dialogue.s1);
           // lasttalk = false;
        }

        if (ded) { FindObjectOfType<DialogueManager>().lBrain.GetComponent<Image>().sprite = FindObjectOfType<DialogueManager>().Brains[0]; }
        else if (trd) { FindObjectOfType<DialogueManager>().lBrain.GetComponent<Image>().sprite = FindObjectOfType<DialogueManager>().Brains[1]; }
        if (fld) { FindObjectOfType<DialogueManager>().rBrain.GetComponent<Image>().sprite = FindObjectOfType<DialogueManager>().Brains[2]; }
        else if (ind) { FindObjectOfType<DialogueManager>().rBrain.GetComponent<Image>().sprite = FindObjectOfType<DialogueManager>().Brains[3]; }
       

        
        if (!ded && !trd) { FindObjectOfType<DialogueManager>().lBrain.GetComponent<Image>().sprite = FindObjectOfType<DialogueManager>().Brains[4]; }
        if (!fld && !ind) { FindObjectOfType<DialogueManager>().rBrain.GetComponent<Image>().sprite = FindObjectOfType<DialogueManager>().Brains[5]; }
    }



    //para las opciones caritas
    public void SwapOp(string text, string text2)
    {

        FindObjectOfType<DialogueManager>().option1.text = text;
        FindObjectOfType<DialogueManager>().option2.text = text2;

    }



    public void DDecieve()
    {

        FindObjectOfType<DialogueManager>().StartDialogue(dialogue.d1);
        FindObjectOfType<DialogueManager>().decieve.SetActive(false);
        FindObjectOfType<DialogueManager>().truth.SetActive(false);
        FindObjectOfType<DialogueManager>().Yes.SetActive(false);
        FindObjectOfType<DialogueManager>().No.SetActive(false);
        this.ded = true;
        FindObjectOfType<DialogueManager>().lBrain.GetComponent<Image>().sprite = FindObjectOfType<DialogueManager>().Brains[0];


    }

    public void DTruth()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue.t1);
        FindObjectOfType<DialogueManager>().decieve.SetActive(false);
        FindObjectOfType<DialogueManager>().truth.SetActive(false);
        FindObjectOfType<DialogueManager>().Yes.SetActive(false);
        FindObjectOfType<DialogueManager>().No.SetActive(false);
        this.trd = true;
        FindObjectOfType<DialogueManager>().lBrain.GetComponent<Image>().sprite = FindObjectOfType<DialogueManager>().Brains[1];

    }

    public void DFlirt()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue.f1);
        FindObjectOfType<DialogueManager>().flirt.SetActive(false);
        FindObjectOfType<DialogueManager>().intimidate.SetActive(false);
        FindObjectOfType<DialogueManager>().Yes.SetActive(false);
        FindObjectOfType<DialogueManager>().No.SetActive(false);
        this.fld = true;
        FindObjectOfType<DialogueManager>().rBrain.GetComponent<Image>().sprite = FindObjectOfType<DialogueManager>().Brains[2];

    }

    public void DIntimidate()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue.i1);
        FindObjectOfType<DialogueManager>().flirt.SetActive(false);
        FindObjectOfType<DialogueManager>().intimidate.SetActive(false);
        FindObjectOfType<DialogueManager>().Yes.SetActive(false);
        FindObjectOfType<DialogueManager>().No.SetActive(false);
        this.ind = true;
        FindObjectOfType<DialogueManager>().rBrain.GetComponent<Image>().sprite = FindObjectOfType<DialogueManager>().Brains[3];
    }

    public void DY()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue.yes);
        FindObjectOfType<DialogueManager>().Yes.SetActive(false);
        FindObjectOfType<DialogueManager>().No.SetActive(false);
        this.yd = true;
    }
    public void DN()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue.no);
        FindObjectOfType<DialogueManager>().Yes.SetActive(false);
        FindObjectOfType<DialogueManager>().No.SetActive(false);
        this.nd = true;
    }

    public void DDisabled()
    {

        FindObjectOfType<DialogueManager>().StartDialogue(dialogue.t1);


    }



    public void DChoice()
    {
        if (ded != true && trd != true)
        {
            FindObjectOfType<DialogueManager>().decieve.SetActive(true);
            FindObjectOfType<DialogueManager>().truth.SetActive(true);
        }
        if (fld != true && ind != true)
        {
            FindObjectOfType<DialogueManager>().flirt.SetActive(true);
            FindObjectOfType<DialogueManager>().intimidate.SetActive(true);
        }



    }


    void Start () {
        innerdaycount = 0;
    }
	
	// Update is called once per frame
	void Update () {
        
        DayChange();



    }

    public void ResetsNPCVars()
    {

            FindObjectOfType<DialogueManager>().lBrain.GetComponent<Image>().sprite = FindObjectOfType<DialogueManager>().Brains[4];

            FindObjectOfType<DialogueManager>().rBrain.GetComponent<Image>().sprite = FindObjectOfType<DialogueManager>().Brains[5];

    disabled = false;
    ded=false;
    trd=false;
    fld=false;
    ind=false;
    }

    public void DayChange()
    {
        if (innerdaycount != GameMaster.daycount)
        {
            ResetsNPCVars();
            innerdaycount= GameMaster.daycount;
            daychanged = true;
            Debug.Log(innerdaycount);
            
        }

    }



    public void Offday()
    {
        this.gameObject.SetActive(false);
    }

    public void Onday()
    {
        this.gameObject.SetActive(true);
    }

    public void SwapS(string text)
    {
        dialogue.s1 = new List<string>();
        auxQueue = new Queue<string>();
        string[] splitted = text.Split('\n');
        foreach (string sentence in splitted)
        {
            auxQueue.Enqueue(sentence);
        }
        dialogue.s1 = auxQueue.ToList();
    }

    public void SwapD(string text)
    {
        dialogue.d1 = new List<string>();
        auxQueue = new Queue<string>();
        string[] splitted = text.Split('\n');
        foreach (string sentence in splitted)
        {
            auxQueue.Enqueue(sentence);
        }
        dialogue.d1 = auxQueue.ToList();
    }
    public void SwapT(string text)
    {
        dialogue.t1 = new List<string>();
        auxQueue = new Queue<string>();
        string[] splitted = text.Split('\n');
        foreach (string sentence in splitted)
        {
            auxQueue.Enqueue(sentence);
        }
        dialogue.t1 = auxQueue.ToList();
    }
    public void SwapF(string text)
    {
        dialogue.f1 = new List<string>();
        auxQueue = new Queue<string>();
        string[] splitted = text.Split('\n');
        foreach (string sentence in splitted)
        {
            auxQueue.Enqueue(sentence);
        }
        dialogue.f1 = auxQueue.ToList();
    }
    public void SwapI(string text)
    {
        dialogue.i1 = new List<string>();
        auxQueue = new Queue<string>();
        string[] splitted = text.Split('\n');
        foreach (string sentence in splitted)
        {
            auxQueue.Enqueue(sentence);
        }
        dialogue.i1 = auxQueue.ToList();
    }
    public void SwapYes(string text)
    {
        dialogue.yes = new List<string>();
        auxQueue = new Queue<string>();
        string[] splitted = text.Split('\n');
        foreach (string sentence in splitted)
        {
            auxQueue.Enqueue(sentence);
        }
        dialogue.yes = auxQueue.ToList();
    }
    public void SwapNo(string text)
    {
        dialogue.no = new List<string>();
        auxQueue = new Queue<string>();
        string[] splitted = text.Split('\n');
        foreach (string sentence in splitted)
        {
            auxQueue.Enqueue(sentence);
        }
        dialogue.no = auxQueue.ToList();
    }
    public void SwapDisabled(string text)
    {
        dialogue.disabledText = new List<string>();
        auxQueue = new Queue<string>();
        string[] splitted = text.Split('\n');
        foreach (string sentence in splitted)
        {
            auxQueue.Enqueue(sentence);
        }
        dialogue.disabledText = auxQueue.ToList();
    }





}
