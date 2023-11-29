using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class sTristanGlidewave : MonoBehaviour {

    static private bool dd1, dd2, dd3, dd4 , dd5, dd6 = false;
    static private bool td1, td2, td3, td4, td5, td6 = false;
    static private bool fd1, fd2, fd3, fd4, fd5, fd6  = false;
    static private bool id1, id2, id3, id4, id5, id6  = false;
    static public int trust, friendship, rivalry, love=0;

    public List<Sprite> NPCface;
    int SwapFaceID;
    public GameObject oNPCface;

    private sNPC script;
    //sNPC script (this.getcomponent<sNP>();)


    static private bool add, atd, afd, aid;
    private bool ay, an, y, n = false;
    private Queue<string> auxQueue;


    private int days;

    public GameObject GM;


    //character variables important

    private bool qfine, qlikework, qconspiracy = false;
    static private bool vlikework, vconspiracy, vhate, vhate2, vday1ignored = false;




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
    private void CheckNPCDay()
    {
        days = GameMaster.daycount;
        if (days == 2 || days == 4)
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



    // ACA EMPIEZA LA WEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    // ACA EMPIEZA LA WEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    // ACA EMPIEZA LA WEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    // ACA EMPIEZA LA WEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    // ACA EMPIEZA LA WEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA

    void Start () {
        SwapFaceID = 0;
        script = transform.GetComponent<sNPC>();
        days = GameMaster.daycount;
        dd1 = false; add = dd1; dd2 = dd1; dd3 = dd2; dd4 = dd3; dd5 = dd4; dd6 = dd5;
        td1 = false; atd = td1; td2 = td1; td3 = td2; td4 = td3; td5 = td4; td6 = td5; 
        fd1 = false; afd = fd1; fd2 = fd1; fd3 = fd2; fd4 = fd3; fd5 = fd4; fd6 = fd5;
        id1 = false; aid = id1; id2 = id1; id3 = id2; id4 = id3; id5 = id4; id6 = id5;
        
        Debug.Log("STARTS");
        //les convers xD
        //friday
        
        StartingM();
        
        




    }

    // Update is called once per frame
    void Update () {
        
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
        { SwapFace();script.frs = false; }



    }

    private void Yes() {
        if (qlikework)
        {
            script.SwapS("Isn't your job stressful though? Asking people questions, thinking all day, writing down notes, noticing details.");
            script.SwapI("I was just starting to like you.");
            script.SwapDisabled("Hey, you're a good person. Nice to talk to you.");
            qlikework = false;
            friendship = 1;
            vday1ignored = false;
        }
        else if (qfine)
        {
            script.SwapS("Night is better than day though, getting home and hugging my family. Sweet resting hours.");
            script.SwapDisabled("Hey, you're a good person. Nice to talk to you.");
            friendship = 1;
            qfine = false;


        }
        else if (qconspiracy)
        {
            //"It's nice to know I'm not the only one.");
            vconspiracy = true;
            script.SwapDisabled("Hey we are so similar.");
            script.SwapI("Oh and I though we were getting along. You seemed like a great guy.");
            qconspiracy = false;

        }
        else if (id1)
        {
            //"Okay okay sir, I wouldn't want that, no. What do you need.");
            rivalry = 3;
            script.SwapT("I know about...");

        }
        SwapFace();
    }

    private void No()
    {
        if (qlikework && !qconspiracy)
        {
            script.SwapS("If I had the possibility I'd change my job immediatly.");
            script.SwapDisabled("Hey, you're a good person. Nice to talk to you.");
            script.SwapI("Well don't bother answering. Anyways, I told you everything, really, look, I don't want any trouble, so there's no way I would lie to a detective.");
            qlikework = false;
            script.SwapYes("It's nice to know I'm not the only one.");
            script.SwapNo("Well I respect that.");
            vlikework = true;
            qconspiracy = true;
            SwapFaceID = 4;
            vday1ignored = false;
        }
        else if (qfine)
        {
            script.SwapS("If I had the possibility I'd change my job immediatly.");
            script.SwapDisabled("Hey, you're a good person. Nice to talk to you.");
            friendship = 2;
            qfine = false;

        }
        else if (qconspiracy && vlikework)
        {
            script.SwapDisabled("Nice chat...About the conspiracy thing, you should check more about that.");
            script.SwapI("Maybe I was lying about the conspiracy thing, I don't actually believe in that nonesense, there's no way that could be real. Right?");
            SwapFaceID = 2;
            vconspiracy = false;
            qconspiracy = false;
        }
        SwapFace();


    }


    public void ReplaceDecieve()
    {
        
        switch (days)
        {
            case 1:
                {
                    if (rivalry == 0)
                    {
                        //script.SwapD("I'm fine, what about you?+");
                        script.SwapOp("Fine","Sad");
                        qfine = true;
                        script.SwapS("Fine, don't even bother answering...");
                        script.SwapYes("Nice, good to know. I actually don't feel very happy, but I always get sad at night after work.");
                        script.SwapNo("Hey man, cheer up, I actually dislike my job.\nBut don't get me wrong, I really enjoy being an engineer, my whole life was dedicated to that, I just simply dislike my job position you know.");
                        friendship = 0;
                    }
                    else if (rivalry == 1)
                    {
                        friendship = 0;
                    }
                    
                    break;

                }
            case 2:
                {
                    

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

                    if (vhate)
                    {; }
                    else if (!vhate)
                    {
                        qlikework = true;
                        script.SwapF("Uhm sorry, as I just told you I'm happily married to my wife and we have 1 child, You just ignored all I said about my life don't you? It's ok don't worry, I know it happens.");
                        script.SwapI("But you didn't even let me finish, I don't want any trouble...\nI told you all the truth, I swear, well maybe not. Maybe I don't want little Christian to be an engineer, because I was forced to due to family tradition, but that's all.");
                        script.SwapS("You didn't even listen to me");
                        script.SwapYes("It's important you know, to do things you like while making money. That's the most important thing to me.");
                        script.SwapNo("Well, we can grief together I guess.\nEither I'm too melancholic or night is always like this. You know the conspiracy thing about government installing a METHOD in our CC to make us sadder at night so we act and feel more controlled?\nYeah, I believe in all of that. Do you?+");
                        trust = 1;
                        vday1ignored = true;
                    }
                    
                    break;
                }
            case 2:
                {
                  

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
                   

                    break;
                }
            case 2:
                {
                   

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
                    //script.SwapI("Uhm, okay, calm down sir, what do you want?ç");
                    script.SwapOp("Intimidate more","-");
                    script.SwapYes("Okay okay no, I wouldn't want that, no. What do you need.");
                    script.SwapS("Really ruined my mood man.");
                    script.SwapD("Nah, leave me alone.");
                    script.SwapT("Nah, leave me alone.");
                    script.SwapDisabled("I'm concentrated.");
                    vhate = true;
                    rivalry = 1;
                    break;
                }
            case 2:
                {
                   
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
                    SwapFaceID = 0;
                    script.SwapS("Oh Hello.");
                    script.SwapD("I'm fine, you?+");
                    script.SwapT("Oh, uhm, okay, I'll do my best.\nMy name is Tristan Glidewave, I'm an engineer working for ClutterShuttle, I'm 43 and I come to this bar right after work. Before getting back home with my warm family consisting of my wife and my only child.\nI usually enjoy coming here only because of 2 reasons, 1 because I have a premium membership with the bartender and 2 I don't want to get home all stressed out from work, my boy is 6 years old, I don't want him to get traumatized about being an engineer, I would gladly have him continue the family tradition of engineering. I actually dislike my job to be honest, not that I dislike being an engineer though, It's just the place and my boss just really pisses me off. Also It's at Clutter Art if you haven't heard of it, not the best place right? What about your job? Do you like it?+");
                    script.SwapF("uhm thanks?\nSorry but you know I have a wife and I love her...\nBut you're cool too, so sorry.");
                    script.SwapI("Uhm, calm down sir.ç");
                    script.SwapDisabled("It was good talking to you.");
                    
                    break;
                }
            case 3:
                {
                    SwapFaceID = 0;
                    if (trust == 0 && friendship == 0 && love == 0 && rivalry == 0)
                    {
                        script.SwapS("Oh Hello.");
                        script.SwapD("I'm fine, you?+");
                        script.SwapT("Oh, uhm, okay, I'll do my best.\nMy name is Tristan Glidewave, I'm an engineer working for ClutterShuttle, I'm 43 and I come to this bar right after work. Before getting back home with my warm family consisting of my wife and my only child.\nI usually enjoy coming here only because of 2 reasons, 1 because I have a premium membership with the bartender and 2 I don't want to get home all stressed out from work, my boy is 6 years old, I don't want him to get traumatized about being an engineer, I would gladly have him continue the family tradition of engineering. I actually dislike my job to be honest, not that I dislike being an engineer though, It's just the place and my boss just really pisses me off. Also It's at Clutter Art if you haven't heard of it, not the best place right? What about your job? Do you like it?+");
                        script.SwapF("uhm thanks?\nSorry but you know I have a wife and I love her...\nBut you're cool too, so sorry.");
                        script.SwapYes("Nice, good to know. I actually don't feel very happy, but I always get sad at night after work.");
                        script.SwapNo("Hey man, cheer up, I actually dislike my job.\nBut don't get me wrong, I really enjoy being an engineer, my whole life was dedicated to that, I just simply dislike my job position you know.");
                        script.SwapI("Meh...");
                        script.SwapDisabled("It was good talking to you.");
                    }
                    else if (vhate && vday1ignored)
                    {
                        script.SwapS("What do you want?");
                        script.SwapD("Well yesterday was kind of boring, what about you?+");
                        script.SwapT("You didn't even listen to me yesterday.");
                        script.SwapF("Now I don't get what you're doing.\nI've got a wife.");
                        script.SwapYes("Nice, good to know. I actually don't feel very happy, but I always get sad at night after work.");
                        script.SwapNo("Hey man, cheer up, I actually dislike my job.\nBut don't get me wrong, I really enjoy being an engineer, my whole life was dedicated to that, I just simply dislike my job position you know.");
                        script.SwapI("Okay, so be it.");
                        script.SwapDisabled("It was good talking to you.");
                    }
                    else if (vconspiracy)
                    {
                        script.SwapS("Oh Hello.");
                        script.SwapD("I had a nice day, work was shit as always, but on the way here I saw a nice E47 Motor on sale so I bought it.\nIt costed a lot but I think it's worth it, I'll attach it to my ride.");
                        script.SwapT("Oh, uhm, okay, I'll do my best.\nMy name is Tristan glidewave, I'm an engineer working for ClutterShuttle, I'm 43 and I come to this bar right after work. Before getting back home with my warm family consisting of my wife and my only child.\nI usually enjoy coming here only because of 2 reasons, 1 because I have a premium membership with the bartender and 2 I don't want to get home all stressed out from work, my boy is 6 years old, I don't want him to get traumatized about being an engineer, I would gladly have him continue the family tradition of engineering. I actually dislike my job to be honest, not that I dislike being an engineer though, It's just the place and my boss just really pisses me off. Also It's at Clutter Art if you haven't heard of it, not the best place right? What about your job? Do you like it?+");
                        script.SwapF("uhm thanks?\nSorry but you know I have a wife and I love her...\nBut you're cool too, so sorry.");
                        script.SwapI("Meh...");
                        script.SwapDisabled("It was good talking to you.");



                    }
     
                    





                    break;
                }
            case 5:
                {
                    
                    break;
                }
            default:
                {

                    script.SwapS("hey, uhm this is awkward, I was not programmed to be here yet xD\n Well now maybe we can be a couple.");
                    script.SwapD("DEFAULT");
                    script.SwapT("DEFAULT");
                    script.SwapF("Now that I know what you are, maybe we can get to know each other better.");
                    script.SwapI("DEFAULT");
                    script.SwapDisabled("DEFAULT");
                    break;
                }
        }SwapFace();

    }


}
