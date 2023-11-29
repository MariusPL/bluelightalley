using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class sPeterLavander : MonoBehaviour
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
    private static bool bKrypto, bLucky, bTristan, bAkyro, bMazy, bMidlight, bMila, bTrash, bHood, bMatch, bChetverty = false;
    private string auxnpc;

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
        if (days == 7)
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

                    script.SwapS("Gentleman?");
                    script.SwapD("Your face do looks familiar to me, have we ever met?+");
                    script.SwapT("Interesting...\nI'm the bartender, I know everyone here, what do you need?+");
                    script.SwapOp("About you","About anyone else");
                    script.SwapF("I like to style my hair, my moustache...\nIt's not in my interests however to impress people, I do it for my own pleasure, what do you think about that?+");
                    script.SwapI("Watch your mouth, we can talk like grown adults, can't we?");
                    script.SwapDisabled("DEFAULT");
                    break;
                }
            case 2:
                {

                    script.SwapS("Gentleman?");
                    script.SwapD("Your face do looks familiar to me, have we ever met?+");
                    script.SwapT("I'll do my best. What information do you seek+");
                    script.SwapOp("About you", "About anyone else");
                    script.SwapF("I like to style my hair, my moustache...\nIt's not in my interests however to impress people, I do it for my own pleasure, what do you think about that?+");
                    script.SwapI("Watch your mouth, we can talk like grown adults, can't we?");
                    script.SwapDisabled("DEFAULT");
                    break;
                }
            case 3:
                {

                    script.SwapS("Gentleman?");
                    script.SwapD("Your face do looks familiar to me, have we ever met?+");
                    script.SwapT("Good to know you're advancing on the case, what do you need?+");
                    script.SwapOp("About you", "About anyone else");
                    script.SwapF("I like to style my hair, my moustache...\nIt's not in my interests however to impress people, I do it for my own pleasure, what do you think about that?+");
                    script.SwapI("Watch your mouth, we can talk like grown adults, can't we?");
                    script.SwapDisabled("DEFAULT");
                    break;
                }
            case 4:
                {

                    script.SwapS("Gentleman?");
                    script.SwapD("Your face do looks familiar to me, have we ever met?+");
                    script.SwapT("I'm glad I'm helping, what do you want to me to talk about?+");
                    script.SwapOp("About you", "About anyone else");
                    script.SwapF("I like to style my hair, my moustache...\nIt's not in my interests however to impress people, I do it for my own pleasure, what do you think about that?+");
                    script.SwapI("Watch your mouth, we can talk like grown adults, can't we?");
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

                    script.SwapS("FUCKING HACKER");
                    script.SwapD("DEFAULT");
                    script.SwapT("DEFAULT");
                    script.SwapF("Now that I know what you are, maybe we can get to know each other better.");
                    script.SwapI("DEFAULT");
                    script.SwapDisabled("DEFAULT");
                    break;
                }
        }
        SwapFace();

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

        }
        SwapFace();


    }

    public void ReplaceTruth()
    {

        switch (days)
        {
            case 1:
                {
                    
                    auxnpc = FindObjectOfType<GameMaster>().ActiveNPCS[Random.Range(0, FindObjectOfType<GameMaster>().ActiveNPCS.Count)].name ;
                    if (auxnpc == "Krypto" && !bKrypto){ bKrypto = true;    script.SwapNo("Alright, let's see...\nThere's this gentleman with a pink shirt and golden glasses. His name is 'Krypto', or that's what he tells people. I believe no one knows his real name.\nHe is an extremely dangerous hacker and coder.\nAccording to popular belief, Krypto once hacked through time.\nDon't ask me how that works.");}
                        else if (auxnpc == "Krypto" && bKrypto) { ReplaceTruth(); }
                    if (auxnpc == "Lucky" && !bLucky) { bLucky = true;    script.SwapNo("Alright, let's see...\nThere's a lady, with a beanie, uh... a smoker, by the small balcony... her name is Lucky. I believe  we traded words about two times.\nI'm aware her favourite drink is plain vodka. Sometimes with a little bit of orange juice.\nShe usually comes around 11pm."); }
                        else if (auxnpc == "Lucky" && bLucky) { ReplaceTruth(); }
                    if (auxnpc == "Hood" && !bHood) { bHood = true; script.SwapNo("Oh well, there's this mysterious boy, his name is Hood. We exchange words quite often. He is much elocuent.\nMan looks at life in a way nobody does, which makes him a very interesting. He drinks water."); }
                        else if (auxnpc == "Hood" && bHood) { ReplaceTruth(); }
                    if (auxnpc == "Mila Evermore" && !bMila) { bMila = true;    script.SwapNo("Alright, let's see...\nThere's this lady, she has purple hair. Doesn't like to talk much. I can tell she is very shy, she likes fancy coloured drinks, and never finishes them. I believe her name is Mila Evermore."); }
                        else if (auxnpc == "Mila Evermore" && bMila) { ReplaceTruth(); }
                    if (auxnpc == "Tristan Glidewave" && !bTristan) { bTristan = true; script.SwapNo("Alright, let's see...\nThere's this sir, Tristan Glidewave, an engineer. He seems sad all the time.At the dead of night he likes to go stare at nothing at the small balcony. His favourite drink is half Fernet half cola."); }
                        else if (auxnpc == "Tristan Glidewave" && bTristan) { ReplaceTruth(); }
                    if (auxnpc == "Akyro Jin" && !bAkyro) { bAkyro = true; script.SwapNo("Alright, let's see...\nSee that gentleman over there? The one with a mask with light blue letters on it. His name is Akyro. He talks to no one. Not even me. We usually communicate through eye contact. His favourite drink is rice wine with lemon, sugar and a bit of jasmine tea. "); }
                        else if (auxnpc == "Akyro Jin" && bAkyro) { ReplaceTruth(); }
                    if (auxnpc == "Mazy Evs" && !bMazy &&FindObjectOfType<GameMaster>().CheckNPC("KathyMoore")) { bMazy = true; script.SwapNo("Alright, let's see...\nThat red haired lady over there her name is Mazy Evs, she is very energetic. She always comes with her blonde friend, Kethy Moore, I believe they work together. Mazy likes to drink Vodka with Kahlua and vanilla icecream."); }
                    else if(auxnpc == "Mazy Evs" && !FindObjectOfType<GameMaster>().CheckNPC("KathyMoore") && !bMazy) { bMazy = true;  script.SwapNo("Alright, let's see...\nThat red haired lady over there her name is Mazy Evs, she is very energetic. Mazy likes to drink Vodka with Kahlua and vanilla icecream.\nTo be honest we never really had a meaningful conversation."); }
                        else if (auxnpc == "Mazy Evs" && bMazy) { ReplaceTruth(); }
                    if (auxnpc == "Midlight Blossom" && !bMidlight) { bMidlight = true; script.SwapNo("Ohh, the head director of Weeping Clouds is here, He's name is very artistic, Midlight Blossom.\nFavourite drink? Simple, Base of gin mixed with fresh grape juice and Cointreau. And he likes his grapes fresh. He can taste every small detail in my cocktails, so I have to be milimetric when it comes to him.\nHe may result creepy and weird, but I've known him for years, and I assure you he is a good man."); }
                        else if (auxnpc == "Midlight Blossom" && bMidlight) { ReplaceTruth(); }
                    if (auxnpc == "Trash" && FindObjectOfType<GameMaster>().CheckNPC("Hawg") && !bTrash) { bTrash = true; script.SwapNo("Alright, let's see...\nThere's this gentleman with a black mask with red lights... Somewhat intimidating, I don't know his name, He is always armed and with this other tall gentleman with a robotic eye, I believe they work together and the tall sir is his boss. He never talked to me. If you ask me, they are definitely suspicious."); }
                    else if (auxnpc == "Trash" && !FindObjectOfType<GameMaster>().CheckNPC("Hawg") && bTrash) { bTrash = true; script.SwapNo("Alright, let's see...\nThere's this gentleman with a black mask with red lights... Somewhat intimidating, I don't know his name, He is always armed.\nHe behaves like an animal, drinks pure whiskey."); }
                        else if (auxnpc == "Trash" && bTrash) { ReplaceTruth(); }
                    if (auxnpc == "Match Tom" && !bMatch) { bMatch = true; script.SwapNo("Alright, let's see...\nMatch Tom, a common customer here, likes to party, comes whenever he is free from his networking job, a young entrepeneur. He drinks Beast ED with 2 drops of wine."); }
                    else if (auxnpc == "Match Tom" && bMatch) { ReplaceTruth(); }
                    if (auxnpc == "Chetverty" && !bChetverty) { bChetverty = true; script.SwapNo("Alright, let's see...\nThere is a big tall sir, with a gas mask and military armour, I do not know his name.\nWe never talked, but by the smell he wears, I serve him cranberry kompot and he seems to love it."); }
                    else if (auxnpc == "Chetverty" && bChetverty) { ReplaceTruth(); }
                    break;
                }

            case 2:
                {

                    auxnpc = FindObjectOfType<GameMaster>().ActiveNPCS[Random.Range(0, FindObjectOfType<GameMaster>().ActiveNPCS.Count)].name;
                    if (auxnpc == "Krypto" && !bKrypto) { bKrypto = true; script.SwapNo("Alright, let's see...\nThere's this gentleman with a pink shirt and golden glasses. His name is 'Krypto', or that's what he tells people. I believe no one knows his real name.\nHe is an extremely dangerous hacker and coder.\nAccording to popular belief, Krypto once hacked through time.\nDon't ask me how that works."); }
                    else if (auxnpc == "Krypto" && bKrypto) { ReplaceTruth(); }
                    if (auxnpc == "Lucky" && !bLucky) { bLucky = true; script.SwapNo("Alright, let's see...\nThere's a lady, with an orange beanie, a smoker, by the small balcony, her name is Lucky, I believe, we traded words about two times.\nI'm aware her favourite drink is plain vodka. Sometimes with a little bit of orange juice. Also she smokes about 2 packs per day."); }
                    else if (auxnpc == "Lucky" && bLucky) { ReplaceTruth(); }
                    if (auxnpc == "Hood" && !bHood) { bHood = true; script.SwapNo("Oh well, there's this hooded mister, his name is Hood, I believe he is into some 3rd level drug. He never stops talking about his hoodies and how he grew up in the hood. We exchange words quite often.\nHe looks at life in a way nobody does, which makes him a very interesting person. He drinks water."); }
                    else if (auxnpc == "Hood" && bHood) { ReplaceTruth(); }
                    if (auxnpc == "Mila Evermore" && !bMila) { bMila = true; script.SwapNo("Alright, let's see...\nThere's this lady, she has purple hair. Doesn't like to talk much. I can tell she is very shy, she likes fancy coloured drinks, and never finishes them. I believe her name is Mila Evermore."); }
                    else if (auxnpc == "Mila Evermore" && bMila) { ReplaceTruth(); }
                    if (auxnpc == "Tristan Glidewave" && !bTristan) { bTristan = true; script.SwapNo("Alright, let's see...\nThere's this man, this sir, Tristan Glidewave, an engineer. He seems sad all the time. I've seen him talking to many different girls. Although at the end of the night he likes to go stare at nothing at the small balcony. His favourite drink is half Fernet half cola"); }
                    else if (auxnpc == "Tristan Glidewave" && bTristan) { ReplaceTruth(); }
                    if (auxnpc == "Akyro Jin" && !bAkyro) { bAkyro = true; script.SwapNo("Alright, let's see...\nSee that gentleman over there? The one with a mask with light blue letters on it. His name is Akyro. He talks to no one. Not even me. We usually communicate through eye contact. His favourite drink is rice wine with lemon, sugar and a bit of jasmine tea. "); }
                    else if (auxnpc == "Akyro Jin" && bAkyro) { ReplaceTruth(); }
                    if (auxnpc == "Mazy Evs" && !bMazy && FindObjectOfType<GameMaster>().CheckNPC("KathyMoore")) { bMazy = true; script.SwapNo("Alright, let's see...\nThat red haired lady over there her name is Mazy Evs, she is very energetic. She always comes with her blonde friend, Kethy Moore, I believe they work together. Mazy likes to drink Vodka with Kahlua and vanilla icecream."); }
                    else if (auxnpc == "Mazy Evs" && !FindObjectOfType<GameMaster>().CheckNPC("KathyMoore") && !bMazy) { bMazy = true; script.SwapNo("Alright, let's see...\nThat red haired lady over there her name is Mazy Evs, she is very energetic. Mazy likes to drink Vodka with Kahlua and vanilla icecream.\nTo be honest we never really had a meaningful conversation."); }
                    else if (auxnpc == "Mazy Evs" && bMazy) { ReplaceTruth(); }
                    if (auxnpc == "Midlight Blossom" && !bMidlight) { bMidlight = true; script.SwapNo("Ohh, there's this strange person, it's name is very artistic, Midnight Blossoms if I remember correctly.\nit's genderless.\nFavourite drink? Simple, Base of gin mixed with fresh grape juice and Cointreau.\nit's weird, and may result creepy when laughing, but is a really good person I can assure."); }
                    else if (auxnpc == "Midlight Blossom" && bMidlight) { ReplaceTruth(); }
                    if (auxnpc == "Trash" && FindObjectOfType<GameMaster>().CheckNPC("Hawg") && !bTrash) { bTrash = true; script.SwapNo("Alright, let's see...\nThere's this gentleman with a black mask with red lights... Somewhat intimidating, I don't know his name, He is always armed and with this other tall gentleman with a robotic eye, I believe they work together and the tall sir is his boss. He never talked to me."); }
                    else if (auxnpc == "Trash" && !FindObjectOfType<GameMaster>().CheckNPC("Hawg") && bTrash) { bTrash = true; script.SwapNo("Alright, let's see...\nThere's this gentleman with a black mask with red lights... Somewhat intimidating, I don't know his name, He is always armed.\nHe behaves like an animal, drinks pure whiskey."); }
                    else if (auxnpc == "Trash" && bTrash) { ReplaceTruth(); }
                    break;
                }
            case 3:
                {

                    auxnpc = FindObjectOfType<GameMaster>().ActiveNPCS[Random.Range(0, FindObjectOfType<GameMaster>().ActiveNPCS.Count)].name;
                    if (auxnpc == "Krypto" && !bKrypto) { bKrypto = true; script.SwapNo("Alright, let's see...\nThere's this gentleman with a pink shirt and golden glasses. His name is 'Krypto', or that's what he tells people. I believe no one knows his real name.\nHe is an extremely dangerous hacker and coder.\nAccording to popular belief, Krypto once hacked through time.\nDon't ask me how that works."); }
                    else if (auxnpc == "Krypto" && bKrypto) { ReplaceTruth(); }
                    if (auxnpc == "Lucky" && !bLucky) { bLucky = true; script.SwapNo("Alright, let's see...\nThere's a lady, with an orange beanie, a smoker, by the small balcony, her name is Lucky, I believe, we traded words about two times.\nI'm aware her favourite drink is plain vodka. Sometimes with a little bit of orange juice. Also she smokes about 2 packs per day."); }
                    else if (auxnpc == "Lucky" && bLucky) { ReplaceTruth(); }
                    if (auxnpc == "Hood" && !bHood) { bHood = true; script.SwapNo("Oh well, there's this hooded mister, his name is Hood, I believe he is into some 3rd level drug. He never stops talking about his hoodies and how he grew up in the hood. We exchange words quite often.\nHe looks at life in a way nobody does, which makes him a very interesting person. He drinks water."); }
                    else if (auxnpc == "Hood" && bHood) { ReplaceTruth(); }
                    if (auxnpc == "Mila Evermore" && !bMila) { bMila = true; script.SwapNo("Alright, let's see...\nThere's this lady, she has purple hair. Doesn't like to talk much. I can tell she is very shy, she likes fancy coloured drinks, and never finishes them. I believe her name is Mila Evermore."); }
                    else if (auxnpc == "Mila Evermore" && bMila) { ReplaceTruth(); }
                    if (auxnpc == "Tristan Glidewave" && !bTristan) { bTristan = true; script.SwapNo("Alright, let's see...\nThere's this man, this sir, Tristan Glidewave, an engineer. He seems sad all the time. I've seen him talking to many different girls. Although at the end of the night he likes to go stare at nothing at the small balcony. His favourite drink is half Fernet half cola"); }
                    else if (auxnpc == "Tristan Glidewave" && bTristan) { ReplaceTruth(); }
                    if (auxnpc == "Akyro Jin" && !bAkyro) { bAkyro = true; script.SwapNo("Alright, let's see...\nSee that gentleman over there? The one with a mask with light blue letters on it. His name is Akyro. He talks to no one. Not even me. We usually communicate through eye contact. His favourite drink is rice wine with lemon, sugar and a bit of jasmine tea. "); }
                    else if (auxnpc == "Akyro Jin" && bAkyro) { ReplaceTruth(); }
                    if (auxnpc == "Mazy Evs" && !bMazy && FindObjectOfType<GameMaster>().CheckNPC("KathyMoore")) { bMazy = true; script.SwapNo("Alright, let's see...\nThat red haired lady over there her name is Mazy Evs, she is very energetic. She always comes with her blonde friend, Kethy Moore, I believe they work together. Mazy likes to drink Vodka with Kahlua and vanilla icecream."); }
                    else if (auxnpc == "Mazy Evs" && !FindObjectOfType<GameMaster>().CheckNPC("KathyMoore") && !bMazy) { bMazy = true; script.SwapNo("Alright, let's see...\nThat red haired lady over there her name is Mazy Evs, she is very energetic. Mazy likes to drink Vodka with Kahlua and vanilla icecream.\nTo be honest we never really had a meaningful conversation."); }
                    else if (auxnpc == "Mazy Evs" && bMazy) { ReplaceTruth(); }
                    if (auxnpc == "Midlight Blossom" && !bMidlight) { bMidlight = true; script.SwapNo("Ohh, there's this strange person, it's name is very artistic, Midnight Blossoms if I remember correctly.\nit's genderless.\nFavourite drink? Simple, Base of gin mixed with fresh grape juice and Cointreau.\nit's weird, and may result creepy when laughing, but is a really good person I can assure."); }
                    else if (auxnpc == "Midlight Blossom" && bMidlight) { ReplaceTruth(); }
                    if (auxnpc == "Trash" && FindObjectOfType<GameMaster>().CheckNPC("Hawg") && !bTrash) { bTrash = true; script.SwapNo("Alright, let's see...\nThere's this gentleman with a black mask with red lights... Somewhat intimidating, I don't know his name, He is always armed and with this other tall gentleman with a robotic eye, I believe they work together and the tall sir is his boss. He never talked to me."); }
                    else if (auxnpc == "Trash" && !FindObjectOfType<GameMaster>().CheckNPC("Hawg") && bTrash) { bTrash = true; script.SwapNo("Alright, let's see...\nThere's this gentleman with a black mask with red lights... Somewhat intimidating, I don't know his name, He is always armed.\nHe behaves like an animal, drinks pure whiskey."); }
                    else if (auxnpc == "Trash" && bTrash) { ReplaceTruth(); }
                    break;
                }
            case 4:
                {

                    auxnpc = FindObjectOfType<GameMaster>().ActiveNPCS[Random.Range(0, FindObjectOfType<GameMaster>().ActiveNPCS.Count)].name;
                    if (auxnpc == "Krypto" && !bKrypto) { bKrypto = true; script.SwapNo("Alright, let's see...\nThere's this gentleman with a pink shirt and golden glasses. His name is 'Krypto', or that's what he tells people. I believe no one knows his real name.\nHe is an extremely dangerous hacker and coder.\nAccording to popular belief, Krypto once hacked through time.\nDon't ask me how that works."); }
                    else if (auxnpc == "Krypto" && bKrypto) { ReplaceTruth(); }
                    if (auxnpc == "Lucky" && !bLucky) { bLucky = true; script.SwapNo("Alright, let's see...\nThere's a lady, with an orange beanie, a smoker, by the small balcony, her name is Lucky, I believe, we traded words about two times.\nI'm aware her favourite drink is plain vodka. Sometimes with a little bit of orange juice. Also she smokes about 2 packs per day."); }
                    else if (auxnpc == "Lucky" && bLucky) { ReplaceTruth(); }
                    if (auxnpc == "Hood" && !bHood) { bHood = true; script.SwapNo("Oh well, there's this hooded mister, his name is Hood, I believe he is into some 3rd level drug. He never stops talking about his hoodies and how he grew up in the hood. We exchange words quite often.\nHe looks at life in a way nobody does, which makes him a very interesting person. He drinks water."); }
                    else if (auxnpc == "Hood" && bHood) { ReplaceTruth(); }
                    if (auxnpc == "Mila Evermore" && !bMila) { bMila = true; script.SwapNo("Alright, let's see...\nThere's this lady, she has purple hair. Doesn't like to talk much. I can tell she is very shy, she likes fancy coloured drinks, and never finishes them. I believe her name is Mila Evermore."); }
                    else if (auxnpc == "Mila Evermore" && bMila) { ReplaceTruth(); }
                    if (auxnpc == "Tristan Glidewave" && !bTristan) { bTristan = true; script.SwapNo("Alright, let's see...\nThere's this man, this sir, Tristan Glidewave, an engineer. He seems sad all the time. I've seen him talking to many different girls. Although at the end of the night he likes to go stare at nothing at the small balcony. His favourite drink is half Fernet half cola"); }
                    else if (auxnpc == "Tristan Glidewave" && bTristan) { ReplaceTruth(); }
                    if (auxnpc == "Akyro Jin" && !bAkyro) { bAkyro = true; script.SwapNo("Alright, let's see...\nSee that gentleman over there? The one with a mask with light blue letters on it. His name is Akyro. He talks to no one. Not even me. We usually communicate through eye contact. His favourite drink is rice wine with lemon, sugar and a bit of jasmine tea. "); }
                    else if (auxnpc == "Akyro Jin" && bAkyro) { ReplaceTruth(); }
                    if (auxnpc == "Mazy Evs" && !bMazy && FindObjectOfType<GameMaster>().CheckNPC("KathyMoore")) { bMazy = true; script.SwapNo("Alright, let's see...\nThat red haired lady over there her name is Mazy Evs, she is very energetic. She always comes with her blonde friend, Kethy Moore, I believe they work together. Mazy likes to drink Vodka with Kahlua and vanilla icecream."); }
                    else if (auxnpc == "Mazy Evs" && !FindObjectOfType<GameMaster>().CheckNPC("KathyMoore") && !bMazy) { bMazy = true; script.SwapNo("Alright, let's see...\nThat red haired lady over there her name is Mazy Evs, she is very energetic. Mazy likes to drink Vodka with Kahlua and vanilla icecream.\nTo be honest we never really had a meaningful conversation."); }
                    else if (auxnpc == "Mazy Evs" && bMazy) { ReplaceTruth(); }
                    if (auxnpc == "Midlight Blossom" && !bMidlight) { bMidlight = true; script.SwapNo("Ohh, there's this strange person, it's name is very artistic, Midnight Blossoms if I remember correctly.\nit's genderless.\nFavourite drink? Simple, Base of gin mixed with fresh grape juice and Cointreau.\nit's weird, and may result creepy when laughing, but is a really good person I can assure."); }
                    else if (auxnpc == "Midlight Blossom" && bMidlight) { ReplaceTruth(); }
                    if (auxnpc == "Trash" && FindObjectOfType<GameMaster>().CheckNPC("Hawg") && !bTrash) { bTrash = true; script.SwapNo("Alright, let's see...\nThere's this gentleman with a black mask with red lights... Somewhat intimidating, I don't know his name, He is always armed and with this other tall gentleman with a robotic eye, I believe they work together and the tall sir is his boss. He never talked to me."); }
                    else if (auxnpc == "Trash" && !FindObjectOfType<GameMaster>().CheckNPC("Hawg") && bTrash) { bTrash = true; script.SwapNo("Alright, let's see...\nThere's this gentleman with a black mask with red lights... Somewhat intimidating, I don't know his name, He is always armed.\nHe behaves like an animal, drinks pure whiskey."); }
                    else if (auxnpc == "Trash" && bTrash) { ReplaceTruth(); }
                    break;
                }
            case 5:
                {

                    auxnpc = FindObjectOfType<GameMaster>().ActiveNPCS[Random.Range(0, FindObjectOfType<GameMaster>().ActiveNPCS.Count)].name;
                    if (auxnpc == "Krypto" && !bKrypto) { bKrypto = true; script.SwapNo("Alright, let's see...\nThere's this gentleman with a pink shirt and golden glasses. His name is 'Krypto', or that's what he tells people. I believe no one knows his real name.\nHe is an extremely dangerous hacker and coder.\nAccording to popular belief, Krypto once hacked through time.\nDon't ask me how that works."); }
                    else if (auxnpc == "Krypto" && bKrypto) { ReplaceTruth(); }
                    if (auxnpc == "Lucky" && !bLucky) { bLucky = true; script.SwapNo("Alright, let's see...\nThere's a lady, with an orange beanie, a smoker, by the small balcony, her name is Lucky, I believe, we traded words about two times.\nI'm aware her favourite drink is plain vodka. Sometimes with a little bit of orange juice. Also she smokes about 2 packs per day."); }
                    else if (auxnpc == "Lucky" && bLucky) { ReplaceTruth(); }
                    if (auxnpc == "Hood" && !bHood) { bHood = true; script.SwapNo("Oh well, there's this hooded mister, his name is Hood, I believe he is into some 3rd level drug. He never stops talking about his hoodies and how he grew up in the hood. We exchange words quite often.\nHe looks at life in a way nobody does, which makes him a very interesting person. He drinks water."); }
                    else if (auxnpc == "Hood" && bHood) { ReplaceTruth(); }
                    if (auxnpc == "Mila Evermore" && !bMila) { bMila = true; script.SwapNo("Alright, let's see...\nThere's this lady, she has purple hair. Doesn't like to talk much. I can tell she is very shy, she likes fancy coloured drinks, and never finishes them. I believe her name is Mila Evermore."); }
                    else if (auxnpc == "Mila Evermore" && bMila) { ReplaceTruth(); }
                    if (auxnpc == "Tristan Glidewave" && !bTristan) { bTristan = true; script.SwapNo("Alright, let's see...\nThere's this man, this sir, Tristan Glidewave, an engineer. He seems sad all the time. I've seen him talking to many different girls. Although at the end of the night he likes to go stare at nothing at the small balcony. His favourite drink is half Fernet half cola"); }
                    else if (auxnpc == "Tristan Glidewave" && bTristan) { ReplaceTruth(); }
                    if (auxnpc == "Akyro Jin" && !bAkyro) { bAkyro = true; script.SwapNo("Alright, let's see...\nSee that gentleman over there? The one with a mask with light blue letters on it. His name is Akyro. He talks to no one. Not even me. We usually communicate through eye contact. His favourite drink is rice wine with lemon, sugar and a bit of jasmine tea. "); }
                    else if (auxnpc == "Akyro Jin" && bAkyro) { ReplaceTruth(); }
                    if (auxnpc == "Mazy Evs" && !bMazy && FindObjectOfType<GameMaster>().CheckNPC("KathyMoore")) { bMazy = true; script.SwapNo("Alright, let's see...\nThat red haired lady over there her name is Mazy Evs, she is very energetic. She always comes with her blonde friend, Kethy Moore, I believe they work together. Mazy likes to drink Vodka with Kahlua and vanilla icecream."); }
                    else if (auxnpc == "Mazy Evs" && !FindObjectOfType<GameMaster>().CheckNPC("KathyMoore") && !bMazy) { bMazy = true; script.SwapNo("Alright, let's see...\nThat red haired lady over there her name is Mazy Evs, she is very energetic. Mazy likes to drink Vodka with Kahlua and vanilla icecream.\nTo be honest we never really had a meaningful conversation."); }
                    else if (auxnpc == "Mazy Evs" && bMazy) { ReplaceTruth(); }
                    if (auxnpc == "Midlight Blossom" && !bMidlight) { bMidlight = true; script.SwapNo("Ohh, there's this strange person, it's name is very artistic, Midnight Blossoms if I remember correctly.\nit's genderless.\nFavourite drink? Simple, Base of gin mixed with fresh grape juice and Cointreau.\nit's weird, and may result creepy when laughing, but is a really good person I can assure."); }
                    else if (auxnpc == "Midlight Blossom" && bMidlight) { ReplaceTruth(); }
                    if (auxnpc == "Trash" && FindObjectOfType<GameMaster>().CheckNPC("Hawg") && !bTrash) { bTrash = true; script.SwapNo("Alright, let's see...\nThere's this gentleman with a black mask with red lights... Somewhat intimidating, I don't know his name, He is always armed and with this other tall gentleman with a robotic eye, I believe they work together and the tall sir is his boss. He never talked to me."); }
                    else if (auxnpc == "Trash" && !FindObjectOfType<GameMaster>().CheckNPC("Hawg") && bTrash) { bTrash = true; script.SwapNo("Alright, let's see...\nThere's this gentleman with a black mask with red lights... Somewhat intimidating, I don't know his name, He is always armed.\nHe behaves like an animal, drinks pure whiskey."); }
                    else if (auxnpc == "Trash" && bTrash) { ReplaceTruth(); }
                    break;
                }
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
