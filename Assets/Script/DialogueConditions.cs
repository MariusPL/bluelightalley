using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DialogueConditions : MonoBehaviour {



    private Queue<string> auxQueue;



    //funcion para reemplazar texto
    public void SwapText(string text, List<string> a)
    {
        a = new List<string>();
        auxQueue = new Queue<string>();
        string[] splitted = text.Split('\n');
        foreach (string sentence in splitted)
        {
            auxQueue.Enqueue(sentence);
        }
        a = auxQueue.ToList();
    }
    public void SwapD1(string text)
    {
        this.GetComponent<sNPC>().dialogue.d1 = new List<string>();
        auxQueue = new Queue<string>();
        string[] splitted = text.Split('\n');
        foreach (string sentence in splitted)
        {
            auxQueue.Enqueue(sentence);
        }
        this.GetComponent<sNPC>().dialogue.d1 = auxQueue.ToList();
    }
    public void SwapT1(string text)
    {
        this.GetComponent<sNPC>().dialogue.t1 = new List<string>();
        auxQueue = new Queue<string>();
        string[] splitted = text.Split('\n');
        foreach (string sentence in splitted)
        {
            auxQueue.Enqueue(sentence);
        }
        this.GetComponent<sNPC>().dialogue.t1 = auxQueue.ToList();
    }
    public void SwapF1(string text)
    {
        this.GetComponent<sNPC>().dialogue.f1 = new List<string>();
        auxQueue = new Queue<string>();
        string[] splitted = text.Split('\n');
        foreach (string sentence in splitted)
        {
            auxQueue.Enqueue(sentence);
        }
        this.GetComponent<sNPC>().dialogue.f1 = auxQueue.ToList();
    }
    public void SwapI1(string text)
    {
        this.GetComponent<sNPC>().dialogue.i1 = new List<string>();
        auxQueue = new Queue<string>();
        string[] splitted = text.Split('\n');
        foreach (string sentence in splitted)
        {
            auxQueue.Enqueue(sentence);
        }
        this.GetComponent<sNPC>().dialogue.i1 = auxQueue.ToList();
    }
    public void SwapDisabled(string text)
    {
        this.GetComponent<sNPC>().dialogue.disabledText = new List<string>();
        auxQueue = new Queue<string>();
        string[] splitted = text.Split('\n');
        foreach (string sentence in splitted)
        {
            auxQueue.Enqueue(sentence);
        }
        this.GetComponent<sNPC>().dialogue.disabledText = auxQueue.ToList();
    }



}
