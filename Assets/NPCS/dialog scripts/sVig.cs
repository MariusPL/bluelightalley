using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class sVig : MonoBehaviour
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

    static public bool vWeird, vNice, vFlirted, vScary, vAgreed, vKillMan;



    private bool brBadass, brBadassY, brBadassN;
    private int cbrBadassY, cbrBadassN;


    private bool brFear, brFearY, brFearN;
    private int cbrFearY, cbrFearN;


    private bool brCK, brCKY;
    private int cbrCKY;

    private bool brTI3, brTI3y, brTI3n;
    private int cbrTI3y, cbrTI3n;
    private bool brIT3, brIT3y, brIT3n;
    private int cbrIT3y, cbrIT3n;
    private bool brID3, brID3y, brID3n;
    private int cbrID3y, cbrID3n;
    private bool brFD3, brFD3y, brFD3n;
    private int cbrFD3y, cbrFD3n;

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
        if (days == 3 || days == 5)
        {
            
        }
        else
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
            case 3:
                    {
                    script.SwapS("What do you want.");
                    script.SwapD("I don't know,  my life is too complicated to be summarized.");
                    script.SwapT("My name is Vig.");
                    script.SwapI("Hey calm down big man, what do you want?");
                    script.SwapF("...\nYeah, it's been a long night, what's up.");





                    break;
                }


            case 5:
                {
                    //vWeird, vNice, vFlirted, vScary, vAgreed;

                    if (vWeird)
                    {
                        script.SwapS("Hello untrusty weirdo.");
                        script.SwapD("How's the case?\nI'm telling you, you have to trust the net, there's a lot information out there...");
                        script.SwapT("I haven't seen anything suspicious.");
                        script.SwapF("");
                        script.SwapI("");

                    }
                    else if (vNice)
                    {
                        script.SwapS("Hey... uhm, hi.");
                        script.SwapD("");
                        script.SwapT("I haven't seen anything suspicious.");
                        script.SwapF("Oh thanks...");
                        script.SwapI("");
                    }
                    else if (vFlirted)
                    {
                        script.SwapS("...Hey...");


                    }
                    else if (vScary)
                    {
                        script.SwapS("What do you need.");



                    }
                    else if (vAgreed)
                    {
                        script.SwapS("Hey Chicken Killer");

                    }
                    else if (vKillMan)
                    {
                        script.SwapS("Psychopath");

                    }

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
            case 3:
                {
                    if (brBadass)
                    {
                        if (brBadassN)
                        {
                            switch (cbrBadassN)
                            {
                                case 1:
                                    {
                                        //script.SwapYes("No I don't, now stop talking to me.ç");
                                        script.SwapOp("You care", "");
                                        script.SwapYes("I told you I fu-\nI mean, okay, whatever boy, think what you want.");
                                        script.SwapDisabled("Oh you really listened to me.");

                                        cbrBadassN = 11;

                                        break;
                                    }
                                case 11:
                                    {
                                        //("I told you I fu-\nI mean, okay, whatever boy, think what you want.")
                                        script.SwapDisabled("I don't care about nothing.");
                                        love++;
                                        brBadass = false;

                                        break;
                                    }



                                case 2:
                                    {
                                        //script.SwapYes("Oh... uhm-\nAre you flirting with me?+");
                                        script.SwapOp("Abosloutely","Nah");
                                        script.SwapYes("I'm a dude who's into, uh, girls. Don't flirt with me.");
                                        script.SwapNo("Oh yes you are- I mean, I don't even care.");

                                        cbrBadassN = 21;
                                        love++;
                                        break;
                                    }
                                case 21:
                                    {
                                        //script.SwapYes("I'm a dude who's into, uh, girls. Don't flirt with me.");
                                        script.SwapDisabled("I'm 100% into girls.");
                                        love++;
                                        brBadass = false;
                                        vFlirted = true;
                                        break;
                                    }






                            }




                        }
                        else
                        {
                            switch (cbrBadassY)
                            {
                                case 0:
                                    {
                                        //("Oh... Thank you...\nI don't get that often.+");
                                        script.SwapOp("Strange", "Obviously, because I was not serious");
                                        script.SwapYes("Yeah... I don't try really hard to get people to tell me that, but it is nice...");
                                        script.SwapNo("Hey!\nI mean-uh-, Hah! So funny, I don't care what anyone thinks anyways.");
                                        cbrBadassY = 1;
                                        brBadassY = true;
                                        friendship++;



                                        break;
                                    }
                                case 1:
                                    {
                                        // script.SwapYes("Yeah... I don't try really hard to get people to tell me that, but it is nice...");
                                        script.SwapDisabled("You're nice too.");
                                        vNice = true;
                                        friendship++;
                                        brBadass = false;
                                        break;
                                    }



                            }




                        }



                    }
                    if (brFear)
                    {
                        if (brFearN)
                        {


                        }
                        else
                        {
                            switch (cbrFearY)
                            {
                                case 0:
                                    {
                                        //script.SwapYes("No, YOU'll fear me.ç");
                                        script.SwapOp("No, You'll fear me.","-");
                                        script.SwapYes("NoNO, YOU'l--\n...\nThis is nonesense...");
                                        script.SwapDisabled("My squad can take you down anytime.");

                                        brFearY = true;
                                        cbrFearY = 1;
                                        rivalry++;
                                        break;
                                    }
                                case 1:
                                    {
                                        //script.SwapYes("Nono, YOU'l--\nThis is nonesense...");
                                        script.SwapDisabled("I won't waste time over you.");
                                        rivalry++;
                                        brFear = false;
                                        break;
                                    }



                            }


                        }


                    }
                    if (brCK)
                    {
                        
                        switch (cbrCKY)
                        {
                            case 0:
                                {
                                    //script.SwapYes("We hunt together. We are the CKs.\nWe don't kill normal people, we do it in an elegant way. You want our card?+");
                                    script.SwapOp("Please","No thanks.");
                                    script.SwapYes("Okay let me see...\nI don't have any left, but you can get our code:\n93125235VIG\nThat's it, and that's my promotional code, with a 50% discount on your first order.");
                                    script.SwapNo("Okay, your miss.");
                                    cbrCKY = 1;
                                    brCKY = true;
                                    
                                    love++;
                                    break;
                                }
                            case 1:
                                {
                                    //"Okay let me see...\nI don't have any left, but you can get our code:\n93125235VIG\nThat's 
                                    //it, and that's my promotional code, with a 50% discount on your first murder.");
                                    trust++;
                                    script.SwapDisabled("Remember to put in the Vig at the end.");
                                    brCK = false;

                                    break;
                                }


                        }


                    }
                    if (brTI3)
                    {
                        if (brTI3n)
                        {


                        }
                        else
                        {
                            switch (cbrTI3y) {
                                case 0:
                                    {
                                        //("Don't make me angry boy+");
                                        script.SwapOp("I'll make you as angry as I want","I'm not afraid of you");
                                        script.SwapYes("Okay, okay, you want to fight?-\nYou know what? I- There's no point.");
                                        script.SwapNo("That's because you don't know who I am.+");
                                        
                  
                                        brTI3y = true;
                                        cbrTI3y = 1;
                                        break;

                                    }
                                case 11:
                                    {
                                        //"I'm Vig.\nYou thought I would give you information that easy?ç");
                                        script.SwapOp("Yes, you don't seem smart","");
                                        script.SwapYes("HOW DARE Y-\nAhem...\nGet out of my sight before I kill you...");
                                        script.SwapDisabled("Watch your back...");
                                        rivalry++;
                                        cbrTI3y = 12;
                                        break;
                                    }
                                case 12:
                                    {
                                        //("HOW DARE Y-\nAhem...\nGet out of my sight before I kill you...");
                                        script.SwapDisabled("Last warning...");
                                        rivalry++;
                                        love++;
                                        
                                        break;
                                    }
                                case 13:
                                    {

                                        //HOW H-\nSo you never heard of us...\nThat's too bad. For you.\n...\nWE are the most dangerous and reliable contract killers out there! How come you don't know about us! 
                                        //We do it in a series of steps nobody does. For a higher fee of course. But paying for more quality means value.");

                                        script.SwapDisabled("I mean, I don't care anyways, we are more famous than you think.");
                                        rivalry++;


                                        break;
                                    }
                                case 1:
                                    {
                                        //script.SwapYes("Okay, okay, you want to fight?-\nYou know what? I- There's no point.");
                                        script.SwapDisabled("That was childish.");
                                        rivalry++;
                                        
                                        break;
                                    }





                            }


                        }


                    }
                    if (brIT3)
                    {
                        if (brIT3n)
                        {
                            switch (cbrIT3n)
                            {
                                case 1:
                                    {
                                        //script.SwapYes("I won't make propaganda for the other one.+");
                                        script.SwapOp("I don't care.","It's not propaganda");
                                        script.SwapYes("Well, I do care, that's very important to me.");
                                        script.SwapNo("Yes it is, it's obviously propaganda for them. We are better.");
                                        trust++;
                                        cbrIT3n = 11;

                                        break;
                                    }
                                case 11:
                                    {
                                        //("Well, I do care, that's very important to me.");
                                        script.SwapDisabled("You don't tell me what to say.");
                                        rivalry++;

                                        break;
                                    }
                                case 2:
                                    {
                                        //"In any way you can think of, we make you thrill, fear, give up, have hope, and finally kill you. It's artistic, our leader plans everything perfectly.ç")
                                        script.SwapOp("Who's your leader","-");
                                        script.SwapYes("I can't reveal that information, that's too much.");
                                        script.SwapDisabled("I already told you too much.");
                                        cbrIT3n = 21;
                                        trust++;
                                        break;
                                    }
                                case 21:
                                    {
                                        //("I can't reveal that information, that's too much.")
                                        trust++;

                                        break;
                                    }
                                case 3:
                                    {
                                        //("What? How do y-\nThat's creepy, no one else know that, how do you know that?+");
                                        script.SwapOp("I'm the one asking questions","There's more...");
                                        script.SwapYes("Okay, we are an elite organization, our leader plans the killings. We accept only very high fees. We only kill important people. I'm in this job because I excelled at the assasin's academy and got direct contact from our leader.");
                                        script.SwapNo("...\nWhat do you want to know...+");
                                        script.SwapDisabled("You are scary...");
                                        trust++;
                                        rivalry++;
                                        cbrIT3n = 31;


                                        break;
                                    }
                                case 31:
                                    {
                                        //("Okay, we are an elite organization, our leader plans the killings. We accept only very high fees.
                                        //We only kill important people. I'm in this job because I excelled at the assasin's academy and got 
                                        //direct contact from our leader.");
                                        script.SwapDisabled("You are scary...");
                                        trust++;
                                        rivalry++;

                                        break; }
                                case 41:
                                    {
                                        //"Well you already know a lot but, here we go...\nI was born in the Sink, yeah...\nI was rescue
                                        //d our leader, we survived together for years down there. I had to learn how to survive. 
                                        //And that's what we all did.\nThe ones who didn't, don't make it out.");
                                        script.SwapDisabled("I consider myself as a lucky girl...");
                                        trust++;

                                        break;
                                    }



                            }


                        }
                        else
                        {
                            switch (cbrIT3y)
                            {
                                case 0:
                                    {
                                        //("Man, just google our name, we don't accept Contracts in this area. And I'd never kill for free if I get paid for it.+");
                                        script.SwapOp("Answer properly","The net is not reliable.");
                                        script.SwapYes("Hey tough guy, if you keep talking like that I'm gonna punch you in the face.+");
                                        script.SwapNo("If the net is not a reliable source to you, then I can't help you.");
                                        script.SwapDisabled("Next time I'll bring our card with a discount coupon for you.");
                                        brIT3y = true;
                                        cbrIT3y = 1;
                                        break;
                                    }
                                case 1:
                                    {
                                        //("Hey tough guy, if you keep talking like that I'm gonna punch you in the face.+");
                                        script.SwapOp("*Intimidation*","*Passive Aggresive*");
                                        script.SwapYes("Yeah, but I won't kill you, as I said, I don't do this for free. If you wanna die, pay me first, then get out of this city, and you'll be dead by tomorrow.");
                                        script.SwapNo("...\nOk, what else do you want to know?+");
                                        cbrIT3y = 2;
                                        break;
                                    }
                                case 21:
                                    {
                                        //script.SwapYes("I have a fat contract, we are getting paid a lot.+");
                                        script.SwapOp("Who is the victim","Logistics?");
                                        script.SwapYes("I can't tell you his name...\nIt's against us, I can't know if you are going to interfere with this.");
                                        script.SwapNo("I can't really reveal any information about this. I already told you too much.");
                                        script.SwapDisabled("You're welcome.");
                                        trust++;
                                        cbrIT3y = 31;

                                        break;
                                    }
                                case 22:
                                    {
                                        //Knife polishing oil,batteries and more knives for my charged gauntlet.");
                                        trust++;


                                        break;
                                    }
                                case 2:
                                    {
                                        //("Yeah, but I won't kill you, as I said, I don't do this for free. If you wanna die, 
                                        //pay me first, then get out of this city, and you'll be dead by tomorrow."
                                        script.SwapDisabled("Don't underestimate me.");

                                        break;
                                    }
                                case 31:
                                    {
                                        //("I can't tell you his name...\nIt's against us, I can't know if you are going to interfere with this.");
                                        script.SwapDisabled("You better do nothing about this.");
                                        rivalry++;
                                       

                                        break;
                                    }
                                case 41:
                                    {
                                        //"Well you already know a lot but, here we go...\nI was born in the Sink, yeah...\nI was rescued our leader,
                                        //we survived together for years down there. I had to learn how to survive. And that's what we all did.\
                                        //nThe ones who didn't, don't make it out.");
                                        script.SwapDisabled("I already told you too much today.");
                                        trust++;
                                        break;
                                    }


                            }


                        }



                    }
                    if (brID3)
                    {
                        if (brID3n)
                        {
                            switch (cbrID3n)
                            {
                                case 1:
                                    {
                                        //("Hey don't try me, I'm capable of taking you down in a milisecond.+");
                                        script.SwapOp("Wanna try?","My intel is watching us right now");
                                        script.SwapYes("WH-!?\nI mean,\nNno, I'm not in the mood of killing someone, so no.");
                                        script.SwapNo("...\nI'm not afraid, I didn't want to fight you anyways, I'm kind of tired from work today...");
                                        rivalry++;
                                        cbrID3n = 11;

                                        break;
                                    }
                                case 11:
                                    {
                                        //("WH-!?\nI mean,\nNno, I'm not in the mood of killing someone, so no.");
                                        script.SwapDisabled("I can give you my number if you want.\nGive me a call and I'll beat you up.");
                                        rivalry++;
                                        break;
                                    }

                                case 2:
                                    {
                                        //"See that masked man? The one with red lights... He is Trash.\n
                                        //I greatly admire him... He never failed any task, no one ever escapes his grasp.\nOh by the way, we are Contract Killers."

                                        if (FindObjectOfType<GameMaster>().CheckNPC("Trash"))
                                        {
                                            script.SwapDisabled("I wish I was like him...\nJust kidding, I'm the best.");


                                        }
                                        else
                                        {
                                            script.SwapDisabled("I'm confused...");
                                        }

                                            

                                        friendship++;
                                        break;
                                    }

                            }
                        }
                        else
                        {
                            switch (cbrID3y)
                            {
                                case 0:
                                    {
                                        //("Uhm not telling you anything about me.+");
                                        script.SwapOp("*Intimidation*","*Passive Aggresive*");
                                        script.SwapYes("Hilarious, I'm a Contract Killer, not anyone, don't try me. Or this can get really bad.");
                                        script.SwapNo("Don't even try, I'm not that easily scared.");
                                        
                                        brID3y = true;
                                        cbrID3y = 1;
                                        break;
                                    }
                                case 1:
                                    {
                                        //"Hilarious, I'm a Contract Killer, not anyone, don't try me. Or this can get really bad.");
                                        script.SwapDisabled("Really bad for you. Not exagerating.");
                                        rivalry++;

                                        break;
                                    }



                            }

                        }

                    }
                    if (brFD3)
                    {

                        if (brFD3n)
                        {

                            switch (cbrFD3n)
                            {
                                case 1:
                                    {
                                        //script.SwapYes("Nice, not that I care what you think about my job any ways...");
                                        script.SwapDisabled("Nice talk.");
                                        friendship++;
                                        love++;
                                        vAgreed = true;
                                   
                                        break;
                                    }
                                case 2:
                                    {
                                        //script.SwapYes("I can't argue against that logic...");
                                        script.SwapDisabled("Think about it...");
                                        friendship--;
                                        vKillMan = true;

                                        break;
                                    }



                            }



                        }

                        //"Because a company paid me to do so...\nOh did I not mention I'm a Contract Killer...\nWell my job is really simple, people pay me to kill."
                        script.SwapDisabled("Sometimes I notify the victim the day before, if he pays me more than the one who payed me first, the victim gets to save his ass.\nAnd then I'll notify the one who paid me to kill, so he pays me more if he really wants the other one dead.\nIt's called the invisible hand...");
                        friendship++;


                    }

                    break;
                }



        }
       
        SwapFace();
    }

    private void No()
    {
        switch (days)
        {
            case 3:
                {
                    if (brBadass)
                    {
                        if (brBadassY)
                        {
                            switch (cbrBadassY)
                            {

                                case 1:
                                    {
                                        //script.SwapNo("Hey!\nI mean-uh-, Hah! So funny, I don't care what anyone thinks anyways.");
                                        script.SwapDisabled("...");
                                        love++;
                                        brBadass = false;
                                        break;
                                    }



                            }
                        }
                        else
                        {
                            switch (cbrBadassN)
                            {
                                case 0:
                                    {
                                        //script.SwapNo("Oh... I see...\nI don't care what you think anyways.+");
                                        script.SwapOp("You care","Don't be so harsh");
                                        script.SwapYes("No I don't, now stop talking to me.ç");
                                        script.SwapNo("I'm not harsh- I mean, uh, I'm just like this all the time.+");
                                        script.SwapDisabled("If you don't like it that's fine.");
                                        brBadassN = true;
                                        cbrBadassN = 1;
                                        rivalry++;
                                        break;
                                    }
                                case 1:
                                    {
                                        //script.SwapNo("I'm not harsh- I mean, uh, I'm just like this all the time.+");
                                        script.SwapOp("That's hot","You have to chill");
                                        script.SwapYes("Oh... uhm-\nAre you flirting with me?+");
                                        script.SwapNo("I won't chill, this is the way I am.");
                                        
                                        cbrBadassN = 2;
                                        break;
                                    }
                                case 2:
                                    {
                                        //script.SwapNo("I won't chill, this is the way I am.");
                                        script.SwapDisabled("Don't flirt with me.");
                                        brBadass = false;
                                        break;
                                    }
                                case 21:
                                    {
                                        //("Oh yes you are- I mean, I don't even care.");
                                        script.SwapDisabled("I never cared.");
                                        love++;
                                        brBadass = false;


                                        break;
                                    }



                            }




                        }



                    }
                    if (brFear)
                    {
                        if (brFearY)
                        {


                        }
                        else
                        {
                            switch (cbrFearN)
                            {
                                case 0:
                                    {
                                        //("I won't tell you. You are creepy.");
                                        script.SwapDisabled("Next time don't even try to intimidate me.");
                                        brFear = false;
                                        break;
                                    }



                            }


                        }


                    }
                    if (brCK)
                    {
                        if (brCKY)
                        {
                            switch (cbrCKY)
                            {
                                case 1:
                                    {
                                        // script.SwapNo("Okay, your miss.");
                                        
                                        script.SwapDisabled("You will want one later.");
                                        brCK = false;

                                        break;
                                    }


                            }

                        }
                        else

                        { //script.SwapNo("Hawg, he is the head of our team. No more questions.");
                            script.SwapDisabled("I already gave you too much information...");
                            brCK = false;
                        }


                        
                    }
                    if (brTI3)
                    {
                        if (brTI3y)
                        {
                            switch (cbrTI3y)
                            {
                                case 1:
                                    {
                                        //"That's because you don't know who I am.+");
                                        script.SwapOp("Who are you","I don't care");
                                        script.SwapYes("I'm Vig.\nYou thought I would give you information that easy?ç");
                                        script.SwapNo("I am one of the Hunters!ç");
                                        rivalry++;
                                        cbrTI3y = 11;

                                        break;
                                    }
                                case 11:
                                    {
                                        //script.SwapNo("I am one of the Hunters!ç");
                                        script.SwapOp("Never heard of that", "");
                                        script.SwapYes("HOW H-\nSo you never heard of us...\nThat's too bad. For you.\n...\nWE are the most dangerous and reliable contract killers out there! How come you don't know about us!.");
                                        cbrTI3y= 13;
                                        break;
                                    }
                                




                            }

                        }
                        else
                        {
                            switch (cbrTI3n)
                            {
                                case 0:
                                    {



                                        brTI3n = true;
                                        cbrTI3n = 1;
                                        break;

                                    }




                            }


                        }


                    }
                    if (brIT3)
                    {
                        if (brIT3y)
                        {
                            switch (cbrIT3y)
                            {
                                case 1:
                                    {
                                        //script.SwapNo("If the net is not a reliable source to you, then I can't help you.");
                                        script.SwapDisabled("You are one of those who doesn't trust the net, I don't know in what world do you guys live in.");
                                        vWeird = true;



                                        break;
                                    }
                                case 2:
                                    {
                                        //script.SwapNo("...\nOk, what else do you want to know?+");
                                        script.SwapOp("What are you doing this Saturday", "What are you doing today");
                                        script.SwapYes("I have a fat contract, we are getting paid a lot.+");
                                        script.SwapNo("After this I'm heading to my base, buying some supplies and getting a good night sleep.ç");
                                        rivalry++;
                                        trust++;
                                        cbrIT3y = 21;
                                        break;
                                    }
                                case 21:
                                    {
                                        //After this I'm heading to my base, buying some supplies and getting a good night sleep.ç");
                                        script.SwapOp("What supplies", "Hackerman xDD");
                                        script.SwapYes("Knife polishing oil,batteries and more knives for my charged gauntlet.");
                                        script.SwapDisabled("You're welcome detective.");
                                        cbrIT3y = 22;
                                        trust++;

                                        break;
                                    }
                                case 31:
                                    {
                                        //"I can't really reveal any information about this. I already told you too much.");
                                        script.SwapDisabled("Too much...");
                                        trust++;
                                        break;
                                    }




                            }

                        }
                        else
                        {
                            switch (cbrIT3n)
                            {
                                case 0:
                                    {
                                        //here is another organization operating in this city, a big one too...\nBut the Hunters 
                                        //are better, we just don't want to get the city we live in all dirty.+

                                        script.SwapOp("What's the other organization","Why better");
                                        script.SwapYes("I won't make propaganda for the other one.+");
                                        script.SwapNo("Because we do it in an elegant manner, not like other uncultured swines.+");
                                        cbrIT3n = 1;
                                        brIT3n = true;
                                        trust++;
                                        break; }
                                case 11:
                                    {
                                        //script.SwapNo("Yes it is, it's obviously propaganda for them. We are better.");
                                        script.SwapDisabled("The hunters are better.");
                                        rivalry++;


                                        break;
                                    }
                                case 1:
                                    {
                                        //("Because we do it in an elegant manner, not like other uncultured swines.+");
                                        script.SwapOp("What's elegant in killing","Give me useful information.");
                                        script.SwapYes("In any way you can think of, we make you thrill, fear, give up, have hope, and finally kill you. It's artistic, our leader plans everything perfectly.ç");
                                        script.SwapNo("I already told you a lot, can't think of anything else.ç");
                                        cbrIT3n = 2;
                                        friendship++;
                                        break;
                                    }
                                case 2:
                                    {
                                        //("I already told you a lot, can't think of anything else.ç");
                                        script.SwapOp("I'm sure you can...","-");
                                        script.SwapYes("What? How do y-\nThat's creepy, no one else know that, how do you know that?+");
                                        cbrIT3n = 3;
                                        friendship--;
                                        trust++;
                                        rivalry++;
                                        vScary = true;
                                        break;
                                    }
                                case 31:
                                    {
                                        //("...\nWhat do you want to know...+");
                                        script.SwapOp("About you","About your leader");
                                        script.SwapYes("Well you already know a lot but, here we go...\nI was born in the Sink, yeah...\nI was rescued our leader, we survived together for years down there. I had to learn how to survive. And that's what we all did.\nThe ones who didn't, don't make it out.");
                                        script.SwapNo("His name is Hawg, the master head, he plans everything, he gave us the Hunter's signature proceedment: 1. Warning, 2. Anticipation, 3.Hunt, 4. Kill.");
                                        cbrIT3n = 41;
                                        trust++;
                                        break;
                                    }
                                case 41:
                                    {
                                        //"His name is Hawg, the master head, he plans everything, he gave us the Hunter's signature proceedment:
                                        //1. Warning, 2. Anticipation, 3.Hunt, 4. Kill.");
                                        script.SwapDisabled("I already told you too much today.");
                                        trust++;
                                        break;
                                    }



                            }



                        }


                    }
                    if (brID3)
                    {
                        if (brID3y)
                        {
                            switch (cbrIT3y)
                            {
                                case 1:
                                    {
                                        //"Don't even try, I'm not that easily scared.");
                                        script.SwapDisabled("I'm a Killer after all...");
                                        rivalry++;
                                        break;
                                    }



                            }

                            
                        }
                        else
                        {
                            switch (cbrID3n)
                            {
                                case 0:
                                    {
                                        //"I know no one here.+");
                                        script.SwapOp("*Intimidation*", "*Passive Aggresive*");
                                        script.SwapYes("Hey don't try me, I'm capable of taking you down in a milisecond.+");
                                        script.SwapNo("The only people I really interact with are my co-workers.+");

                                        brID3n = true;
                                        cbrID3n = 1;
                                        break;
                                    }
                                case 11:
                                    {
                                        //"...\nI'm not afraid, I didn't want to fight you anyways, I'm kind of tired from work today...");
                                        script.SwapDisabled("You may be lying about your intel, but I don't really care anyways.");
                                        rivalry++;
                                        break;
                                    }
                                case 1:
                                    {
                                        //("The only people I really interact with are my co-workers.+");
                                        script.SwapOp("Who are your co-workers","Why?");
                                        if (FindObjectOfType<GameMaster>().CheckNPC("Trash"))
                                        {
                                            script.SwapYes("See that masked man? The one with red lights... He is Trash.\nI greatly admire him... He never failed any task, no one ever escapes his grasp.\nOh by the way, we are Contract Killers.");

                                        }
                                        else
                                        {
                                            script.SwapYes("He is not here but... Ugh, I don't remember... I think...\nI'm sorry this is strange, I feel like I know a man with a mask, but I can't remember from where...");

                                        }
                                       
                                        script.SwapNo("I just don't want to get attached to anyone, because I'll probably have to kill everyone at some point...\nOh yeah, by the way, I'm a Contract Killer.");
                                        friendship++;
                                        script.SwapDisabled("");
                                        friendship++;
                                        cbrID3n = 2;
                                        break;
                                    }
                                case 2:
                                    {
                                        //"I just don't want to get attached to anyone, because I'll probably have to kill everyone at some p
                                        //oint...\nOh yeah, by the way, I'm a Contract Killer
                                        script.SwapDisabled("Nice talk.");
                                        friendship++;
                                        break;
                                    }
                                



                            }

                        }

                    }
                    if (brFD3)
                    {
                        switch (cbrFD3n)
                        {
                            case 0:
                                {
                                    //("Yeah, maybe for you, but it was easy, it's my job as a Contract Killer, 
                                    //I know it may sound as something cruel, but after all, we kill animals all the time, to consume. Isn't that the same shit?+");
                                    script.SwapOp("Yes", "No");
                                    script.SwapYes("Nice, not that I care what you think about my job any ways...");
                                    script.SwapNo("Demand and offer, it's the same, if you don't know the victim you are free morally, let's put it this way...\nYou are asked to kill a man or a chicken, you HAVE to kill one of them, would you rather kill the man or the chicken+?");
                                    script.SwapDisabled("Left you some food for thought.");
                                    brFD3n = true;
                                    cbrFD3n = 1;

                                    break;
                                }
                            case 1:
                                {
                                    //"Demand and offer, it's the same, if you don't know the victim you are free morally, 
                                    //let's put it this way...\nYou are asked to kill a man or a chicken, which would you kill?"
                                    script.SwapOp("The man","The chicken");
                                    script.SwapYes("I can't argue against that logic...");
                                    script.SwapNo("Heh, get where I'm going?\nNow we take it a step further, you have to choose between a random dude or another random dude but the second one paid you 100$. Easy right?");
                                    friendship++;
                                    cbrFD3n = 2;
                                    break;
                                }
                            case 2:
                                {
                                    //"Heh, get where I'm going?\nNow we take it a step further, you have to choose between 
                                    //a random dude or another random dude but the second one paid you 100$. Easy right?
                                    script.SwapDisabled("My leader can explain it better though...");
                                    vAgreed = true;
                                       
                                    friendship++;
                                    break;
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
            case 3:
                {
                    if (id3)
                    {
                        //script.SwapD("I hate the loud music too, that's why I out here.+");
                        script.SwapOp("*About you*", "*About anyone else*");
                        script.SwapYes("Uhm not telling you anything about me.+");
                        script.SwapNo("I know no one here.+");
                        brID3 = true;

                        break;
                    }
                    else if (fd3)
                    {
                        //script.SwapD("Nah, nothing really important, just killed two important cryptocurrency hackers...+");
                        script.SwapOp("Why?", "That's scary");
                        script.SwapYes("Because a company paid me to do so...\nOh did I not mention I'm a Contract Killer...\nWell my job is really simple, people pay me to kill.");
                        script.SwapNo("Yeah, maybe for you, but it was easy, it's my job as a Contract Killer, I know it may sound as something cruel, but after all, we kill animals all the time, to consume. Isn't that the same shit?+");
                        friendship++;
                        brFD3 = true;
                    }
                    else
                    {

                        //("I don't know,  my life is too complicated to be summarized.");
                        script.SwapF("...\nUh, uhmm...\nI'm Vig.\nDo you really think I look badass?+");
                        script.SwapI("Hilarious, you don't want to mess with me.+");

                    }




                    break;
                }

        }
        SwapFace();


    }
    public void ReplaceTruth()
    {
                                                                                                                                          
        switch (days)
        {

            case 3:
                {

                    if (id3)
                    {
                        //script.SwapT("I am a Contract Killer, I am one of the Hunters, we don't hunt in our city, so don't worry.+");
                        script.SwapOp("So you are a killer","Why not");
                        script.SwapYes("Man, just search our name on the web, we don't accept Contracts in this area. And I'd never kill for free if I get paid for it.+");
                        script.SwapNo("There is another organization operating in this city, a big one too...\nBut the Hunters are better, we just don't want to get the city we live in all dirty.+");
                        brIT3 = true;
                    }
                    else if (fd3)
                    {
                        //("Oh, that's fine, I'm Vig, I'm a Contract Killer... But don't worry, I don't kill people here.\
                        //nStray city is my home and I won't touch anyone here.")
                        trust++;

                    }
                    else
                    {   
                        //script.SwapT("My name is Vig.");
                        script.SwapF("I know I can tell you more.\nI'm a Contract Killer. But I only assasinate people outside this city, and we do it as a pack.+");
                        script.SwapI("Calm down detective, I can take you down in a second+");
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
            case 3:
                {
                    if (dd3)
                    {
                        //script.SwapF("...\nUh, uhmm...\nI'm Vig.\nDo you really think I look badass?+");
                        script.SwapOp("Never seen someone more edgy", "Nah, just kidding");
                        script.SwapYes("Oh... Thank you...\nI don't get that often.+");
                        script.SwapNo("Oh... I see...\nI don't care what you think anyways.+");
                        brBadass = true;
                        script.SwapDisabled("It's okay if you were joking.");


                    }
                    else if (td3)
                    {
                        // script.SwapF("I know I can tell you more.\nI'm a Contract Killer. But I only assasinate people outside this city, 
                        //and we do it as a pack with my leader.+");
                        script.SwapDisabled("Did that scare you off?");
                        script.SwapOp("What do you mean by pack", "Who's your leader.");
                        script.SwapYes("We hunt together. We are the Hunters.\nWe don't kill normal people, we do it in an elegant way. You want our card?+");
                        if (FindObjectOfType<GameMaster>().CheckNPC("Hawg"))
                        {
                            script.SwapNo("Hawg, he is the head of our team. No more questions.");

                        }
                        else
                        {
                            script.SwapNo("Argh...\nMy head hurts... Now that I think about it, I think we don't have a leader, we never did...");

                        }
                        brCK = true;




                    }
                    else
                    {
                        //script.SwapF("...\nYeah, it's been a long night, what's up.");
                        script.SwapS("What's up.");
                        script.SwapD("Nah, nothing really important, just killed two cryptocurrency hackers...+");
                        script.SwapT("Oh, that's fine, I'm Vig, I'm a Contract Killer... But don't worry, I don't kill people here.\nStray city is my home and I won't touch anyone here.");
                        love++;


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
            case 3:
                {
                    if (dd3)
                    {
                        //("Hilarious, you don't want to mess with me.+");
                        script.SwapOp("You'll fear me.", "How's life.");
                        script.SwapYes("No, YOU'll fear me.");
                        script.SwapNo("I won't tell you. You are creepy.");
                        brFear = true;
                        script.SwapDisabled("That's right, fuck off.");
                    }
                    else if (td3)
                    {
                        //script.SwapI("Calm down detective, I can take you down in a second+");
                        script.SwapOp("*Intimidate*", "*Passive Aggresive*");
                        script.SwapYes("Don't make me angry boy+");
                        script.SwapNo("I'm a Contract Killer, you sure you want to mess with me?+");
                        script.SwapDisabled("That's what I thought");
                        rivalry++;
                        brTI3 = true;



                    }
                    else
                    {
                        //script.SwapI("Hey calm down big man, what do you want?");
                        script.SwapS("Huh?");
                        script.SwapD("I hate the loud music too, that's why I'm out here.+");
                        script.SwapT("I am a Contract Killer, I am one of the Hunters, we don't hunt in our city, so don't worry.+");
                        

                    }




                    break;
                }




        }
        SwapFace();
    }



    


}
