using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class sRim : MonoBehaviour
{

    static private bool dd1, dd2, dd3, dd4, dd5, dd6 = false;
    static private bool td1, td2, td3, td4, td5, td6 = false;
    static private bool fd1, fd2, fd3, fd4, fd5, fd6 = false;
    static private bool id1, id2, id3, id4, id5, id6 = false;
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

    private bool bd1, bd1y, bd1n;
    private int cbd1y, cbd1n = 0;



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
        if (days == 3  || days==6)
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
        dd1 = false; add = dd1; dd2 = dd1; dd3 = dd2; dd4 = dd3; dd5 = dd4; dd6 = dd5; 
        td1 = false; atd = td1; td2 = td1; td3 = td2; td4 = td3; td5 = td4; td6 = td5; 
        fd1 = false; afd = fd1; fd2 = fd1; fd3 = fd2; fd4 = fd3; fd5 = fd4; fd6 = fd5; 
        id1 = false; aid = id1; id2 = id1; id3 = id2; id4 = id3; id5 = id4; id6 = id5; 
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
        dd1 = false; add = dd1; dd2 = dd1; dd3 = dd2; dd4 = dd3; dd5 = dd4; dd6 = dd5; 
        td1 = false; atd = td1; td2 = td1; td3 = td2; td4 = td3; td5 = td4; td6 = td5; 
        fd1 = false; afd = fd1; fd2 = fd1; fd3 = fd2; fd4 = fd3; fd5 = fd4; fd6 = fd5; 
        id1 = false; aid = id1; id2 = id1; id3 = id2; id4 = id3; id5 = id4; id6 = id5; 
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



        }
        if (script.frs)
        { SwapFace(); script.frs = false; }
        if (script.FaceChangeInText)
        {
            SwapFaceID = script.FaceChangeInTextID;
            script.FaceChangeInText = false;
            SwapFace();
        }

    }
    // ACA EMPIEZA LA WEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    // ACA EMPIEZA LA WEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    // ACA EMPIEZA LA WEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    // ACA EMPIEZA LA WEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    // ACA EMPIEZA LA WEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    //para checkear si esta x npc(en este caso tristan)
    //FindObjectOfType<GameMaster>().CheckNPC("Tristan Glidewave")


    //para cambiar las opciones que aparecen en vez de carita feliz y eso
    //script.SwapOp("lol","lol2");


    private void StartingM()
    {

        switch (days)
        {
            case 1:
                {
                    script.SwapS("...");
                    script.SwapD("Everyday's been easy since I took down the government.+");
                    script.SwapT("What's one murder compared to millions of lives. If you think what you're doing is important then you don't really know what's important kid.");
                    script.SwapF("Memento mori, ego mortem, this scar means a lot to me. It reminds me that I'm not inmortal.");
                    script.SwapI("You know, I once was as confrontational as you. I thought everything that's in my way should be dealt with. But sometimes you just have to step aside.");
                    script.SwapDisabled("DEFAULT");


                    break;
                }
            case 5:
                {
                    GetReputation();
                    break;
                }

            default:
                {

                    script.SwapS("DEFAULT");
                    script.SwapD("DEFAULT");
                    script.SwapT("DEFAULT");
                    script.SwapF("DEFAULT");
                    script.SwapI("DEFAULT");
                    script.SwapDisabled("DEFAULT");
                    break;
                }
        }
        SwapFace();

    }

    private void Yes()
    {
        switch (days)
        {
            case 1:
                {
                    if (bd1)
                    {
                        if (bd1n)
                        {
                            switch (cbd1n)
                            {
                                case 1:
                                    {

                                        //The ones who don't respect their heroes.
                                        bd1 = false;

                                        break;
                                    }

                            }
                        }
                        else
                        {
                            switch (cbd1y)
                            {
                                case 0:
                                    {
                                        //script.SwapYes("You don't know who I am?+");
                                        script.SwapOp("Who are you?","I don't care");
                                        script.SwapYes("It doesn't matter.");
                                        script.SwapNo("Of course not, I only saved the world from doom. This world is deceased...");
                                        cbd1y = 1;
                                        bd1y = true;
                                        break;
                                    }
                                case 1:
                                    {
                                        //"It doesn't matter.");
                                        bd1 = false;
                                        break;
                                    }


                            }


                        }



                    }

                    break;
                }


        }
       
        SwapFace();
    }

    private void No()
    {
        switch(days)
        {
            case 1:
                {
                    if (bd1)
                    {
                        if (bd1y)
                        {
                            switch (cbd1y)
                            {
                                case 1:
                                    {

                                        //"Of course not, I only saved the world from doom. This world is deceased...");
                                        bd1 = false;

                                        break;
                                    }

                            }


                        }
                        else
                        {
                            switch (cbd1n)
                            {
                                case 0:
                                    {
                                        //script.SwapNo("Well, you're one of those kids huh?+");
                                        script.SwapOp("What kids?","You're overreacting");
                                        script.SwapYes("The ones who don't respect their heroes.");
                                        script.SwapNo("Let me tell you something. I've experienced hell you'll probably never even see in your life, so nothing I do is too much.\nSaving your life is not bragging.");
                                        cbd1n = 1;
                                        bd1n = true;
                                        break;
                                    }
                                case 1:
                                    {
                                        //("Let me tell you something. I've experienced hell you'll probably never even see in your life, 
                                        //so nothing I do is too much.\nSaving your life is not bragging."

                                        bd1 = false;
                                        break;
                                         }



                            }


                        }



                    }




                    break;
                }


        }
        SwapFace();

    }


    public void ReplaceDecieve()
    {

        switch (days)
        {
            case 1:
                {
                    //script.SwapD("Everyday's been easy since I took down the government.+");
                    script.SwapOp("What?","Stop bragging");
                    script.SwapYes("You don't know who I am?+");
                    script.SwapNo("Well, you're one of those kids huh?+");
                    bd1 =true;
                    break;
                }
        }
        SwapFace();


    }

    public void ReplaceTruth()
    {

        switch (days)
        {
           
        }
        SwapFace();
    }

    public void ReplaceFlirt()
    {

        switch (days)
        {
            

        }


        SwapFace();
    }

    public void ReplaceIntimidate()
    {

        switch (days)
        {
            




        }
        SwapFace();
    }



    


}
