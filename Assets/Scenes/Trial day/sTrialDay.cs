using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


[System.Serializable]
public class sTrialDay : MonoBehaviour
{
    [TextArea(3, 10)]
    public List<string> d1;

    [TextArea(3, 10)]
    public List<string> d2;

    [TextArea(3, 10)]
    public List<string> d3;

    [TextArea(3, 10)]
    public List<string> d4;

    [TextArea(3, 10)]
    public List<string> dw;


    [TextArea(3, 10)]
    public List<string> didyoumean;


    public List<Sprite> Faces;
    private float tsDetective;
    private float tsSteve;
    private float vpDetective;
    private float vpSteve;
    public Queue<string> auxQueue;
    public Animator aSteve;
    public Animator aDetective;
    public Animator transitionAnim;


    

    public GameObject goInput;
    public InputField inputf;
    //para la confirmacion
    private string accused;

    private int RandomNum;

    public string sceneName;


    // Use this for initialization
    void Start()
    {
        
        goInput.SetActive(false);
        tsDetective = 1f;
        vpDetective = 0.3f;
        RandomNum = Random.Range(1, 4);
        Debug.Log("random num: " + RandomNum);
        tsSteve = 0.5f;
        vpSteve = 0.6f;
        GetComponent<SceneDialogueManager>().ResetVars();

    }





    public void Dialogue1()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d1, tsSteve, vpSteve, Faces[0]);
    }
    public void Dialogue2()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d2, tsSteve, vpSteve, Faces[0]);
    }
    public void Dialogue3()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d3, tsSteve, vpSteve, Faces[0]);
    }
    public void Dialogue4()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d4, tsSteve, vpSteve, Faces[0]);
    }
    public void DialogueConfirm()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().next.SetActive(false);
        GetComponent<SceneDialogueManager>().StartDialogue(didyoumean, tsDetective, vpDetective, Faces[1]);
    }
    public void DialogueWrong()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().next.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(dw, tsDetective, vpDetective, Faces[1]);
        GetComponent<SceneDialogueManager>().CounterDialogues = 1;

    }


    public void SwapConfirm(string text)
    {
        didyoumean = new List<string>();
        auxQueue = new Queue<string>();
        string[] splitted = text.Split('\n');
        foreach (string sentence in splitted)
        {
            auxQueue.Enqueue(sentence);
        }
        didyoumean = auxQueue.ToList();
    }

    public void SwapWrong(string text)
    {
        dw = new List<string>();
        auxQueue = new Queue<string>();
        string[] splitted = text.Split('\n');
        foreach (string sentence in splitted)
        {
            auxQueue.Enqueue(sentence);
        }
        dw = auxQueue.ToList();
    }


    IEnumerator StartDialogueWithTimer(List<string> texts, float ts, float vp, Sprite spr, float time)
    {
        yield return new WaitForSeconds(time);
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(texts, ts, vp, spr);

    }
    IEnumerator ChangeSpriteWithTimer(Animator anim, string trigger, float time)
    {
        yield return new WaitForSeconds(time);
        anim.SetTrigger(trigger);

    }

    public void DialogueSorter()
    {
        Debug.Log(GetComponent<SceneDialogueManager>().CounterDialogues);
        switch (GetComponent<SceneDialogueManager>().CounterDialogues)
        {
            
            case 1:
                {
                    switch (RandomNum)
                    {
                        case 1:
                            {
                                Dialogue1();

                                break;
                            }

                        case 2:
                            {
                                Dialogue2();

                                break;
                            }
                        case 3:
                            {

                                Dialogue3();
                                break;
                            }
                        case 4:
                            {
                                Dialogue4();

                                break;
                            }


                    }
                    
                    break;
                }
            case 2:
                {
                    goInput.SetActive(true);
                    
                    break;
                }
            case 3:
                {
                   
                    break;
                }
            case 4:
                {

                   
                    break;
                }
            case 5:
                {
                    
                    break;
                }
            case 6:
                {
                    
                    break;
                }
            case 7:
                {
                    
                    break;
                }
            case 8:
                {
                   

                    break;
                }
            case 9:
                {
                    




                    break;
                }
            case 10:
                {
                    StartCoroutine(goArrestTimed(1f));





                    break;
                }



        }

    }












    //arranca lo del input

    void Awake()
    {
        inputf.onEndEdit.AddListener(AcceptStringInput); 
    }


    void AcceptStringInput(string userInput)
    {
        userInput = userInput.ToLower();
        Debug.Log(userInput);
        

        char[] delimiter = { ' ' };
        List<string> separatedInputWords = userInput.Split(delimiter).ToList();

        foreach (string word in separatedInputWords)
        {
            if (word=="luck" || word=="lucky" || word=="smoking" ||word=="smoker"|| word =="beanie") { accused = "Lucky"; };
            if (word=="tristan" || word=="glidewave" || word=="glideway" || word =="sad" || word=="engineer" || word=="trist" || word=="jumpsuit"|| word=="depressed") { accused = "Tristan Glidewave"; };
            if (word == "akyro" || word == "jin" || word == "akiro" || word == "samurai" || word == "japan") { accused = "Akyro Jin"; };
            if (word == "steve" || word == "cop" || word == "you") { accused = "Steve"; };
        }
        InputComplete();
        separatedInputWords.Clear();
        accused = null;
    }


    void InputComplete()
    {

        if (GetComponent<sActivePool>().CheckNPC(accused))
        {
            print(accused);
            SwapConfirm("So do you mean " + accused + "?");
            goInput.SetActive(false);
            DialogueConfirm();
            confirm();
            sceneName = "Arrest" + accused;
            Debug.Log(sceneName);
            
        }
        else if (accused == "Steve")
        {
            goInput.SetActive(false);
            SwapWrong("Oh no, Steve wouldn´t do that.");
            DialogueWrong();
        }
        else
        {
            goInput.SetActive(false);
            switch (Random.Range(0, 3))
            {
                case 0:
                    {
                        SwapWrong("I don't think Steve would know what that means.");
                        break;
                    }
                case 1:
                    {
                        SwapWrong("Please enter a name.");
                        break;
                    }
                case 2:
                    {

                        SwapWrong("There´s no one with that name.");
                        break;
                    }
                case 3:
                    {
                        SwapWrong("That's not a valid answer");
                        break;
                    }


            }
            
            DialogueWrong();
        }
        
        
    }

    void confirm()
    {
     //   GetComponent<SceneDialogueManager>().options[0].SetActive(true);
     //   GetComponent<SceneDialogueManager>().options[1].SetActive(true);

    }


    public void goback()
    {
      //  GetComponent<SceneDialogueManager>().options[0].SetActive(false);
     //   GetComponent<SceneDialogueManager>().options[1].SetActive(false);
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(false);
        GetComponent<SceneDialogueManager>().CounterDialogues = 2;
        DialogueSorter();

    }




















    // Update is called once per frame
    void Update()
    {
        if (GetComponent<SceneDialogueManager>().NextDialogue == true)
        {
            DialogueSorter();
            GetComponent<SceneDialogueManager>().NextDialogue = false;
        }
    }





    public void confirmArrest()
    {
        GetComponent<SceneDialogueManager>().sArrestName = sceneName;
        Debug.Log(GetComponent<SceneDialogueManager>().sArrestName);
        StartCoroutine(goArrestTimed(1));

    }


    IEnumerator goArrestTimed(float time)
    {
        yield return new WaitForSeconds(time);
        FindObjectOfType<Cutscenes>().StartLoadScene(GetComponent<SceneDialogueManager>().sArrestName);
    }
    IEnumerator fadeout(float time, float time2)
    {
        yield return new WaitForSeconds(time);
        transitionAnim.SetTrigger("fadeout");
        yield return new WaitForSeconds(time2);
        transitionAnim.SetTrigger("fadein");
    }


}
