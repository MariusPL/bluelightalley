using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
public class sMidlightBlossom : MonoBehaviour
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

    private bool branchingd1,bd1y,bd1n;
    private int cbd1y, cbd1n;


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
        if (days == 1 || days == 2 || days == 3 || days == 6)
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
    //FindObjectOfType<GameMaster>().CheckNPC("Tristan Glidewave")


    private void StartingM()
    {

        switch (days)
        {
            case 4:
                {
                    script.SwapS("The weather is magnificent tonight, raindrops falling on the crowded streets, lovely, truly lovely.\nI expect average people to not give the sky the attention it deserves. I long for the ancient days where we human beings could see the so called sunset and sunrise. Truly lovely.");
                    script.SwapD("Oh, greetings my friend, my name is ¡4Midlight Blossom¡0, head Director of Weeping Clouds Symphony Orchestra. ¡1Have you ever heard any of my work?¡2 +");
                    script.SwapT("¡4Spectacular show is the sky giving us\n¡2Nothing more poetic than a prognosticated death, followed by a prognosticated arrest.\n¡0My name is ¡4Midlight Blossom¡3, I am an artist, not a murderer, I assure you can leave me out of your suspects.");
                    script.SwapF("¡2Please, please, please my friend. Do not feed my vanity for I was born with more than enough of that to achieve my life goals.\n¡0But you know, if you're just being honest then go on ¡4HYOHYOHYOHYO.¡2");
                    script.SwapI("¡3Is that Intimidation I sense?\n¡2There is no need for that. Let's not get angry over nonesense. Life is greater than that.");
                    script.SwapDisabled("¡0The sky... ¡4Truly lovely.");
                    break;
                }
            case 5:
                {
                    if (friendship > 5)
                    {
                        script.SwapS("¡0The weather is magnificent tonight as well, raindrops falling on the crowded streets, lovely, truly lovely.\nOn days like these, people like us, ¡2should be admiring the view.");
                        script.SwapD("¡0Well today was kind of sad actually, I woke up a little later than usual,¡3 but problems began arising once I had my breakfast pills.\n¡1I instantly fell unconcious on the floor.\n¡0My servant rescued me just in time,¡1 and I dreamt of a singular melody, which I cannot recall, but it was so good... ¡4SO MAGNIFICENT!\n¡0My overflowing sadness cannot be put into words right now.");


                    }
                    else
                    {
                        script.SwapS("The weather is magnificent tonight as well, raindrops falling on the crowded streets, lovely, truly lovely.\nOn days like these, people like us, should be admiring the view.");
                        script.SwapD("Oh, greetings my friend, my name is ¡4Midlight Blossom¡0, head Orchestra Director of ¡1Weeping Clouds. Have you ever heard any of my work?¡2 ç");
                        script.SwapT("¡4Spectacular show is the sky giving us\n¡2Nothing more poetic than a prognosticated death, followed by a prognosticated arrest.\n¡0My name is ¡4Midlight Blossom¡3, I am an artist, not a murderer, I assure you can leave me out of your suspects.");
                        script.SwapF("¡2Please, please, please my friend. Do not feed my vanity for I was born with more than enough of that to achieve my life goals.\n¡0But you know, if you're just being honest then go on ¡4HYOHYOHYOHYO.¡2");
                        script.SwapI("¡3Is that Intimidation I sense?\n¡2There is no need for that. Let's not get angry over nonesense. Life is greater than that.");
                        script.SwapDisabled("¡0The sky... ¡4Truly lovely.");
                    }



                    
                    break;
                }
            case 6:
                {
                    script.SwapS("The weather is magnificent tonight, raindrops falling down on the crowded streets, lovely, truly lovely.\nI expect average people to behave the way they do, by not giving the sky the attention it deserves. I long for the ancient days where we human beings could see the so called sunset and sunrise. Truly lovely.");
                    script.SwapD("Oh greetings my friend, My name is Midlight Blossom, head Orchestra Director of Weeping Clouds. Have you ever heard any of my work? ç");
                    script.SwapT("Spectacular show is the sky giving us\nNothing more poetic than a pronosticated death, followed by a pronosticated arrest of murder.\nMy name is Midlight Blossom, I will never lie nor commit any crime other than worshipping our surroundings if that counts.");
                    script.SwapF("Please, please, please my friend. Do not feed my vanity for I was born with more than enough of that to achieve my life goals.\nBut you know, if you're just being honest then go on hehehe.");
                    script.SwapI("Is that Intimidation I sense?\n There is no need for that, what is the information you seek my friend.");
                    script.SwapDisabled("The sky... Truly lovely.");
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
            case 4:
                {
                    if (branchingd1)
                    {
                        if (bd1n)
                        {
                            switch (cbd1n)
                            {
                                case 1:
                                    {
                                        //script.SwapYes("¡4Fantastic! ¡2I knew you have heard the Serenata No.3 in B minor, Op. 40:IV. Andante sostenuto!");
                                        script.SwapDisabled("I don't know what you see yourself as, but I see you, as a man of culture.");
                                        script.SwapS("I don't know what you see yourself as, but I see you, as a man of culture.");
                                        friendship = 10;
                                        love = 0;
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
                                        //script.SwapYes("And what's your opinion on them?+");
                                        script.SwapOp("Good", "Bad");
                                        script.SwapYes("¡2Do you mean Outrageously Outstanding?+");
                                        script.SwapNo("¡3Oh my poor friend. I'm filled with tremendous sadness and empathy for your under explored soul right now.\nI hope you get better over time.");
                                        cbd1y =1;
                                        bd1y = true;
                                        

                                        break;
                                    }
                                case 1:
                                    {
                                        //script.SwapYes("Do you mean Outrageously outstanding?+");
                                        script.SwapOp("Of course!", "Not quite");
                                        script.SwapYes("¡4Masterful! I can see you're a man of wisdom.\nMy grand-sounding euphonious dramatic orchestra is my best creation so far in life.");
                                        script.SwapNo("¡3Oh, you will appreciate it, over time my masterpieces will train your ear and you will be able to understand my exuberantly resourceful creations.");
                                        script.SwapS("Silence is a good description too.");
                                        script.SwapDisabled("Silence is a good description too.");
                                        cbd1y = 2;

                                        break;
                                    }
                                case 2:
                                    {
                                        //4Masterful! I can see you're a man of wisdom.\nMy grand-sounding euphonious dramatic orchestra is my best creation so far in life.");
                                        script.SwapS("Good friend?");
                                        friendship = 10;
                                        love = 10;

                                        break;
                                    }
                                default:
                                    {
                                        Debug.Log("minecraft");

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
        switch (days)
        {
            case 4:
                {
                    if (branchingd1)
                    {
                        if (bd1y)
                        {
                            switch (cbd1y)
                            {
                                case 1:
                                    {

                                        //script.SwapNo("¡3Oh my poor friend. I'm feeling tremendous sadness and empathy for your under explored soul.\nI hope you get better over time.");
                                        script.SwapDisabled("¡2Such a shame. I'm afraid our friendship will be as scarce as your music taste.");
                                        script.SwapS("¡2Such a shame. I'm afraid our friendship will be as scarce as your music taste.");
                                        friendship = -10;
                                        love = -5;
                                        break;
                                    }
                                case 2:
                                    {

                                        //3Oh, you will appreciate it, over time my masterpieces will train your ear and you will be able to understand my exuberantly resourceful creations.")
                                        script.SwapDisabled("¡2But that's okay, I don't blame you, average people like you simply can not.");
                                        script.SwapS("¡2But that's okay, I don't blame you, average people like you simply can not.");

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
                                        //"Such a shame... That is unfortunate...\nI can't believe you haven't heard any of my work, not even the one who goes barum rum rum, barum rum rum?+");
                                        script.SwapOp("Ahh of course, I love the barum rum","No");
                                        script.SwapYes("¡4Fantastic! ¡2I knew you have heard the Serenata No.3 in B minor, Op. 40:IV. Andante sostenuto!");
                                        script.SwapNo("¡1Such a shame, I expect that from average people. I did not think you were unenlightened.");
                                        cbd1n = 1;
                                        bd1n = true;
                                        break;
                                    }
                                case 1:
                                    {
                                        //1Such a shame, I expect that from average people. I did not think you were unenlightened.")
                                        script.SwapDisabled("¡3It's fine, over time you will find out, by the coincidences of life, about my euphonious masterpieces.");
                                        script.SwapS("¡3It's fine, over time you will find out, by the coincidences of life, about my euphonious masterpieces.");
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
            case 4:
                {
                    if (!fd1 || !id1)
                    {
                        //script.SwapD("Oh, greetings my friend, my name is ¡4Midlight Blossom¡0, head Orchestra Director of ¡1Weeping Clouds. Have you ever heard any of my work?¡2 ç");
                        script.SwapOp("Of course","No");
                        script.SwapYes("And what's your opinion of my creations?+");
                        script.SwapNo("Such a shame... That is unfortunate...\nI can't believe you haven't heard any of my work, not even the one who goes barum rum rum, barum rum rum?+");
                        branchingd1 = true;
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
            case 4:
                {
                    SwapFaceID = 4;


                    break;
                }
        }
        SwapFace();
    }

    public void ReplaceFlirt()
    {

        switch (days)
        {
            case 4:
                {
                    SwapFaceID=2;


                    break; }
                

        }


        SwapFace();
    }

    public void ReplaceIntimidate()
    {

        switch (days)
        {

            case 4:
                {
                    SwapFaceID = 3;


                    break;
                }



        }
        SwapFace();
    }



    


}
