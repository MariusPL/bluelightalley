using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


[System.Serializable]
public class sArrestLucky : MonoBehaviour
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
    public List<string> d5;

    [TextArea(3, 10)]
    public List<string> d6;

    [TextArea(3, 10)]
    public List<string> d7;






    [TextArea(3, 10)]
    public List<string> dcase;
    private bool vocase;
    public List<Sprite> Faces;
    private float tsLucky;
    private float vpLucky;
    public Queue<string> auxQueue;
    public Animator aLucky;
    public Animator aDetective;
    public Animator transitionAnim;


    //animators, ts es text speed o talk speed y vp es voice pitch.







    // Use this for initialization
    void Start()
    {
        tsLucky = 0.34f;
        vpLucky = 2f;

        GetComponent<SceneDialogueManager>().ResetVars();

    }




    //aveces hay que swapear distintos dialogos dependiendo de la confianza que ya haya
    public void SwapD4(string text)
    {
        d4 = new List<string>();
        auxQueue = new Queue<string>();
        string[] splitted = text.Split('\n');
        foreach (string sentence in splitted)
        {
            auxQueue.Enqueue(sentence);
        }
        d4 = auxQueue.ToList();
    }
    public void SwapD2(string text)
    {
        d2 = new List<string>();
        auxQueue = new Queue<string>();
        string[] splitted = text.Split('\n');
        foreach (string sentence in splitted)
        {
            auxQueue.Enqueue(sentence);
        }
        d2 = auxQueue.ToList();
    }
    public void SwapD1(string text)
    {
        d1 = new List<string>();
        auxQueue = new Queue<string>();
        string[] splitted = text.Split('\n');
        foreach (string sentence in splitted)
        {
            auxQueue.Enqueue(sentence);
        }
        d1 = auxQueue.ToList();
    }

    public void Dialogue1()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d1, tsLucky, vpLucky, Faces[0]);

    }
    


    public void DialogueSorter()
    {
        Debug.Log(GetComponent<SceneDialogueManager>().CounterDialogues);
        switch (GetComponent<SceneDialogueManager>().CounterDialogues)
        {
            case 1:
                {
                    if (sLucky.nickname)
                    {
                        
                        SwapD1("¡2Heyy Weird hat,\nHow did you find me? This is my secret spot, and I'm sure I never told you about here...\nOr did I?\nNo I did not, I'm pretty sure, you were stalking me right? Well, anyways, why are you here?+");
                    }
                    else if (sLucky.betrayed)
                    {
                        SwapD1("¡0Oh, ¡6it's you...\nWhat are you doing here?+");

                    }
                    

                    Dialogue1();
                    break;
                }
            case 2:
                {

                    
                    break;
                }
            case 3:
                {
                    
                    break;
                }
            case 4:
                {
                    //por ej aca te dice si sabe tu nombre lo sabe
                    if (sLucky.luckyaware)
                    {
                        SwapD4("Oh, it's the detective.");
                    }
                    else if (sLucky.nickname)
                    {
                        SwapD4("Oh DW, you're here.");
                    }
                    
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
                    //aca cambia los dialogos dependiendo de las opciones



                    break;
                }
            case 9:
                {





                    break;
                }
            case 10:
                {






                    break;
                }



        }

    }



    //O es opcion, aca estan las dif variables de cada opcion xD



    // esto solamente son funciones cte


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
    // Update is called once per frame
    void Update()
    {
        if (GetComponent<SceneDialogueManager>().NextDialogue == true)
        {
            DialogueSorter();
            GetComponent<SceneDialogueManager>().NextDialogue = false;
        }
        if (GetComponent<SceneDialogueManager>().faceChange)
        {
            GetComponent<SceneDialogueManager>().faceChange = false;
            GetComponent<SceneDialogueManager>().SwapFace(Faces[GetComponent<SceneDialogueManager>().FaceID]);

        }
        
    }


    IEnumerator endscenetimed(float time)
    {
        yield return new WaitForSeconds(time);
        GetComponent<SceneDialogueManager>().endScene = true;
    }
    IEnumerator fadeout(float time, float time2)
    {
        yield return new WaitForSeconds(time);
        transitionAnim.SetTrigger("fadeout");
        yield return new WaitForSeconds(time2);
        transitionAnim.SetTrigger("fadein");
    }


}
