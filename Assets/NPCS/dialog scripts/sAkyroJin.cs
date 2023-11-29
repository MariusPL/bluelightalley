using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class sAkyroJin : MonoBehaviour
{

    static private bool dd1, dd2, dd3, dd4, dd5, dd6, dd7 = false;
    static private bool td1, td2, td3, td4, td5, td6, td7 = false;
    static private bool fd1, fd2, fd3, fd4, fd5, fd6, fd7 = false;
    static private bool id1, id2, id3, id4, id5, id6, id7 = false;
    static public int trust, friendship, rivalry, love = 0;
    private sNPC script;

    public List<Sprite> NPCface;
    int SwapFaceID;
    public GameObject oNPCface;

    static private bool add, atd, afd, aid;
    private bool ay, an, y, n = false;
    private Queue<string> auxQueue;


    private int days;



    //character variables important



    //end of char vars




    public void CheckChange()
    {
        if (!script.daychanged)
        {
            ay = y;
            an = n;
            y = script.yd;
            n = script.nd;
            if (ay != y) { Yes(); }
            else if (an != n) { No(); }
            switch (days)
            {
                case 1:
                    {
                        add = dd1;
                        atd = td1;
                        afd = fd1;
                        aid = id1;
                        td1 = script.trd;
                        fd1 = script.fld;
                        id1 = script.ind;
                        dd1 = script.ded;
                        if (add != dd1 && dd1 == true) { ReplaceDecieve(); }
                        else if (atd != td1 && td1 == true) { ReplaceTruth(); }
                        else if (afd != fd1 && fd1 == true) { ReplaceFlirt(); }
                        else if (aid != id1 && id1 == true) { ReplaceIntimidate(); }
                        break;
                    }
                case 2:
                    {
                        add = dd2;
                        atd = td2;
                        afd = fd2;
                        aid = id2;
                        td2 = script.trd;
                        fd2 = script.fld;
                        id2 = script.ind;
                        dd2 = script.ded;
                        if (add != dd2 && dd2 == true) { ReplaceDecieve(); }
                        else if (atd != td2 && td2 == true) { ReplaceTruth(); }
                        else if (afd != fd2 && fd2 == true) { ReplaceFlirt(); }
                        else if (aid != id2 && id2 == true) { ReplaceIntimidate(); }
                        break;
                    }
                case 3:
                    {
                        add = dd3;
                        atd = td3;
                        afd = fd3;
                        aid = id3;
                        td3 = script.trd;
                        fd3 = script.fld;
                        id3 = script.ind;
                        dd3 = script.ded;
                        if (add != dd3 && dd3 == true) { ReplaceDecieve(); }
                        else if (atd != td3 && td3 == true) { ReplaceTruth(); }
                        else if (afd != fd3 && fd3 == true) { ReplaceFlirt(); }
                        else if (aid != id3 && id3 == true) { ReplaceIntimidate(); }
                        break;
                    }
                case 4:
                    {
                        add = dd4;
                        atd = td4;
                        afd = fd4;
                        aid = id4;
                        td4 = script.trd;
                        fd4 = script.fld;
                        id4 = script.ind;
                        dd4 = script.ded;
                        if (add != dd4 && dd4 == true) { ReplaceDecieve(); }
                        else if (atd != td4 && td4 == true) { ReplaceTruth(); }
                        else if (afd != fd4 && fd4 == true) { ReplaceFlirt(); }
                        else if (aid != id4 && id4 == true) { ReplaceIntimidate(); }
                        break;
                    }
                case 5:
                    {
                        add = dd5;
                        atd = td5;
                        afd = fd5;
                        aid = id5;
                        td5 = script.trd;
                        fd5 = script.fld;
                        id5 = script.ind;
                        dd5 = script.ded;
                        if (add != dd5 && dd5 == true) { ReplaceDecieve(); }
                        else if (atd != td5 && td5 == true) { ReplaceTruth(); }
                        else if (afd != fd5 && fd5 == true) { ReplaceFlirt(); }
                        else if (aid != id5 && id5 == true) { ReplaceIntimidate(); }
                        break;
                    }
                case 6:
                    {
                        add = dd6;
                        atd = td6;
                        afd = fd6;
                        aid = id6;
                        td6 = script.trd;
                        fd6 = script.fld;
                        id6 = script.ind;
                        dd6 = script.ded;
                        if (add != dd6 && dd6 == true) { ReplaceDecieve(); }
                        else if (atd != td6 && td6 == true) { ReplaceTruth(); }
                        else if (afd != fd6 && fd6 == true) { ReplaceFlirt(); }
                        else if (aid != id6 && id6 == true) { ReplaceIntimidate(); }
                        break;
                    }
                case 7:
                    {
                        add = dd7;
                        atd = td7;
                        afd = fd7;
                        aid = id7;
                        td7 = script.trd;
                        fd7 = script.fld;
                        id7 = script.ind;
                        dd7 = script.ded;
                        if (add != dd7) { ReplaceDecieve(); }
                        if (add != dd1 && dd1 == true) { ReplaceDecieve(); }
                        else if (atd != td7 && td7 == true) { ReplaceTruth(); }
                        else if (afd != fd7 && fd7 == true) { ReplaceFlirt(); }
                        else if (aid != id7 && id7 == true) { ReplaceIntimidate(); }
                        break;
                    }


            }

        }
    }
    private void CheckNPCDay()
    {
        days = GameMaster.daycount;
        if (days == 4 || days==2 )
        {
            script.Offday();
        }
        else
        {

        }
        if (days == 1)
        {
            resetvars();
        }



    }
    private void SwapFace()
    {
        oNPCface.GetComponent<Image>().sprite = NPCface[SwapFaceID];
    }
    void resetvars()
    {
        dd1 = false; add = dd1; dd2 = dd1; dd3 = dd2; dd4 = dd3; dd5 = dd4; dd6 = dd5; dd7 = dd6;
        td1 = false; atd = td1; td2 = td1; td3 = td2; td4 = td3; td5 = td4; td6 = td5; td7 = td6;
        fd1 = false; afd = fd1; fd2 = fd1; fd3 = fd2; fd4 = fd3; fd5 = fd4; fd6 = fd5; fd7 = fd6;
        id1 = false; aid = id1; id2 = id1; id3 = id2; id4 = id3; id5 = id4; id6 = id5; id7 = id6;
        trust = 0;
        friendship = 0;
        love = 0;
        rivalry = 0;

    }



    private void GetReputation()
    {
        int[] cmprlist = { GameMaster.repD, GameMaster.repT, GameMaster.repF, GameMaster.repI };
        int maxValue = cmprlist.Max();
        int maxIndex = cmprlist.ToList().IndexOf(maxValue);
        switch (maxIndex)
        {
            case 0:
                {

                    break;
                }

            case 1:
                {



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








        }

        Debug.Log(maxIndex);

    }

    // ACA EMPIEZA LA WEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    // ACA EMPIEZA LA WEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    // ACA EMPIEZA LA WEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    // ACA EMPIEZA LA WEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    // ACA EMPIEZA LA WEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA

    void Start()
    {
        script = transform.GetComponent<sNPC>();
        days = GameMaster.daycount;
        dd1 = false; add = dd1; dd2 = dd1; dd3 = dd2; dd4 = dd3; dd5 = dd4; dd6 = dd5; dd7 = dd6;
        td1 = false; atd = td1; td2 = td1; td3 = td2; td4 = td3; td5 = td4; td6 = td5; td7 = td6;
        fd1 = false; afd = fd1; fd2 = fd1; fd3 = fd2; fd4 = fd3; fd5 = fd4; fd6 = fd5; fd7 = fd6;
        id1 = false; aid = id1; id2 = id1; id3 = id2; id4 = id3; id5 = id4; id6 = id5; id7 = id6;
        SwapFaceID = 0;

        StartingM();


    }

    // Update is called once per frame
    void Update()
    {
        CheckChange();
        if (script.daychanged)
        {
            CheckNPCDay();
            script.daychanged = false;
            StartingM();
            if (days == 5)
            { GetReputation(); }


        }
        if (script.frs)
        { SwapFace(); script.frs = false; }

    }

    private void Yes()
    {


        SwapFace();
    }

    private void No()
    {

        SwapFace();

    }


    public void ReplaceDecieve()
    {

        switch (days)
        {
            case 1:
                {
                    if (!id1 && !fd1)
                    {
                        //"I am not interested in befriending you."
                        


                    }


                    friendship++;
                    break;
                }
        }
        SwapFace();


    }

    public void ReplaceTruth()
    {

        switch (days)
        {
            case 1:
                {
                    if (id1)
                    {
                        //Okay, my name is Akyro, member of the Jin clan, I swear on my clan master's name I will never commit murder by my own will.+
                        script.SwapOp("Tell me about your clan","Do you know anyone in this bar?");
                        script.SwapYes("House Jin, of Compassion. One of the most important traits in life.\nOur Master is Xakaii Jin. we work with the other 6 houses to mantain security in Stray city.+");
                        if (FindObjectOfType<GameMaster>().CheckNPC("Trash"))
                        { script.SwapNo("A good friend of mine comes to this bar. We... are drifting apart much...");
                        }
                        else if (FindObjectOfType<GameMaster>().CheckNPC("Hawg"))
                        { script.SwapNo("Hawg, leader of 'the Hunters'. I wouldn't mess with him. The other 3 members are equally deadly."); }
                        else if (FindObjectOfType<GameMaster>().CheckNPC("Chetverty"))
                        { script.SwapNo("Chetverty, the biggest of 'the Hunters', I've only heard his name. I know nothing about him."); }
                        else if (FindObjectOfType<GameMaster>().CheckNPC("Vig"))
                        { script.SwapNo("The last of 'the Hunters' the fastest of the four. Vig."); }
                        else
                        { script.SwapNo("Only the bartender right there. He is a good man."); }

                    }

                    script.SwapDisabled("Not the one you are looking for.");
                    trust++;
                    
                    break;
                }

        }
        SwapFace();
    }

    public void ReplaceFlirt()
    {

        switch (days)
        {
            case 1:
                {

                    love++;
                    break;
                }


        }


        SwapFace();
    }

    public void ReplaceIntimidate()
    {

        switch (days)
        {
            case 1:
                {
                    //("I do not feel intimidated by you. You don't seem capable of doing any harm to me. I'm sorry.+");
                    script.SwapOp("You will be under arrest for not cooperating","Yeah, you will be sorry.");
                    script.SwapYes("I will cooperate, just pointing out you don't intimidate me. Also, I'm aware that according to 'normative - 342 - common agreement', lack of cooperation is seen as a personal right and freedom to remain silent.\nI use that to scare people too.");
                    script.SwapNo("I want to cooperate, but your intel backing you up means nothing to me.\nI'll stop them one, by, one.");
                    script.SwapT("Okay, my name is Akyro, member of the Jin clan, I swear on my clan master's name I will never commit murder by my own will.+");
                    rivalry++;
                    break;
                }





        }
        SwapFace();
    }



    private void StartingM()
    {

        switch (days)
        {
            case 1:
                {

                    script.SwapS("Yes?");
                    script.SwapD("I am not interested in befriending you.");
                    script.SwapT("So a murder...My name is Akyro, member of the Jin clan, hence I bear it's last name. My clan is my family, and I respect it's code to death.\nI would only kill in self defense or if ordered by the clan master.");
                    script.SwapF("I am not interested in nonesense chatting with you.");
                    script.SwapI("I do not feel intimidated by you. You don't seem capable of doing any harm to me. I'm sorry.+");
                    script.SwapDisabled("You have to understand that I will not trust anyone easily.");


                    break;
                }




            default:
                {

                    script.SwapS("Nicely done.");
                    script.SwapD("DEFAULT");
                    script.SwapT("DEFAULT");
                    script.SwapF("I am still not interested at all.");
                    script.SwapI("DEFAULT");
                    script.SwapDisabled("DEFAULT");
                    break;
                }
        }
        SwapFace();

    }


}
