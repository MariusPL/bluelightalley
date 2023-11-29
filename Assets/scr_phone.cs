using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_phone : MonoBehaviour
{
    public bool phoneout;
    public List<GameObject> apps;

    public List<GameObject> ListPanels;
    private GameObject selected;
    private int appCounter;
    private int lastAppCounter;
    public bool homescreen;
    private bool p_inboxnomsg;

    public bool callscreen;
    public scChapter1 chapter1;
    private Color32 auxcolor;
    public bool newmsg, newshout = false;

    
    public GameObject gocallscreen, gohomescreen;
    public List<GameObject> callscreenapps;


    public List<GameObject> inbox_profiles;


    public int answercallID;



    public Image phoneclick;
    public List<Sprite> spr_phone;
    public bool p_chat;
    private bool  p_shoutout, p_inbox, p_shoutout_nonew = false;
    public Image icon_inbox;
    public Sprite icon_inbox_idle;
    public Sprite icon_inbox_noti;

    private bool auxboolinbox, auxboolshoutout, auxboolopenphone;

    public Image icon_shoutout;
    public Sprite icon_shoutout_idle;
    public Sprite icon_shoutout_noti;

    public scr_notebook Note;


    private bool isRunning1, isRunning2;
    // Start is called before the first frame update
    void Start()
    {
    
        p_inboxnomsg = false;
        appCounter = 0;
        lastAppCounter = 0;
        selected = callscreenapps[appCounter];
        auxcolor = selected.GetComponent<Image>().color;
        selected.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        phoneout = false;


    }

    // Update is called once per frame
    void Update()
    {
        if (!Note.p_selectingwords)
        {
            if (!phoneout)
            {
                if (Input.GetKeyDown(KeyCode.S))
                {

                    if (!auxboolopenphone)
                    {
                        checkPhone();
                        auxboolopenphone = true;
                    }
                }


            }
            else
            {

                if (homescreen)
                {
                    if (Input.GetKeyDown(KeyCode.Z))
                    {
                        switch (appCounter)
                        {
                            case 0:
                                {

                                    InBox();
                                    resetvars();
                                    break;
                                }
                            case 1:
                                {
                                    ShoutOut();
                                    resetvars();
                                    break;
                                }
                            case 2:
                                {

                                    hidePhone();

                                    break;
                                }
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.X))
                    {


                        hidePhone();



                    }
                    lastAppCounter = appCounter;
                    if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {

                        if (appCounter > 0)
                        {
                            appCounter -= 1;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.RightArrow))
                    {

                        if (appCounter < apps.Count - 1)
                        {
                            appCounter += 1;
                        }


                    }
                    if (lastAppCounter != appCounter)
                    {
                        HighlightSelected();
                    }



                    //aca empiezan las verificaciones

                    if (newmsg)
                    {
                        auxboolinbox = false;
                        icon_inbox.sprite = icon_inbox_noti;
                    }
                    else
                    {
                        if (auxboolinbox)
                        {
                            ;
                        }
                        else
                        {
                            icon_inbox.sprite = icon_inbox_idle;
                            auxboolinbox = true;
                        }

                    }
                    if (newshout)
                    {
                        auxboolshoutout = false;
                        icon_shoutout.sprite = icon_shoutout_noti;
                    }
                    else
                    {
                        if (auxboolshoutout)
                        {
                            ;
                        }
                        else
                        {
                            icon_shoutout.sprite = icon_shoutout_idle;
                        }

                    }




                }
                else if (callscreen)
                {
                    if (Input.GetKeyDown(KeyCode.Z))
                    {
                        switch (appCounter)
                        {
                            case 0:
                                {

                                    AnswerCall();

                                    break;
                                }
                            case 1:
                                {

                                    hidePhone();

                                    break;
                                }
                        }

                    }
                    if (Input.GetKeyDown(KeyCode.S))
                    {


                        hidePhone();


                    }
                    lastAppCounter = appCounter;
                    if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {

                        if (appCounter > 0)
                        {
                            appCounter -= 1;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.RightArrow))
                    {

                        if (appCounter < callscreenapps.Count - 1)
                        {
                            appCounter += 1;
                        }


                    }
                    if (lastAppCounter != appCounter)
                    {
                        HighlightSelected();
                    }
                }
                else if (p_inboxnomsg)
                {
                    if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.X))
                    {
                        BackInboxNoMsg();
                    }

                }
                else if (p_inbox)
                {
                    if (p_chat)
                    {
                        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.X))
                        {

                            BackInboxFromChat();
                        }
                    }
                    else
                    {
                        if (Input.GetKeyDown(KeyCode.Z))
                        {
                            switch (appCounter)
                            {
                                case 0:
                                    {

                                        GetComponent<scr_inbox>().EnterChat(appCounter);

                                        break;
                                    }
                                case 1:
                                    {

                                        GetComponent<scr_inbox>().EnterChat(appCounter);

                                        break;
                                    }
                                case 2:
                                    {

                                        GetComponent<scr_inbox>().EnterChat(appCounter);

                                        break;
                                    }
                                case 3:
                                    {

                                        GetComponent<scr_inbox>().EnterChat(appCounter);

                                        break;
                                    }
                                case 4:
                                    {

                                        GetComponent<scr_inbox>().EnterChat(appCounter);

                                        break;
                                    }
                                case 5:
                                    {

                                        GetComponent<scr_inbox>().EnterChat(appCounter);

                                        break;
                                    }
                                case 6:
                                    {
                                        BackInboxMsgScreen();
                                        break;
                                    }
                            }

                        }
                        if (Input.GetKeyDown(KeyCode.X))
                        {
                            BackInboxMsgScreen();
                        }
                        lastAppCounter = appCounter;
                        if (Input.GetKeyDown(KeyCode.LeftArrow))
                        {

                            if (appCounter > 0)
                            {
                                appCounter -= 1;
                            }
                        }
                        if (Input.GetKeyDown(KeyCode.RightArrow))
                        {

                            if (appCounter < inbox_profiles.Count - 1)
                            {
                                appCounter += 1;
                            }


                        }
                        if (Input.GetKeyDown(KeyCode.UpArrow))
                        {

                            if (appCounter - 2 <= 0)
                            {
                                appCounter = 0;
                            }
                            else
                            {
                                appCounter -= 2;
                            }


                        }
                        if (Input.GetKeyDown(KeyCode.DownArrow))
                        {

                            if (appCounter + 2 >= inbox_profiles.Count - 1)
                            {
                                appCounter = inbox_profiles.Count - 1;
                            }
                            else
                            {
                                appCounter += 2;
                            }


                        }
                        if (lastAppCounter != appCounter)
                        {
                            HighlightSelected();
                        }
                    }


                }
                else if (p_shoutout_nonew)
                {
                    if (Input.GetKeyDown(KeyCode.Z))
                    {
                        BackShoutoutNoNew();
                    }

                }

            }
        }
        
        
    }
    public void checkPhone()
    {
        if (!isRunning1)
        { StartCoroutine(wcheckPhone()); }
        
    }
    IEnumerator wcheckPhone()
    {
        isRunning1 = true;
        GetComponent<Animator>().SetTrigger("show");
        yield return new WaitForEndOfFrame();
        
        phoneout = true;
        yield return new WaitForSecondsRealtime(1f);

        if (auxboolopenphone)
        {
            auxboolopenphone = false;
        }
        isRunning1 = false;
    }
    public void InBox()
    {
        
        homescreen = false;
        
        if (newmsg)
        {
            
            ListPanels[2].SetActive(true);
            p_inbox = true;
            icon_inbox.sprite = icon_inbox_idle;
        }
        else
        {
            ListPanels[1].SetActive(true);
            p_inboxnomsg = true;
        }

        ListPanels[0].SetActive(true);

    }

    public void ShoutOut()
    {
        homescreen = false;
        if (newshout)
        {
            newshout = false;
            ListPanels[6].SetActive(true);
            p_shoutout = true;
            icon_shoutout.sprite = icon_shoutout_idle;
        }
        else
        {
            ListPanels[5].SetActive(true);
            p_shoutout_nonew = true;
        }

        ListPanels[4].SetActive(true);

    }

    public void HoverApp(int appid)
    {
        appCounter = appid;
        HighlightSelected();

    }
    private void HighlightSelected()
    {
        if (homescreen)
        {

            selected = apps[appCounter];
            apps[lastAppCounter].GetComponent<Image>().color = auxcolor;
        }
        else if (callscreen)
        {
            selected = callscreenapps[appCounter];
            callscreenapps[lastAppCounter].GetComponent<Image>().color = auxcolor;
        }
        else if (p_inbox)
        {
            selected = inbox_profiles[appCounter];
            inbox_profiles[lastAppCounter].GetComponent<Image>().color = auxcolor;
        }

        selected.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
    }


    public void hidePhone()
    {

        if (!auxboolopenphone)
        {

            auxboolopenphone = true;
            GetComponent<Animator>().SetTrigger("hide");

            resetvars();

            if (!isRunning2)
            { StartCoroutine(zAvailable()); }
        }
        
        


    }
    IEnumerator zAvailable()
    {
        isRunning2 = true;
        yield return new WaitForEndOfFrame();
        phoneout = false;

        yield return new WaitForSecondsRealtime(1f);

        if (auxboolopenphone)
        {
            auxboolopenphone = false;
        }
        isRunning2 = false;

    }

    public void BackInboxNoMsg()
    {

        ListPanels[1].SetActive(false);
        p_inboxnomsg = false;
        ListPanels[0].SetActive(false);
        homescreen = true;

    }

    public void BackInboxMsgScreen()
    {
        resetvars();
        ListPanels[2].SetActive(false);
        p_inbox = false;
        homescreen = true;
        


    }
    public void BackInboxFromChat()
    {
        ListPanels[3].SetActive(false);
        p_chat = false;



    }
    public void BackShoutoutNoNew()
    {

        ListPanels[5].SetActive(false);
        p_shoutout_nonew = false;
        ListPanels[4].SetActive(false);
        homescreen = true;

    }
    private void resetvars()
    {

        appCounter = 0;

        HighlightSelected();

        lastAppCounter = 0;

    }


    public void SetCall(int convonum)
    {
        homescreen = false;
        gohomescreen.SetActive(false);
        callscreen = true;
        gocallscreen.SetActive(true);
        answercallID = convonum;
        phoneclick.sprite = spr_phone[1];
        


    }

    public void AnswerCall()
    {
        phoneclick.sprite = spr_phone[0];
        switch (answercallID)
        {
            case 0:
                {// lucky 1
                    chapter1.AnswerPhone1();
                    break;
                }
            case 1:
                {// tristan 1
                    chapter1.AnswerPhone2();
                    break;
                }
            case 2:
                {// krypto 1
                    chapter1.AnswerPhone3();
                    break;
                }
            case 3:
                {//lucky 2
                    chapter1.AnswerPhone4();
                    break;
                }
            case 4:
                {//airom 1
                    chapter1.AnswerPhone5();
                    break;
                }
            case 5:
                {//krypto 2
                    chapter1.AnswerPhone6();
                    break;
                }
            case 6:
                {//mila 1
                    chapter1.AnswerPhone7();
                    break;
                }

        }

        homescreen = true;
        gohomescreen.SetActive(true);
        callscreen = false;
        gocallscreen.SetActive(false);
        hidePhone();
    }

}
