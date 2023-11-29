using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class scr_inbox : MonoBehaviour
{
    public List<Sprite> headers;
    public List<Sprite> pps;
    public scr_phone Phone;


    public Image Header;
    public Image Profilepic;
    public Text textArea;

    private List<Sprite> auxheaders;
    private List<string> chats;
    private List<bool> occupied;
    private List<int> auxcache;
    public List<Image> ProfileIcons;

    private int counter;

    public AudioSource notisound;

    public scChapter1 Chapter1;

    [TextArea(1, 10)]
    public List<string> Lucky1_Krypto;

    [TextArea(1, 10)]
    public List<string> Tristan1_Krypto;
    [TextArea(1, 10)]
    public List<string> Tristan1_Lucky_breakup;
    [TextArea(1, 10)]
    public List<string> Tristan1_Lucky_neutral;
    private bool auxbool;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Clock());
        Phone = GetComponent<scr_phone>();
        foreach (Image img in ProfileIcons)
        {
            img.sprite = null;
        }
        chats = new List<string>();
        occupied = new List<bool>();
        auxcache = new List<int>();
        auxheaders = new List<Sprite>();
        for (int i = 0; i < 6; i++)
        {
            chats.Add(" ");
            occupied.Add(false);
            auxcache.Add(10);
            auxheaders.Add(headers[5]);

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Phone.callscreen)
        {
            StopAllCoroutines();
            auxbool = true;
        }
        else if (auxbool)
        {
            StartCoroutine(Clock());
            auxbool = false;
        }





        
    }



    IEnumerator Clock()
    {

        yield return new WaitForSecondsRealtime(10f);
        NewMsg();
        StartCoroutine(Clock());
    }

    private void NewMsg()
    {
        int auxint = Random.Range(0, 30);
        if (auxint == 1)
        {
            switch (Phone.answercallID)
            {
                case 0:
                    {
                        Lucky1();
                        break;
                    }
                case 1:
                    {
                        Tristan1();
                        break;
                    }


            }

            Phone.newmsg = true;
            notisound.Play();
        }
        
        
    }

    private void Lucky1()
    {

        int rng1 = Random.Range(0, 1);
        int rng2;
        switch (rng1)
        {
            case 0:
                {

                    rng2 = Random.Range(0, 1);
                    Iteration(Lucky1_Krypto[rng2], 2);
                    break;
                }

        }
        
    }

    private void Tristan1()
    {

        int rng1 = Random.Range(0, 3);
        int rng2;
        switch (rng1)
        {
            case 0:
                {

                    rng2 = Random.Range(0, 1);
                    Iteration(Tristan1_Krypto[rng2], 2);
                    break;
                }
            case 1:
                {

                    if (Chapter1.vodump)
                    {
                        rng2 = Random.Range(0, 1);
                        Iteration(Tristan1_Lucky_breakup[rng2], 0);
                    }
                    
                    break;
                }
            case 2:
                {

                    rng2 = Random.Range(0, 2);
                    Iteration(Tristan1_Lucky_neutral[rng2], 0);
                    break;
                }

        }

    }



    private void Iteration(string text, int ppId)
    {


        for (int i = 0; i < ProfileIcons.Count-1; i++)
        {
            if (!occupied[i])
            {
                chats[i] = text;
                ProfileIcons[i].sprite = pps[ppId];
                auxheaders[i] = headers[ppId];
                auxcache[i] = ppId;
                occupied[i] = true;
                break;
            }
            else
            {
                if (auxcache[i] == ppId)
                {
                    chats[i] += '\n';
                    chats[i] += text;
                    ProfileIcons[i].sprite = pps[ppId];
                    auxheaders[i] = headers[ppId];
                    break;
                }

            }
        }


    }
    public void EnterChat(int id)
    {
        if (auxcache[id] != 10)
        {
            Header.sprite = auxheaders[id];
            Profilepic.sprite = ProfileIcons[id].sprite;
            textArea.text = chats[id];

            Phone.p_chat = true;

            Phone.ListPanels[3].SetActive(true);
            Phone.newmsg = false;
        }

    }

    public void ResetChats()
    {
        for (int i = 0; i < ProfileIcons.Count - 1; i++)
        {
            if (!occupied[i])
            {
                chats[i] = " ";
                ProfileIcons[i].sprite = null;
                auxheaders[i] = null;
                auxcache[i] = 10;
                occupied[i] = false;
                break;
            }

        }
    }







}
