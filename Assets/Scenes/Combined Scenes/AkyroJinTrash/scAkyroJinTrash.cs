using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


[System.Serializable]
public class scAkyroJinTrash : MonoBehaviour
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
    public List<string> d8;
    private bool vosilent;
    [TextArea(3, 10)]
    public List<string> d9;
    [TextArea(3, 10)]
    public List<string> d10;
    [TextArea(3, 10)]
    public List<string> d11;

    [TextArea(3, 10)]
    public List<string> d12;

    [TextArea(3, 10)]
    public List<string> d13;

    [TextArea(3, 10)]
    public List<string> dbf3;


    [TextArea(3, 10)]
    public List<string> dcase;

    public List<Sprite> Faces;
    private float tsAkyro;
    private float tsTrash;
    private float vpAkyro;
    private float vpTrash;
    public Queue<string> auxQueue;
    public Animator aAkyro;
    public Animator aTrash;
    public Animator aDetective;
    public Animator transitionAnim;


    //animators, ts es text speed o talk speed y vp es voice pitch.







    // Use this for initialization
    void Start()
    {
        tsAkyro = 0.6f;
        vpAkyro = 0.78f;

        tsTrash = 0.5f;
        vpTrash = 0.45f;

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

    public void Dialogue1()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d1, tsTrash, vpTrash, Faces[0]);

    }
    public void Dialogue2()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d2, tsAkyro, vpAkyro, Faces[1]);

    }
    public void Dialogue3()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d3, tsTrash, vpTrash, Faces[0]);

    }
    public void Dialogue4()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d4, tsAkyro, vpAkyro, Faces[1]);

    }
    public void Dialogue5()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d5, tsTrash, vpTrash, Faces[0]);

    }
    public void Dialogue6()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d6, tsAkyro, vpAkyro, Faces[1]);

    }
    public void Dialogue7()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d7, tsTrash, vpTrash, Faces[0]);

    }
    public void Dialogue8()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d8, tsAkyro, vpAkyro, Faces[1]);

    }
    public void Dialogue9()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d9, tsTrash, vpTrash, Faces[0]);

    }
    public void Dialogue10()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d10, tsAkyro, vpAkyro, Faces[1]);

    }
    public void Dialogue11()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d11, tsTrash, vpTrash, Faces[0]);

    }
    public void Dialogue12()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        StartCoroutine(ChangeSpriteWithTimer(aTrash, "iddleback", 1f));
        StartCoroutine(StartDialogueWithTimer(d12, tsTrash, vpTrash, Faces[0], 2f));

    }

    public void DialogueSorter()
    {
        Debug.Log(GetComponent<SceneDialogueManager>().CounterDialogues);
        switch (GetComponent<SceneDialogueManager>().CounterDialogues)
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
            case 5:
                {
                    Dialogue5();
                    break;
                }
            case 6:
                {
                    Dialogue6();
                    break;
                }
            case 7:
                {
                    Dialogue7();
                    break;
                }
            case 8:
                {
                    Dialogue8();


                    break;
                }
            case 9:
                {

                    Dialogue9();



                    break;
                }
            case 10:
                {

                    Dialogue10();



                    break;
                }
            case 11:
                {
                    Dialogue11();
                    


                    break;
                }
            case 12:
                {

                    Dialogue12();

                    break;
                }
            case 13:
                {
                    StartCoroutine(endscenetimed(0f));
                    
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
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(false);
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


