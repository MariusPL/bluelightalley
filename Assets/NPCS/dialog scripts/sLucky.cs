using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class sLucky : MonoBehaviour {

    static private bool dd1, dd2, dd3, dd4 , dd5, dd6, dd7 = false;
    static private bool td1, td2, td3, td4, td5, td6, td7 = false;
    static private bool fd1, fd2, fd3, fd4, fd5, fd6, fd7 = false;
    static private bool id1, id2, id3, id4, id5, id6, id7 = false;
    static public int trust, friendship, rivalry, love=0;
    private sNPC script;

    public List<Sprite> NPCface;
    int SwapFaceID;
    public GameObject oNPCface;

    static private bool add, atd, afd, aid;
    private bool ay, an, y, n = false;
    private Queue<string> auxQueue;


    private int days;



    //character variables important

    static private bool badimpr = false;
    static public bool knowname = false;
    static public bool nickname = false;
    static public bool luckyaware = false;
    static public bool exdialogue,exdialogue2, exdialoguef = false;
    static public bool idkyou = false;
    static public bool betrayed = false;
    //variables para sospechar
    private bool branching1, branching2, dcomehere, yuask = false;
    private bool entertainment1, entertainment2, entertainment3, entertainment4 = false;
    private bool daggro, aggro1 = false;
    private bool badexperience,bdyes6,bdno6 = false;
    private bool bnicknamet6, btyes6, btno6 = false;
    private int tyes6, tno6 = 0;
    private bool social = false;
    private int dyes6,dno6 = 0;
    public bool whew = false;



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
        if (days == 3 || days == 4)
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
                    script.SwapS("Heyy,\nHow's the night?");
                    script.SwapD("Oh, I'm Lucky, I think I'm a bit drunk. Just like me father used to be at home.\nI remember, thanks to that I grew to reject alcohol.\nBut I love drugs.\nWell not 'love', like I mean, maybe I like it...?\nUh.\nI don't actually like drugs anymore.");
                    script.SwapT("Nice one, so funny.\nYou do kñlook like a detective though, so I'll roleplay with you.\n I'm Lucky, I'm 24, that's all you get!\nNo, really, that's what I would say to a real detective.");
                    script.SwapF("\nSo sweet!\n I like you too man");
                    script.SwapI("\nSo funny!\nI almost fell for that, I thought you were really angry.");
                    script.SwapDisabled("*She's kind of irresponsive right now*");
                    if (knowname)
                    {
                        script.SwapD("Well look, I'm a bit drunk, just a little bit. I think the pills didn't mix well with the alcohol.\nBut hey, I'm having a good time.");
                        script.SwapT("Oh the case of course, I think I'm too drunk to help you with that, I'm sorry. If I see activity I'll let you know detective.");
                        script.SwapF("You just wanna take me home with you right? Ha! Too bad you can't because I'm drunk, and therefore I'm not a hundred percent conscious, and that would be rape.");
                        script.SwapDisabled("How about you take me home tonight, that would be great.");
                    }
                    break;
                }

            case 1:
                {
                    script.SwapS("Oh well, it's the detectivee...");
                    script.SwapD("Yes detective, no, I'm not having fun, like I totally didn't not drink anything alcoholic.\nYou can´t arrest me, you have no proof.");
                    script.SwapT("Yes, of course I will help you. My name is Lucky, I'm not drunk and I don't like hanging out with people, I don't really know anyone here, so, is that enough?");
                    script.SwapF("A detective flirting with me? I feel... confused?\nOh right, you just want to steal information from me. Nevermind.");
                    script.SwapYes("???");
                    script.SwapNo("LOL");
                    script.SwapI("\nSo funny!\nI almost fell for that, I thought you were really angry.");
                    script.SwapDisabled("*She's kind of irresponsive right now*");
                    if (knowname)
                    { }
                    break;
                }
            case 2:
                {
                    script.SwapS("Heyy.\nHow's the night?");
                    script.SwapD("OH come on! I know you're not trying to be my friend, I've seen you around, flirting with people. That's all you do, fuck boy.\nI'm just kidding, don't take me too seriously.");
                    script.SwapT("Is this your new pick up line? I've gotta say it's suuper lame, like I don't even believe it. Maybe try with a compliment or something.");
                    script.SwapF("I won't fall in your trap, I'm not that easy, I know you flirt with anyone, and I don't like people like you.");
                    script.SwapI("You're so funny, I almost fell for that, I thought you were really angry.");
                    script.SwapYes("???");
                    script.SwapNo("LOL");
                    script.SwapDisabled("*She's kind of irresponsive right now*");
                    if (knowname)
                    { }


                    break;
                }

            case 3:
                {
                    script.SwapS("It's you, I've seen you around, fuck off.");
                    script.SwapD("I...I don't like you, you like to scare people around. You won't scare me man. I'm not afraid, I'll never be.");
                    script.SwapT("Is this part of your intimidation process? Get the fuck out of my face.");
                    script.SwapF("I think aggressiveness is fucking hot, but not on you.");
                    script.SwapI("I'm not scared, do whatever you want, come on.\nI know you won't do shit because you're such a fucking pussy. Look at me, I feel all mysterious hiding under my hat and treating people like shit. Fuck off, I'm not scared.");
                    script.SwapYes("???");
                    script.SwapNo("LOL");

                    script.SwapDisabled("*She's kind of irresponsive right now*");
                    if (knowname)
                    { }


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
    
    void Start () {
        script = transform.GetComponent<sNPC>();
        days = GameMaster.daycount;
        dd1 = false; add = dd1; dd2 = dd1; dd3 = dd2; dd4 = dd3; dd5 = dd4; dd6 = dd5; dd7 = dd6;
        td1 = false; atd = td1; td2 = td1; td3 = td2; td4 = td3; td5 = td4; td6 = td5; td7 = td6;
        fd1 = false; afd = fd1; fd2 = fd1; fd3 = fd2; fd4 = fd3; fd5 = fd4; fd6 = fd5; fd7 = fd6;
        id1 = false; aid = id1; id2 = id1; id3 = id2; id4 = id3; id5 = id4; id6 = id5; id7 = id6;
        SwapFaceID = 0;
        Debug.Log("STARTS");
        //les convers xD
        //friday
        
        StartingM();
        
        




    }

    // Update is called once per frame
    void Update () {


        Debug.Log("lucky love: " + love);
        Debug.Log("lucky friendship: " + friendship);
        Debug.Log("lucky trust: " + trust);
        Debug.Log("lucky rivalry: " + rivalry);
        CheckChange();
        if (script.daychanged)
        {
            Debug.Log("SDSDFSDFSDF");
            CheckNPCDay();
            script.daychanged = false;
            StartingM();
            


        }
        if (script.frs)
        { SwapFace();script.frs = false; }
        if (script.FaceChangeInText)
        {
            SwapFaceID = script.FaceChangeInTextID;
            script.FaceChangeInText = false;
            SwapFace();
        }

    }

    private void Yes() {
        Debug.Log("days" + days);
        switch (days)
        {
            
            case 1:
                {
                    if (idkyou)
                    {
                        social = true;
                    }

                    break;
                }

            case 2:
                {
                    if (!dcomehere)
                    {

                        if (friendship == 3 && love == 3 && !branching1 && !branching2)
                        { //totally you're cool im starting to like you. you come here everyday?
                            script.SwapDisabled("¡2Hey maybe in another life, or parallel universe, where you were a criminal like me, we could get along.\nLike be a couple or something.");

                            script.SwapOp("Yeah, everyday", "Nah, only when I feel like it.");
                            script.SwapYes("¡5Oh, that's weird I think? Why would you do that, like you don't have anything better to do?+");
                            script.SwapNo("¡2That's cool, I just come here after work...\nWell I mean I don't have a job, but I have jobs to do.ç");
                            branching1 = true;

                        }
                        else if (friendship == 3 && love == 3 && branching1 && !branching2)
                        { //yeah everyday - wtf u dont have anything better to do?
                            social = true;
                            script.SwapOp("I really like coming here to meet people", "This place is just relaxing for myself");
                            script.SwapYes("¡5REALLY? ¡3I don't believe you, you look like a dealer, only people like me would like to get to know you.\n¡2I'm just kidding.\nEven I was scared at first.");
                            script.SwapNo("¡3Exactly! That's how I feel, I just feel so happy here I don't know why, ¡2I don't even socialize with anyone, you're like the second person to talk to me.\n¡0The first one was the bartender.");
                            branching2 = true;

                            script.SwapDisabled("¡0If I were you I'd go to a better bar, not this crappy one. Expensive crappy bar.");

                        }
                        else if (friendship == 3 && love == 3 && branching1 && branching2)
                        {

                            script.SwapDisabled("¡3Nah, you're fine, I'm kidding, ¡2I told you I like you.");
                            dcomehere = true;

                        }
                    }
                    else if (yuask)
                    {
                        script.SwapDisabled("¡5Let's keep this relationship more distant. The less we know about each other the better i think.");
                        trust++;
                        yuask = false;
                    }
                    if (nickname)
                    {

                        if (entertainment1)
                        {
                            script.SwapDisabled("¡2But I like it here, it's chill and I feel happy, I don't even know why.");
                            script.SwapOp("Tell me more", "-");
                            script.SwapYes("¡1Hey what is this an interrogation? Why do you care so much. I won't tell you.");
                            entertainment1 = false;
                            entertainment2 = true;

                        }
                        else if (entertainment2)
                        {
                            script.SwapDisabled("¡1Now I'm suspecting your intentions. ¡5Did the Boss send you here?+");
                            script.SwapOp("What Boss? I'm confused", "Calm down, I'm just befriending");
                            script.SwapYes("¡6I'm sorry, I think I'm a bit paranoid. Just ignore me please, I'm having a bad week. And it's just Tuesday.");
                            script.SwapNo("¡1Fuck you I don't believe you.\n...¡6\nI'm sorry, I just...\nI know I'm being paranoid, I know you're not sent by them. ¡0Don't think I'm crazy please.+");
                            entertainment3 = true;
                            entertainment2 = false;

                        }
                        else if (entertainment3)
                        {
                            //i know im a bit paranoid

                            script.SwapDisabled("¡6I'm so sorry, ¡0talk to you tomorrow.");
                            entertainment3 = false;
                        }
                        else if (entertainment4)
                        {
                            script.SwapDisabled("¡0I'll be fine by tomorrow.");
                            friendship++;
                            entertainment4 = false;

                        }
                        else
                        {
                            //nice, cuz im bored as hell

                            script.SwapDisabled("¡2Everyone is just so average here...");
                        }


                    }


                    if (!daggro)
                    {
                        if (aggro1)
                        {
                            script.SwapDisabled("¡1That was like the worst excuse possible. Now I think you're over confident and toxic.");
                            friendship--;
                            rivalry++;
                            daggro = true;
                            badimpr = true;

                        }

                    }






                    if (friendship == 2 && rivalry == 1)
                    { script.SwapDisabled("¡6Yeah, somehow I thought I needed him in my life you know, maybe he made me feel less of a shit.\n¡0When the relationship is toxic, you don't see it at first."); }

                    if (!exdialoguef)
                    {
                        if (exdialogue)
                        {

                            script.SwapOp("Why not? tell me", "-");
                            script.SwapYes("¡6I just don't feel like it, everytime I think of him I just want to kill myself.\nLike not literally, but you get me, that feeling of embarrassment mixed with regret, makes me want to punch myself in the face.");
                            exdialogue2 = true;
                            exdialogue = false;
                        }
                        else if (exdialogue2)
                        {

                            exdialoguef = true;
                        }
                    }




                    break;
                }


            case 6:
                {
                    if (badexperience)
                    {

                        Debug.Log("badexp");
                        if (bdno6)
                        {
                            switch (dno6)
                            {
                                case 1:
                                    {
                                        //Thonolium, the benzos. They're for anxiety and recreational use.
                                        script.SwapOp("You shouldn't be taking drugs.", "-");
                                        script.SwapYes("¡6It's none of your concern Hatman, they may not be great for my body, but they are good for my mind.\n¡0Also anyone takes drugs nowadays.");
                                        dno6 = 11;
                                        break;
                                    }
                                case 11:
                                    {
                                        break;
                                    }



                            }

                        }
                        else
                        {
                            switch (dyes6)
                            {
                                case 0:
                                    {
                                        Debug.Log("case 0");
                                        //¡3Fuck you man,¡0 I actually didn't want to drink, but it happened anyways.\n¡5I guess doped up Lucky isn't that smart.ç
                                        script.SwapOp("What drugs did you take", "-");
                                        script.SwapYes("¡5You mean what drugs do I take?\n¡0Thonolium, the benzos.+");
                                        script.SwapDisabled("Doped up Lucky always fucks up.");
                                        dyes6 = 1;
                                        bdyes6 = true;
                                        break;
                                    }

                                case 1:
                                    {
                                        //"¡5You mean what drugs do I take?\n¡0Thonolium, the benzos.ç"
                                        script.SwapOp("Stop taking those pills", "What do they do?");
                                        script.SwapYes("¡0I've got an addiction man, too late. ¡5What are you against drugs?+");
                                        script.SwapNo("¡0Well, like any other benzo they are anti anxiety and panic dissorders, ¡3hey, it's one of the most common drugs out there, how come you didn't know about it.\n¡2Not to be rude, but do you have any friends?+");
                                        script.SwapDisabled("How come you don't know about Thonolium.");
                                        dyes6 = 2;
                                        break;
                                    }
                                case 21:
                                    {
                                        //"¡3Well, ¡2maybe people you have a normal conversation with?");
                                        script.SwapOp("I've got a lot", "I've got enough");
                                        if (social)
                                        { script.SwapYes("Makes sense, you seems kind of social I guess, like smooth."); }
                                        else
                                        { script.SwapYes("¡3Are you kidding? ¡2I thought you were kind of antisocial."); }

                                        script.SwapNo("¡5That's an interesting answer, Me too, I've got the ones I can trust, any other hater or toxic person who doesn't add into my life is automatically discarded.");
                                        break;
                                    }
                                case 2:
                                    {
                                        //¡0I've got an addiction man, too late. ¡5What are you against drugs?+
                                        script.SwapOp("They should be illegal", "Just worried about you.");
                                        script.SwapYes("¡5Wow man, come on, you know that if it were illegal everyone would continue to consume them, that's why it was legalized in the first place...\nIllegal.. ¡2That's a really comunist thing to say.+");
                                        script.SwapNo("¡2Hey, don't worry about me, the less people you care about, the happier you are, so forget about me, specially me, ¡0I'm not realiable.+");
                                        dyes6 = 3;
                                        break;
                                    }
                                case 31:
                                    {

                                        break;
                                    }
                                case 3:
                                    {
                                        //¡5Wow man, that's some real dinosaur crap, come on, you know that if it were illegal everyone would continue to consume them, 
                                        //that's why it was legalized in the first place...\nIllegal.. ¡2That's a really comunist thing to say.+
                                        script.SwapOp("People should follow the law, it's for their own good.", "Everyone should do what they want, but drugs affect everyone.");
                                        script.SwapYes("¡0You sound like someone from the past century or whatever, we're like, luckily, already beyond that. Wouldn't want to go back to censorship and all that shit.\n¡2I think you've got your point though.");
                                        script.SwapNo("Yes and no, who are you to decide if someone can or can't take pills, like, nevermind, I've got your point anyways.");
                                        dyes6 = 4;
                                        break;
                                    }
                                case 4:
                                    {
                                        //You sound like someone from the past century or whatever, we're like, luckily, already beyond that. 
                                        //Wouldn't want to go back to censorship and all that shit.\nI think you've got your point though
                                        script.SwapDisabled("¡2Hey you really made me feel better.");


                                        break;
                                    }

                                default:
                                    {

                                        print("error, dyes6 case out of range.");
                                        break;
                                    }


                            }
                        }





                    }
                    else if (bnicknamet6)
                    {
                        switch (tyes6)
                        {
                            case 0:
                                {
                                    //¡5...\nAre you telling me you -\n¡1I see what you did there, you were, you, never really had the intention of befriending me right? 
                                    //You just tried to get closer, and closer, to collect information right ? +
                                    script.SwapOp("It's not what it seems", "You wouldn't have told me anything");
                                    script.SwapF("¡1Man, don't even try, we're done here Detective.");
                                    script.SwapS("¡1Don't talk to me.");
                                    script.SwapYes("¡1Of course it's not, apparently, nothing you do is what it seems, fuck you man,¡6 and I thought for a second you were becoming a good friend.¡1 Fuck you.");
                                    script.SwapNo("¡1Oh now it's my fault? You know what? I won't even bother talking to you Detective, fuck off. ¡1You played with my feelings.");
                                    tyes6 = 1;
                                    btyes6 = true;

                                    break;
                                }
                            case 1:
                                {
                                    //¡1Of course it's not, apparently, nothing you do is what it seems, fuck you man,¡6 and I thought for a second you were becoming a good friend.¡1 Fuck you."
                                    
                                    script.SwapF("¡1Man, don't even try, we're done here Detective.");
                                    script.SwapI("¡1Okay, fuck you, fuck you man.\nMy name is Lucky, I'm actually 22. I'm a fucking prostitute. You wanted me to say it out loud? There you have it. Now do what you want with that information, Weird hat.");
                                    script.SwapS("¡1Don't talk to me.");
                                    luckyaware = true;

                                    break;

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


        switch (days)
        {
            case 1:
                {
                    if (idkyou)
                    {

                        ;
                    }

                    break;
                }
            case 2:
                {
                    if (!dcomehere)
                    {
                        if (friendship == 3 && love == 3 && !branching1 && !branching2)
                        {
                            script.SwapDisabled("¡3You don't have a sense of humour don't you");


                        }
                        else if (friendship == 3 && love == 3 && branching1 && !branching2)
                        {
                            script.SwapOp("What jobs?", "-");
                            script.SwapYes("¡5Hey why do you care so much, It's nothing important.");
                            yuask = true;
                            script.SwapDisabled("¡2I wish I didn't have to do anything doe.");
                            dcomehere = true;

                        }

                    }



                    if (nickname)
                    {

                        script.SwapDisabled("¡0You get me.\n¡2I don't come here for entertainment.ç");
                        script.SwapOp("Then why do you come here?", "");
                        script.SwapYes("You know, work related stuff, nothing really important.ç");
                        entertainment1 = true;
                        if (entertainment3)
                        {

                            script.SwapDisabled("¡6Talk to you tomorrow... Leave me alone please.");
                            script.SwapOp("It's okay, don't worry, I understand.", "Yeah don't be such a bitch");
                            script.SwapYes("¡6Thanks for understanding.\n¡6I'm not usually like this.");
                            script.SwapNo("...");
                            entertainment4 = true;
                            entertainment3 = false;
                            entertainment1 = false;
                        }
                        else if (entertainment4)
                        {

                            script.SwapDisabled("...");
                            friendship = 0;
                            love = 3;
                            betrayed = true;
                            nickname = false;
                            entertainment4 = false;

                        }

                    }
                    if (friendship == 2 && rivalry == 1)
                    { script.SwapDisabled("¡6I'm happy I finally took the courage to leave him though. That's actually the reason I came to this city, to escape from him."); }
                    if (!daggro)
                    {
                        if (aggro1)
                        {

                            script.SwapDisabled("¡3That's why I come to this bar, to not talk to anyone and feel less of a shit\n¡2With my cigs.");
                            friendship++;
                            daggro = true;
                        }

                    }



                    break;

                }

            case 6:
                {
                    if (badexperience)
                    {
                        if (bdyes6)
                        {
                            switch (dyes6)
                            {
                                case 2:
                                    {
                                        //Well, like any other benzo they are anti anxiety and panic dissorders, ¡3hey, it's one of the most common drugs out there,
                                        //how come you didn't know about it.\n¡2Not to be rude, but do you have any friends?
                                        script.SwapOp("Define 'friends'", "I don't need friends");
                                        script.SwapYes("¡3Well, ¡2maybe people you have a normal conversation with, or people you can trust?+");
                                        script.SwapNo("¡2That's so edgy, I agree though. Who needs friends anyways. I rather be alone than be surrounded by fake people.");
                                        script.SwapDisabled("I was joking about the friends thing man.");
                                        dyes6 = 21;
                                        break;
                                    }
                                case 21:
                                    {


                                        script.SwapDisabled("I hate people who fake their emotions.");
                                        break;
                                    }
                                case 3:
                                    {//Hey, don't worry about me, the less people you care about, the happier you are, so forget about me, specially me, ¡0I'm not realiable.+

                                        script.SwapOp("I really care about you", "No one is realiable");
                                        script.SwapYes("¡2Don't. Stop... ¡0Don't make me, uh, don't say that you care about me, because, first of all you'll be dissapointed, and, ¡6second of all, you'll start, like, if you care about me I'll start caring about you.\nAnd you know how that ends, you'll stop caring about me, and I'll have to learn to live on, like, I don't know if you understand me.\n...\n¡0Please don't give me somthing I didn't ask for.");
                                        script.SwapNo("But like if there was a ranking of unreliable people who will dissapoint you, I would be ¡3like, maybe, runner up.¡0");
                                        dyes6 = 31;
                                        break;
                                    }
                                case 31:
                                    {

                                        break;
                                    }
                                case 4:
                                    {
                                        //Yes and no, who are you to decide if someone can or can't take pills, like, nevermind, I've got your point anyways.


                                        break;
                                    }







                            }



                        }
                        else{
                            switch (dno6)
                            {
                                case 0:
                                    {
                                        //Yeah I know, I shouldn't be doing that, I guess doped up Lucky isn't that smart. Sad thing is I've grown a dependency on these pills.+
                                        script.SwapOp("What pills", "Just get help");
                                        script.SwapYes("Thonolium, the benzos. They're for anxiety and recreational use.ç");
                                        script.SwapNo("It's not that easy man, if it were like 'just get help' type situation I wouldn't still be addicted. Long story short, they make me forget about how much reality sucks.+");
                                        dno6 = 1;
                                        bdno6 = true;
                                        break;
                                    }

                                case 1:
                                    {
                                        //It's not that easy man, if it were like 'just get help' type situation I wouldn't still be addicted. Long story short, the pills make me forget about how reality sucks.+
                                        script.SwapOp("Stop escaping reality","It's fine just don't harm yourself");
                                        script.SwapYes("¡5What do you mean, life sucks, reality sucks, and I don't wanna be like everyone investing more time in VR, ¡2I like to confront reality! I like how it makes me feel angry or sad, and taking breaks from that, with Thonolium, that's how I feel alive");
                                        script.SwapNo("¡2Don't worry about me, don't care about me, the less you care the happier you are.\nI'm fine, and if you become attached to me, you'll only be dissapointed.");
                                        dno6 = 2;
                                        break;
                                    }
                                case 2:
                                    {
                                        //Don't worry about me, don't care about me, the less you care the happier you are.\nI'm fine, and if you become attached to me, you'll only be dissapointed.
                                        script.SwapOp("But I care about you", "It's for your own good");
                                        script.SwapYes("¡0Just don't...¡6Please.\n¡0I'm not someone you should care about.");
                                        script.SwapNo("¡2Yeah I know, but I know what's good for me. Thanks anyways. ¡3I think you're a great man, ¡2But I don't like people taking care of me.");
                                        dno6 = 3;

                                        break;
                                    }


                            }
                           
                            
                        }

                    }
                    else if(bnicknamet6)
                    {
                        if (btyes6)
                        {
                            switch (tyes6)
                            {
                                case 1:
                                    {
                                        //¡1Oh now it's my fault? You know what? I won't even bother talking to you Detective, fuck off. ¡1You played with my feelings."
                                        //¡1Of course it's not, apparently, nothing you do is what it seems, fuck you man,¡6 and I thought for a second you were becoming a good friend.¡1 Fuck you."
                                        script.SwapDisabled("*She's ignoring you.*");
                                        script.SwapF("Man, don't even try, we're done here Detective.");
                                        script.SwapI("Okay, fuck you, fuck you man.\nMy name is Lucky, I'm actually 22. I'm a fucking prostitute. You wanted me to say it out loud? There you have it. Now do what you want with that information, Weird hat.");
                                        script.SwapS("Don't talk to me.");
                                        luckyaware = true;
                                        break;

                                    }



                            }


                        }
                        else
                        {
                            switch (tno6)
                            {
                                case 0:
                                    {
                                        
                                        script.SwapF("¡2How are you even in the mood man. ¡0Go do your thing, I'm here all night anyways, it's ok.\n I knew you were a detective, like I was thinking, is Cool Hat a detective or a dealer.");
                                        script.SwapI("¡8I won't kill anyone hey, calm down, ¡0I'm not aggressive. You know I'm the chill type.");
                                        script.SwapDisabled("I'll let you know if I see anything suspicious.");
                                        btno6 = true;
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
                    if (rivalry == 0)
                    {

                        script.SwapS("¡2You need anything?");
                        script.SwapF("¡0Oh... Ehm sorry, not intersted I guess? I mean, As I said, I don't know you man.+");
                        script.SwapOp("This is how we get to know each other","I don't know you too");
                        idkyou = true;
                        script.SwapYes("So smooth, but I'm not in the mood today, thanks.¡2");
                        script.SwapNo("¡3That doesn't even make sense, ¡2like... Nevermind, ¡0I'm not in the mood today, I... Something happened and I'm not feeling well.\nIt's not about you, just don't bother me right now please.");
                        script.SwapDisabled("I don't even know you yet. Maybe if we talk again and I still remember you.\n¡3Just kidding, of course I will remember your hat.\n¡2In a non sexual way obviously.");
                        friendship++;

                    }
                    else if (rivalry == 1)
                    {

                        script.SwapDisabled("¡0Besides you were so aggresive.");
                        friendship=0;
                    }
                    
                    break;

                }
            case 2:
                {
                    if (love + friendship + rivalry + trust == 0)
                    {
                        ;


                    }
                    else if (love + friendship == 2 && rivalry==0)
                    {   knowname = true;
                        script.SwapDisabled("¡3How's the night, Weird hat?+");
                        script.SwapOp("Nice!", "Kind of boring");
                        script.SwapYes("¡0Good for you.\n¡2Cause I'm bored as hell.");
                        script.SwapS("¡2I'm in a good mood tonight.");
                        script.SwapF("¡2Thanks, what's yours?\n¡0...\nNevermind, I'll just call you weird...¡5 hat?\nThat's kind of lame...\n¡2I'll stick with it.");
                        script.SwapNo("Nice, I'm bored as hell too.");
                        nickname = true;
                    }
                    else if (love == 1 && knowname == true && friendship == 0)
                    {

                        script.SwapF("¡2Thanks, what's yours?\n¡0...\nNevermind, I'll just call you weird...¡5 hat?\nThat's kind of lame...\n¡2I'll stick with it.");
                        script.SwapDisabled("How's the night, Weird hat?+");
                        script.SwapOp("Very good", "Kind of boring");
                        script.SwapYes("¡0Good for you.\n¡2Cause I'm bored as hell.");
                        script.SwapS("¡2I'm in a good mood tonight.");
                        script.SwapNo("¡3Nice, I'm bored as hell too.¡2");
                        love = 3; friendship = 2;
                        nickname = true;
                    }


                    else if ((love + friendship < 1) && trust == 0)
                    {

                        script.SwapS("¡1I don't know what you are trying to get from me.");
                        script.SwapF("¡1You're not funny man. ¡0I prefer friendly people.");
                        script.SwapDisabled("*She tries to ignore you*");
                        friendship++;
                    }
                    else if (love == 2 && knowname)
                    {

                        script.SwapDisabled("¡2That's life.");
                        love = 3; friendship = 3;
                        script.SwapOp("What a dick", "That's not funny at all");
                        script.SwapYes("Totally.\nYou're cool, I'm starting to like you.\nYou come here everyday?+");
                        script.SwapNo("No shit genius, I was just messing around.\nLike of course that's not funny, like. Nevermind.");

                    }
                    else if (love == 0 && friendship == 1)
                    {

                        script.SwapS("¡0Whatsup.");
                        script.SwapF("¡5...\nYou didn't have the balls yesterday and spent all night regretting not talking to me?");
                        script.SwapDisabled("¡2Well you did it congratulations!");
                        friendship = 2;
                    }
                    else if (rivalry == 1 && trust == 0 && love == 0 || rivalry == 2 && trust == 0 && friendship == 0)
                    {

                        script.SwapF("¡1What?\nREALLY weird man.\nSorry, not interested");
                        script.SwapDisabled("¡0Someday you'll find someone.");
                        friendship = 2;
                        love = 1;
                    }
                    else if (rivalry == 1 && (love == 1 || friendship == 1))
                    {

                        script.SwapDisabled("¡0Except for my ex, he has green eyes...\n...and he's a tall man.\n¡2Maybe that's why we broke up?+");
                        script.SwapOp("Definitely", "I don't think that was the reason.");
                        script.SwapYes("¡3You're funny, I like you...\n¡2Yeah we broke up because of a lot of things, but I don't really feel like talking about it.¡0ç");
                        exdialogue = true;
                        script.SwapNo("¡3Well, no shit it wasn't that, ¡2I was just messing around.");

                        friendship = 2;
                    }
                    else if (rivalry == 1 && trust == 1 && love == 0)
                    {

                        script.SwapDisabled("¡1Stop talking to me detective.");
                        rivalry = 2;

                    }
                    else if (rivalry == 2 && friendship == 1 && love == 1)
                    {

                        script.SwapDisabled("¡1Totally not funny.");
                    }
                    else if (trust == 1)
                    {
                        //dont try to fool me, what kind of lame detective are you

                        script.SwapDisabled("¡1Stop talking to me detective.");

                    }

                    
                    break;

                }

            case 6:
                {
                    if (nickname)
                    {
                        //"¡6Welp, I'm feeling like shit, I can't remember what happened last night...\nUghh, my head hurts, I'll never mix those pills with alcohol again.+"
                        script.SwapOp("Don't let one bad experience ruin another", "Be more careful");
                        script.SwapYes("¡2Fuck you man,¡0 I actually didn't want to drink, but it happened anyways.\n¡5I guess doped up Lucky isn't that smart.ç");
                        script.SwapNo("¡0Yeah I know, I shouldn't be doing that, I guess doped up Lucky isn't that smart. Sad thing is I've grown a dependency on these pills.+");
                        script.SwapF("¡2I think I look like shit, like I didn't even do my hair today.\n¡3Well I never do my hair, that's why I wear this beanie.");
                        script.SwapI("Hey you're being kind of aggresive right now, what's wrong?");
                        script.SwapS("¡2By keeping me entertained, you make me forget about the headache.");
                        badexperience = true;
                        friendship = 10;


                    }
                    else if (betrayed)
                    {
                        //6Well I'm doing fine. ¡0You're kind of toxic, I don't want to talk to you."
                        script.SwapS("¡6I shared a deep feeling of mine. I shouldn't have done that.¡0");
                        script.SwapF("¡0Please don't. I told you man...\n¡6I don't even know why, you remind me of someone, and that person made me feel worthless.");
                        script.SwapI("!!!!¡7\nHow do you know about that! ¡1You fucking-\nYou scare me man, what do you want, please stop following my life.+");
                        
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
            case 1:
                {
                    if (love ==1)
                    {
                        script.SwapDisabled("¡1You could've said that first, I'm sick of people pretending to befriend me only to find out there was a second intention all along.");
                        trust = 1;
                        love = 0;
                        luckyaware = true;
                        Debug.Log("luckyaware");


                    }
                    else
                    {
                        script.SwapI("¡1Fine, if you wanna just arrest me for no reason, then go ahead, I'll make your day.");
                        script.SwapF("¡1Not cool man, you really think I'm dumb.\nI know your intentions, don't talk to me that way.");
                        trust = 1;
                        script.SwapDisabled("¡1I hate you people.");
                        script.SwapS("¡1I'm not the one you're looking for I'm sure.");

                    }
                        
                    

                    break;
                }
            case 2:
                {
                    if (trust == 1 && !id1)
                    {
                        script.SwapS("¡1Why do you keep talking to me? I don't want you near me.");
                        love = 0; friendship = 0; rivalry = 1;

                        trust = 2;


                    }
                    else if (love + friendship > 1 && !id2)
                    {
                        script.SwapS("¡8Interesting...");
                        script.SwapF("¡3You're funny.\nHow do you have the mood to flirt when a crime is happening.\n¡2Oh nevermind, I got it, that's how you usually talk to girls right?");
                        script.SwapI("¡5Oh, now you're threatening me?\nI'm not afraid of you, go away, I'm not the one you're looking for.+");
                        luckyaware = true;
                        trust = 1;

                    }
                    else if (trust == 0 && !dd1 && !fd1)
                    {

                        script.SwapS("¡8Interesting...");
                        trust = 1;

                    }
                    else if (td1 && id1 && id2)
                    {
                        script.SwapDisabled("Don't bother me again. I've had enough this week.");
                        trust = 2;


                    }
                    else if (fd1 && dd1 && id2)
                    { //(friendship == 1 && rivalry == 2)
                        //"¡0Oh...\nYeah it makes sense. A detective getting information by manipulating emotions, ¡5how did I not see that in you.+");
                        script.SwapOp("Let's focus on the task", "I'm sorry");
                        script.SwapYes("Yeah no, you won't persuade me so,¡0 no thanks.");
                        script.SwapNo("You know that's fucking rude, I'm done with fake friendships. I thougt we were getting along.");
                        script.SwapDisabled("I wouldn't kill anyone.");
                        luckyaware = true;
                        trust ++;
                    }

                    break;
                }

            case 6:
                {
                    if (nickname)
                    {//What? And you're just telling me now? When did you find out about this!
                        script.SwapOp("Before we even met", "Just now");
                        script.SwapDisabled("Good luck on your case man.");
                        
                        script.SwapYes("¡5...\nAre you telling me you-\n¡1I see what you did there, you were, you, never really had the intention of befriending me right? You just tried to get closer, and closer, to collect information right?+");
                        script.SwapNo("¡5Oh no, this is terrible.\n If I see anything suspicious I'll let you know.");
                        script.SwapF("¡0That's too cheesy man, ¡2I cringed so hard,¡1 I thought the case thing was real for a second. You really got me there.");
                        script.SwapI("¡0No, don't do that alright.But, ¡1What the fuck Hatman. ¡0Okay, I don't know, I've been drunk yesterday, I don't remember anything.");
                        bnicknamet6 = true;
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
            case 1:
                {
                    if (trust == 1)
                    {

                        luckyaware = true;
                        script.SwapDisabled("¡1I Don't like you.");
                    }
                    else if (friendship == 1)
                    {
                        script.SwapDisabled("¡2I like your coat though. You look like some kind of dealer.");
                        

                        love = 1;

                    }
                    else
                    {
                        if (FindObjectOfType<GameMaster>().CheckNPC("Tristan Glidewave"))
                        { script.SwapS("Well he isn't but you scared me with that direct approach."); }
                        else
                        {
                            script.SwapS("¡0What's up.");
                        }

                        script.SwapDisabled("¡0You're weird.");
                        script.SwapD("¡5My name?\nI kind of want to tell you but I'm not used to telling strangers my name. For security reasons of course.\n¡0Not that I'm a wanted criminal or anything, but you know.");
                        script.SwapT("¡1Agh I see. what did I expect.\nGod I'm stupid. No, I won't contriubute to your case, thanks, bye.");
                        love = 1;
                        
                    }
                    
                    


                    break;
                }
            case 2:
                {
                    if (love + friendship == 2)
                    {
                        knowname = true;
                        script.SwapS("Come on.\n¡2I'm in a good mood tonight.");
                        script.SwapD("¡0Yeah I know, a strange name... My dad gave it to me, he told me his life was shit before me. I was his 'Lucky charm' and wherever he went he'd keep me with him.\n¡2Funny how he ended up abandoning me not long after.+");
                        friendship = 3; love = 2;

                    }
                    else if (knowname && friendship==1)
                    {
                        
                        script.SwapDisabled("¡2Weird right?");
                        friendship = 3; love = 2;
                    }
                    if (trust == 1 && rivalry == 1)
                    {
                        script.SwapS("¡1Go away.");
                        script.SwapDisabled("¡1Stop creeping on me I won't help you, there's more people in this bar you know.");
                        love = 0;

                    }
                    else if (rivalry == 1 && trust == 0 && friendship == 0)
                    {
                        script.SwapS("¡0Are you gonna make a pun about my name again?");
                        script.SwapDisabled("¡3That Lucky pun was too lame.");
                        script.SwapD("¡0How's the night?\nFine I guess, had better, had worse.\n¡2I remember the worst night of my life, I was like 9 and this weird big guy with green eyes scared the shit out of me, so now I'm scared of green eyed folks.");
                        love = 1;


                    }
                    else if (trust == 1 && love + friendship > 1)
                    {
                        script.SwapDisabled("¡3I was just kidding");
                        love = 2;

                    }
                    else if (rivalry == 1 && friendship == 1)
                    {
                        script.SwapDisabled("¡5Why were you so aggressive yesterday. ¡0At least you were friendly today.+");
                        script.SwapOp("That's how I roll", "I'm sorry, I was having a bad day");
                        script.SwapYes("¡5What a douche...You're just like my ex. \n¡1You can't just roll like that. I mean, nevermind, keep rolling.");
                        script.SwapNo("¡0I see...\nIt's okay man, don't worry. I understand you.\n¡2We're on the same boat, sometimes I treat people like shit and I don't even mean it.\n¡6It's like, whenever I let my brain get into my body I fuck things up, with people. ¡0So i know how you feel.");
                        aggro1 = true;
                    }
                    else if (rivalry == 2)
                    {

                        luckyaware = true;
                    }

                    


                    break;
                }

            case 6:
                {
                    if (nickname)
                    {
                        if (bnicknamet6)
                        { //0That's too cheesy man, ¡2I cringed so hard,¡1 I thought the case thing was real for a second. You really got me there.
                            script.SwapDisabled("¡2Don't joke about those things.");
                            whew = true;
                            if (btyes6)
                            {
                                //Man, don't even try, we're done here Detective.
                                love = 0;
                                friendship = 0;
                                script.SwapDisabled("¡1*She's ignoring you.*");
                            }
                            else if (btno6)
                            {
                                //script.SwapF("¡2How are you even in the mood man. ¡0Go do your thing, I'm here all night anyways, it's ok.");
                                script.SwapDisabled("¡0Good luck on your case Cool Hat.");

                            }

                        }
                        else if (dd6)
                        {
                            //script.SwapF("¡2I think I look like shit, like I didn't even do my hair today.\n¡3Well I never do my hair, that's why I wear this beanie.");
                            script.SwapDisabled("¡2Is that why you wear that cool hat?");
                        }


                    }
                    else if (love == 5)
                    {
                        //script.SwapF("¡0Wait.\n¡8Hey, now that I think about it... Did we go to your place last night?+");
                        script.SwapOp("Yes","No");
                        script.SwapYes("");
                        script.SwapNo("");

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
            case 1:
                {
                    
                        rivalry = 1;
                    friendship = 0;
                        script.SwapDisabled("¡1Go seek someone else's trouble.");
                        script.SwapS("¡1Gonna threaten me again?");
                    script.SwapT("¡5Ohhhh so you are a Detective?\n¡1More reasons to hate you.");


                    break;
                }
            case 2:
                {
                    
                    if (trust==1 && !id1)
                    {
                        script.SwapS("¡1Fuck off");
                        script.SwapF("¡1You're not funny man.");
                        script.SwapDisabled("¡1*She tries to ignore you*");

                    }
                    if (rivalry == 1 && !td1)
                    {
                        rivalry = 2;
                        script.SwapS("¡1Got anger issues?");
                        script.SwapD("¡1You know, for a moment I really thought you were just joking yesterday, but know I understand your weirdness.\nNot interested in being your friend, sorry. Too many toxic people in my life already.");
                        
                        script.SwapDisabled("¡1*She tries to ignore you*");
                        if (!td1)
                        {
                            script.SwapT("¡1Alright man, look, at least you were honest, but I don't fucking care and I won't contribute to your case, thanks bye.¡0");

                        }

                    }
                    if (trust == 1 && rivalry == 1)
                    {
                        //1Wow...calm the fuck down ok? How the fuck do you know about that.\nLeave me alone, and I'll tell you what you want.
                        script.SwapOp("About you", "About anyone else");
                        script.SwapS("¡1Now leave me alone.");
                        script.SwapD("¡8Oh no man, I don't want to be your friend now. Fuck off.");
                        script.SwapT("¡1I already told you all I know, please stop talking to me.");
                        script.SwapYes("¡0I'm Lucky, I'm 23 and I came to this city to work. ¡1That's all you get, now fuck off.");
                        script.SwapDisabled("Go bother him.");
                        if (FindObjectOfType<GameMaster>().CheckNPC("Arxl Meorb")) { script.SwapNo("Just to let you know, if you see a douchebag dressed up like he's in the beach, it's my ex.\nAnd that motherfucker is full of shit and toxic as fuck."); }
                        else if (FindObjectOfType<GameMaster>().CheckNPC("Hood")) { script.SwapNo("Sometimes a man with a hoodie tries to talk to me, he's really weird though, I don't understand his intentions. I saw him with a knife once, kind of scary, there you go."); }
                        else if (FindObjectOfType<GameMaster>().CheckNPC("Tristan Glidewave")) { script.SwapNo("That blue jumpsuit guy tried to flirt with me once, but I know he has a wife, so he's a liar, go talk to him."); }
                        else { script.SwapNo("I don't fucking know anyone here. So don't bother me."); script.SwapDisabled("¡1Leave me alone."); }
                        
                        trust = 1;
                        rivalry = 2;

                    }
                    if (friendship == 1 && love == 1)
                    {
                        script.SwapS("¡5Why are you suddenly angry? Alright, calm down.\n¡1If you need anything just ask nicely.");
                        script.SwapD("¡2Yeah you fucked up really hard man, like we were getting along. ¡1Now I think you're just an angry weirdo.");
                        script.SwapT("¡0Oh...\nYeah it makes sense. A detective getting information by manipulating emotions, ¡5how did I not see that in you.+");
                        rivalry = 2; 
                        script.SwapDisabled("¡1*She tries to ignore you*");

                    }
                    if (luckyaware)
                    { script.SwapDisabled("¡1I won't give you anything."); rivalry = 2; }
                    if (dd1 && td2)
                    {
                        //("¡5Oh, now you're threatening me?\nI'm not afraid of you, go away, I'm not the one you're looking for.+");
                        script.SwapOp("You will be afraid", "Tell me about yourself and I'll leave you alone");
                        script.SwapYes("¡1Fuck off man, you people don't scare me at all.");
                        script.SwapNo("I won't, fuck off man.");
                        
                    }

                    break;
                }

            case 6:
                {
                    if (nickname)
                    {
                        if (td6)
                        {
                            //script.SwapI("¡0No, don't do that alright.But, ¡1What the fuck Hatman. ¡0Okay, I don't know, I've been drunk yesterday, I don't remember anything.");
                            script.SwapDisabled("¡8I didn't think you would even mention doing that.");
                            if (btno6)
                            {
                                //Im not aggresive im the chill type
                                script.SwapDisabled("¡0You should know that by now.");

                            }

                        }
                        else
                        {
                            //script.SwapI("Wow, calm down man, what's up, you can talk to me.");

                        }



                        }
                        if (betrayed)
                    {
                        if (dd6)
                        {
                            script.SwapDisabled("¡8What the fuck...");

                        }
                        else if (!dd6)
                        {
                            script.SwapDisabled("I really dont care");
                            script.SwapS("I really dont care");

                        }
                        


                    }
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
                    script.SwapS("Sup.");
                    script.SwapD("Well I don't know you man.\nThere's more people here, don't talk to me, I'm busy... smoking, yeah. Don't bother me while I smoke, It's very important.  Specially today.");
                    script.SwapT("¡1Listen man.\nI'm just chilling here, I'd rather die than kill someone... Well, maybe not, but you get the idea. ");
                    if (FindObjectOfType<GameMaster>().CheckNPC("Tristan Glidewave"))
                    {script.SwapF("That guy right there, with the blue jumpsuit is my boyfriend, I'm so sorry.");}
                    else
                    {script.SwapF("Oh, well I personally feel horrible today, ¡2but thanks anyways.\nYou know, I've had a long day, every Monday is tough right?");}
                    script.SwapYes("???");
                    script.SwapNo("LOL");
                    script.SwapI("¡1Hey calm the fuck down, I don't care, I'm not scared of you.");
                    script.SwapDisabled("¡5I don't understand your intention.");
                    break;
                }
            case 2:
                {
                    SwapFaceID = 0;
                    script.SwapS("Sup.");
                        script.SwapD("Ohh, you're that guy from yesterday.\nWell I saw you creeping around, it´s totally fine though. As long as you don´t creep on me.");
                        script.SwapT("Oh wow\nThat explains why you came here last night and started interrogating people like a detective.\nI'm sure I've got nothing to do with this.");
                        script.SwapF("Well hello there.");
                        script.SwapI("Hey I don't have anything to do with your investigation ok?.");
                        script.SwapDisabled("I don't understand your intention.");
                        

                    if (love == 1 && friendship == 1)
                    {
                        SwapFaceID = 2;
                        script.SwapS("Hey man.\nHow's it going?");
                        script.SwapF("¡3That's funny. ¡2I'm Lucky by the way. Nice to meet you.");
                        script.SwapI("¡1What? What is wrong with you?");
                        script.SwapD("Yes, Well my name is... they call me Lucky, nice to meet you.");
                    }
                    else if (friendship == 1 && love == 0) { script.SwapS("Oh, hi man."); SwapFaceID = 2; }
                    else if (trust == 1 && rivalry == 1)
                    {
                        SwapFaceID = 1;
                        script.SwapS("¡1Oh it's you.");
                        script.SwapD("Don't try to fool me, you just told me the truth yesterday man.\n¡5What kind of lame detective are you?");
                        script.SwapT("¡1I won't fucking cooperate what won't you understand. If you wanna arrest me just do it man.\nI've got nothing to loose.\nI hate you people. Always taking advantage of your power.");
                        script.SwapI("¡1Wow... calm the fuck down ok? How the fuck do you know about that.\nLeave me alone, and I'll tell you what you want.+");
                        
                        script.SwapF("¡1Don't. Just don't.\nI know what you're doing. I've met enough of you to fall for that.\nManipulating emotions to get your information, that's what you people do.");



                    }
                    else if (rivalry == 1)
                    {
                        SwapFaceID = 0;
                        script.SwapS("*Either too concentrated on smoking or just ignoring you*");
                        script.SwapI("¡1You just keep threatening me? Nothing better to do? Never talked to a girl before? What's up man.");
                        script.SwapD("Oh, it's Angryman, at least you said hi today before talking about, ¡1putting me in jail for whatever is your reason.");
                        script.SwapF("¡2Well that's a better opener than yesterday's.\nI'm Lucky.\n¡5...\nNo, I'm not lucky to meet you, my actual NAME is LUCKY. That's my name. Not a trait.");

                    }
                    else if (trust == 1)
                    {
                        SwapFaceID = 1;
                        script.SwapS("¡1Hello Detective.");
                        script.SwapD("Don't try to fool me, you just told me the truth yesterday man.\nWhat kind of lame detective are you?");
                        script.SwapT("I won't fucking cooperate what won't you understand. If you wanna arrest me just do it man.\nI've got nothing to loose.\nYeah, not even a house, so don't fuck with me.");
                        script.SwapI("Wow... calm the fuck down ok? How the fuck do you know about that.\n I'm Lucky, I'm 23 and I came to this city to work. That's all you get.");
                        script.SwapF("Don't. Just don't.\nI know what you're doing. I've met enough of you to fall for that.\nManipulating emotions to get your information, that's what you people do.");
                    }


                    break;
                }
            case 5:
                {

                    GetReputation();
                    SwapFaceID = 4;


                    if (nickname)
                    {

                        script.SwapS("Cool Hat!");
                        script.SwapD("Well, to be honest, I'm kind of drunk right now... Do you never ever take that fucking hat off? I want to see your hair.");
                        script.SwapT("Alright? so, okay, I'll help you with it, just, if I see anything suspicious, I'll let you know.");
                        script.SwapF("You so cheesy maan, get the fuck outa here fuck boy!");
                        script.SwapOp("Why are you drunk", "How was your day");
                        script.SwapYes("I'm drunk because I, okay, first of all I'm not drunk, second of all, it's none of your business, yeah. You're not my dad, or abusive boyfriend.");
                        script.SwapNo("It was fi, I guess...\nI really can't talk a lot right now, sorry.");
                        script.SwapI("What the fuck man, what do you need.+");
                    }
                    else if (luckyaware)
                    {

                        script.SwapS("Deeeeeeeeetect, tive!");
                        script.SwapD("Well I'm doing fine, like, I totally am sober right now.\nHave you seen my cigs?\nNevermind they're here.");
                        script.SwapT("Sorry detective, but I'm more in the party vibe right now, so I can't help you.");
                        script.SwapF("What do you mean by that?+");
                        script.SwapOp("I like your style", "I like your face");
                        script.SwapYes("Oh thanks detective, I like yours too, that trenchcoat is the shit man.");
                        script.SwapNo("I would want to say the same but unforbut, unbort, unfortuta...Un, for, tu, nately, I can't say the same.");
                        script.SwapI("Okay okay okay, fine, I don't know, don't take me too seriously. I really can't help right now, I don't feel very well.+");
                    }
                    else if (friendship + love > 4)
                    {
                        script.SwapS("Heyy it's my friend.");
                        script.SwapD("Well, to be honest, I'm kind of drunk right now...");
                        script.SwapT("I don't believe you, what kind of joke is this.");
                        script.SwapF("Yeah you can take me home tonight, like really+");
                        script.SwapOp("Okay I'll take you home", "I can't");
                        script.SwapYes("Thanks man I really appreciate it.");
                        script.SwapNo("Shit, okay.");
                        script.SwapI("I don't like that.");
                    }
                    else if (badimpr || rivalry >= 2)
                    {

                        script.SwapS("Sup.");
                        script.SwapD("I WAS having a great time until YOU came here and started talking to me, now I'm just FEELING a great time... wait does that make sense?");
                        script.SwapT("I can't right now, can't you see I'm busy as heck.");
                        script.SwapF("Oh no, I know what you're doing. Can't you tell I'm not interested in you?");
                        script.SwapI("Wooooooooooow, so surprised!!!!");
                    }
                    else if (friendship == 2 && rivalry == 1)
                    {
                        script.SwapS("You, I know you!");
                        script.SwapD("I'm totally fine, how about you? Nice! I'm totally fine too!");
                        script.SwapT("Quit saying dumb shit man, it's friday, just enjoy yourself.");
                        script.SwapF("Shit I remember the day we met you were like really aggresive.\nYou're a totally different person now! or maybe I'm just drunk I don't know.");
                        script.SwapI("Hey I know you had a bad day, but please don't bother me, I'm happy right now.");
                    }
                    else if (betrayed)
                    {

                        script.SwapS("Sup.");
                        script.SwapD("I WAS having a great time until YOU came here and started talking to me, now I'm just FEELING a great time... wait does that make sense?");
                        script.SwapT("I can't right now, can't you see I'm busy as heck.");
                        script.SwapF("Well, how do I put this? You treated me like shit.");
                        script.SwapI("Wooooooooooow, so surprised!!!!");

                    }






                    break;
                }
            case 6:
                {
                   if (betrayed)
                    {
                        script.SwapS("¡0Uh, ¡6It's you.");
                        script.SwapD("¡6Well I'm doing fine. ¡0You're kind of toxic, I don't want to talk to you.");
                        script.SwapT("¡6No thanks, not interested in helping you in that.");
                        script.SwapF("¡6It's okay, I don't know, just being around you somehow makes me sad. I'm sorry.");
                        script.SwapI("¡1Stop it, I don't want to listen to you, do whatever you want. I don't care anymore.");
                    }
                    else if (nickname)
                    {
                        SwapFaceID = 0;
                        script.SwapS("Oh hey Cool Hat...");
                        script.SwapD("¡6Welp, I'm feeling like shit, I can't remember what happened last night...\nUghh, my head hurts, I'll never mix those pills with alcohol again.+");
                        script.SwapT("What? And you're just telling me now? When did you find out about this!+");
                        script.SwapF("¡0Yeah thanks, I do look like shit today, I just don't remember anything about last night...\nI think, before falling unconscious, I was crying.¡1 I don't remember about what, I just did, ¡6I haven't had a drink in years.\nI mean, I drink often, but it's been a long time since I got drunk. I felt miserable. I believe I am miserable anyways.\nUghh, ¡1I don't know, now I'm just embarrasing myself with my insecurities, I'm not like this, I don't know what's going on.");
                        script.SwapI("Wow, calm down man, what's up, you can talk to me.");
                    }
                    else if (luckyaware)
                    {

                        script.SwapS("¡0Detective.");
                        script.SwapD("¡1How many times do I have to tell you, you're not lying to me. I know you just want information.");
                        script.SwapT("¡1I won't fucking cooperate man, get that into your brain.");
                        script.SwapF("¡1You're really weird and wrong, I won't let you manipulate my emotions.");
                        script.SwapI("Don't you ever say that out loud again, I haven't seen anything suspicious okay? If I see anything I'll let you know man.");
                        script.SwapDisabled("Don't bother me detective, I'm busy smoking.");
                    }
                    
                    else if (friendship + love > 4)
                    {
                        script.SwapS("¡3Heyy it's my friend.");
                        script.SwapD("¡5I'm sorry did we talk yesterday? ¡6I feel so embarrased... ¡0I did so much stupid shit I don't even remember...+");
                        script.SwapT("I don't believe you, what kind of joke is this!");
                        script.SwapF("¡0Wait.\n¡8Hey, now that I think about it... Did we go to your place last night?+");
                        script.SwapI("¡5Wait are you serious?+");
                        love = 5;
                    }
                    else if (friendship == 2 && rivalry == 1)
                    {
                        script.SwapS("¡0Hey Angryman.");
                        script.SwapD("¡8What the fuck happened last night...\nI feel like shit, the only thing I remember is someone driving me home...\n¡1I don't even remember who.");
                        script.SwapT("¡1Hey what are you talking about! Someone's gonna die TOMORROW? When did you find out about this!");
                        script.SwapF("Thanks, I feel like shit though, ");
                        script.SwapI("Hey I know you had a bad day, but please don't bother me, I'm happy right now.");
                    }
                    else if (badimpr || rivalry >= 2)
                    {

                        script.SwapS("¡0Sup");
                        script.SwapD("I WAS having a great time until YOU came here and started talking to me, now I'm just FEELING a great time... wait does that make sense?");
                        script.SwapT("I can't right now, can't you see I'm busy as heck.");
                        script.SwapF("Oh no, I know what you're doing. Can't you tell I'm not interested in you?");
                        script.SwapI("Wooooooooooow, so surprised!!!!");
                    }







                    break;
                }
            default:
                {

                    script.SwapS("FUCKING HACKER\n Well now maybe we can be a couple.");
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
