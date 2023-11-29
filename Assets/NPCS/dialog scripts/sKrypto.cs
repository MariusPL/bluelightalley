using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class sKrypto: MonoBehaviour
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


    private bool bLies = false;




    //end of char vars


        

    public void CheckChange()
    {
        if (!script.daychanged)
        {
            ay = y;
            an = n;
            y = script.yd;
            n = script.nd;
            if (y) { Yes(); script.yd = false; }
            else if (n) { No(); script.nd = false; }
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



            }

        }
    }
    private void CheckNPCDay()
    {
        days = GameMaster.daycount;
        if (days == 1 || days == 3 || days==4)
        {
            script.Offday();
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



    // ACA EMPIEZA LA WEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    // ACA EMPIEZA LA WEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    // ACA EMPIEZA LA WEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    // ACA EMPIEZA LA WEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    // ACA EMPIEZA LA WEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA

    private void StartingM()
    {

        switch (days)
        {
            case 2:
                {

                    script.SwapS("What do you want mate.");
                    script.SwapD("Listen mate, I don't care. Im very busy.");
                    script.SwapF("Oh thanks, they are made from real gold.\nI bought them for 4M, light weight and comfortable.+");
                    script.SwapT("Ok, good luck with that.+");
                    script.SwapI("I have more power than you think.+");
                    script.SwapYes("");
                    script.SwapNo("");
                    script.SwapDisabled("");


                    break;
                }

            case 5:
                {

                    if (trust == 1)
                    { script.SwapT("Maybe i saw something, cant talk right now. Maybe some other day"); }
                    if (rivalry >= 1)
                    {
                        script.SwapI("Really?");
                    }

                    break;
                }

            case 6:
                {
                    if (trust ==2)
                    {
                        if (FindObjectOfType<GameMaster>().CheckNPC("Lucky"))
                        {
                            script.SwapT("I dont know, i think i saw that chick Lucky doin some weird things");
                        }
                    }

                    if (rivalry == 1)
                    {
                        script.SwapI("Really?");
                    }
                    if (rivalry == 2)
                    {
                        script.SwapI("Just go...");
                    }
                    break;
                }


            default:
                {

                    
                    break;
                }
        }
        SwapFace();

    }




private void Yes()
    {
        switch (days)
        {
            case 2:
                {

                    script.SwapDisabled("dijiste si xD");
                    break;
                }



        }
        
        SwapFace();
    }

    private void No()
    {
        switch (days)
        {
            case 2:
                {
                    
                    script.SwapDisabled("dijiste no xD");
                    break;
                }



        }
        SwapFace();

    }


    public void ReplaceDecieve()
    {

        switch (days)
        {
            case 2:
                {
                    //script.SwapD("Listen mate, I don't care. Im very busy.");

                    script.SwapF("flirt despues de d xD");

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
            case 2:
                {
                    script.SwapOp("Tell me about yourself.","Do you know anyone here.");
                    script.SwapYes("I'm known as Krypto, I'm the best programmer out there. Now stop talking to me, I said I'm busy.");
                    script.SwapNo("No mate, I just come here to work. Now stop bothering me, I said I'm busy.");
                    script.SwapI("Wasn't that enough? Leave me alone blockhead, I'm more dangerous than you can imagine.+");
                    trust++;
                    break;
                }
            case 5: {
                    if (trust == 1){
                        script.SwapT("Maybe i saw something, cant talk right now. Maybe some other day");
                        trust++;
                    }
                    break;
                }
        

        }
        SwapFace();
    }

    public void ReplaceFlirt()
    {

        switch (days)
        {
            case 2:
                {
                    if (friendship == 1)
                    {
                        love++;
                        script.SwapDisabled("sumaste friendship y love xD");
                    }


                    break;
                }

        }


        SwapFace();
    }

    public void ReplaceIntimidate()
    {

        switch (days)
        {
            case 2:
                {
                    if (td2)
                    {
                        //Wasn't that enough? Leave me alone blockhead, I'm more dangerous than you think.+");
                        script.SwapOp("Me too.", "Don't make me talk about...");
                        script.SwapYes("You don't know what I'm capable of numbskull. I can hack down your intel in seconds.");
                        script.SwapNo("!\nWho told you that! They are obviously lies.");
                        bLies = true;
                    }
                    
                    rivalry++;

                    break;
                }
            case 5:
                {
                    rivalry++;
                 
                    break;
                }





        }
        SwapFace();
    }



}