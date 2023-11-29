using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


[System.Serializable]
public class scChapter1 : MonoBehaviour
{
    [Header("[ Lucky 1 ]")]


    [TextArea(1, 20)]
    public List<string> d1;

   
    [TextArea(1, 20)]
    public List<string> doption;



    [TextArea(1, 20)]
    public List<string> dodump;
    [TextArea(1, 20)]
    public List<string> dotruth;
    [TextArea(1, 20)]
    public List<string> dolie;
    [TextArea(1, 20)]
    public List<string> dochance;

    [TextArea(1, 20)]
    public List<string> d2;


    [Header("[ Lucky 2 ]")]

    [TextArea(1, 20)]
    public List<string> d_l_dumptruth;

    [TextArea(1, 20)]
    public List<string> d_l_dumplie;

    [TextArea(1, 20)]
    public List<string> d_l_dumpnext;

    [TextArea(1, 20)]
    public List<string> d_l_dumpnext_yes;
    [TextArea(1, 20)]
    public List<string> d_l_dumpnext_no;

    [TextArea(1, 20)]
    public List<string> d_l_dumpnext2;

    [TextArea(1, 20)]
    public List<string> do_l_timeself;

    [TextArea(1, 20)]
    public List<string> do_l_dating;
    [TextArea(1, 20)]
    public List<string> d_l_dating_4;
    [TextArea(1, 20)]
    public List<string> do_l_tattoo;
    [TextArea(1, 20)]
    public List<string> do_l_bar;
    [TextArea(1, 20)]
    public List<string> d_l_4;



    [TextArea(1, 20)]
    public List<string> d_l_chance;


    public bool voblack, vodump, volie, vo_l_timeself, vo_l_bar;
    private bool vobf, vo_sad;





    /// <summary>
    /// END LUCKY 1
    /// START TRISTAN 1
    /// </summary>

    [Header("[ Tristan 1 ]")]
    [TextArea(1, 20)]
    public List<string> dtristan1;
    [TextArea(1, 20)]
    public List<string> doraise;
    [TextArea(1, 20)]
    public List<string> donoraise;
    [TextArea(1, 20)]
    public List<string> dtristan2;
    [TextArea(1, 20)]
    public List<string> do_ignore;
    [TextArea(1, 20)]
    public List<string> do_confront;

    [TextArea(1, 20)]
    public List<string> d_tristan_3;

    [TextArea(1, 20)]
    public List<string> do_t_mechanic_raise;
    [TextArea(1, 20)]
    public List<string> do_t_mechanic_noraise;
    [TextArea(1, 20)]
    public List<string> do_t_miner_raise;
    [TextArea(1, 20)]
    public List<string> do_t_miner_noraise;

    [TextArea(1, 20)]
    public List<string> d_tristan_4;


    private bool votraise, VOTignore, VOTmechanic;

    ///
    /// END TRISTAN 1
    /// 
    /// START KRYPTO 1
    /// 
    [Header("[ Krypto 1 ]")]
    [TextArea(1, 20)]
    public List<string> d_krypto_1;
    [TextArea(1, 20)]
    public List<string> do_k_redblue;

    [TextArea(1, 20)]
    public List<string> d_krypto_2_red;
    [TextArea(1, 20)]
    public List<string> do_k_radiovstv;

    [TextArea(1, 20)]
    public List<string> d_krypto_2_blue;

    private bool vo_k_red, vo_k_radio;




    /// <summary>
    /// END KRYPTO
    /// START AIROM
    /// </summary>
    /// 
    [Header("[ Airom 1 ]")]

    [TextArea(1, 20)]
    public List<string> d_airom_1;

    [TextArea(1, 20)]
    public List<string> do_a_cold;
    [TextArea(1, 20)]
    public List<string> do_a_fasting;

    [TextArea(1, 20)]
    public List<string> d_airom_2;

    [TextArea(1, 20)]
    public List<string> do_a_sword;
    [TextArea(1, 20)]
    public List<string> do_a_kickboxing;

    [TextArea(1, 20)]
    public List<string> d_airom_3;

    [TextArea(1, 20)]
    public List<string> do_a_movie;
    [TextArea(1, 20)]
    public List<string> do_a_salt;
    [TextArea(1, 20)]
    public List<string> do_a_sweet;
    [TextArea(1, 20)]
    public List<string> do_a_party;
    [TextArea(1, 20)]
    public List<string> do_a_techno;
    [TextArea(1, 20)]
    public List<string> do_a_hiphop;

    [Header("[ Airom 2 ]")]

    [TextArea(1, 20)]
    public List<string> d_airom_4_holosword;
    [TextArea(1, 20)]
    public List<string> d_airom_4_kickboxing;

    [TextArea(1, 20)]
    public List<string> d_airom_5;

    [TextArea(1, 20)]
    public List<string> d_airom_6_party;
    [TextArea(1, 20)]
    public List<string> do_airom_6_throwparty2;
    [TextArea(1, 20)]
    public List<string> do_airom_6_noparty2;
    [TextArea(1, 20)]
    public List<string> d_airom_6_movie;
    [TextArea(1, 20)]
    public List<string> do_airom_6_warsim;
    [TextArea(1, 20)]
    public List<string> do_airom_6_swim;
    [TextArea(1, 20)]
    public List<string> d_airom_7_dating;
    [TextArea(1, 20)]
    public List<string> d_airom_7_personal;
    [TextArea(1, 20)]
    public List<string> d_airom_7_arxl;

    [TextArea(1, 20)]
    public List<string> d_airom_8;
    [TextArea(1, 20)]
    public List<string> do_airom_preworkout;
    [TextArea(1, 20)]
    public List<string> do_airom_testbooster;

    [TextArea(1, 20)]
    public List<string> d_airom_9;

    private bool vo_a_coldshower, vo_a_photonsword, vo_a_netflix, vo_a_salt, vo_a_techno;



    /// <summary>
    /// END AIROM
    /// START EVERMORE
    /// </summary>

    [Header("[ Mila 1 ]")]

    [TextArea(1, 20)]
    public List<string> d_m_1;
    [TextArea(1, 20)]
    public List<string> d_m_1_op1;
    [TextArea(1, 20)]
    public List<string> d_m_1_op1_yes;
    [TextArea(1, 20)]
    public List<string> d_m_1_op1_no;
    [TextArea(1, 20)]
    public List<string> d_m_1_op2;
    [TextArea(1, 20)]
    public List<string> d_m_1_op2_galaxy;
    [TextArea(1, 20)]
    public List<string> d_m_1_op2_grassfield;
    [TextArea(1, 20)]
    public List<string> d_m_2;
    [TextArea(1, 20)]
    public List<string> d_m_2_op1;
    //if vuelterp
    [TextArea(1, 20)]
    public List<string> d_m_2_op1_varpredicted;
    [TextArea(1, 20)]
    public List<string> d_m_2_op2;
    //if straightforward
    [TextArea(1, 20)]
    public List<string> d_m_2_op2_varpredicted;

    [TextArea(1, 20)]
    public List<string> d_m_3;
    [TextArea(1, 20)]
    public List<string> d_m_3_yes;
    //es yes + like metaphoric + long
    [TextArea(1, 20)]
    public List<string> d_m_3_yes_weird;
    [TextArea(1, 20)]
    public List<string> d_m_3_yes_varpredicted;
    [TextArea(1, 20)]
    public List<string> d_m_3_no;
    [TextArea(1, 20)]
    public List<string> d_m_3_novarpredicted;
    [TextArea(1, 20)]
    public List<string> d_m_4;

    private bool vo_m_miracles, vo_m_1_op1_yes, vo_m_1_op2_galaxy,vo_m_2_long, vo_m_3_yes;

    ///end evermore










        ///CHAPTER 2
        ///TRISTAN 1



    [Header("[ Tristan 1 ]")]
    [TextArea(1, 20)]
    public List<string> c2_tristan_1_MechwithRaise;
    [TextArea(1, 20)]
    public List<string> c2_tristan_1_Mining;
    [TextArea(1, 20)]
    public List<string> c2_tristan_2_Brokeup;
    [TextArea(1, 20)]
    public List<string> c2_o_tristan_2_Brokeup_Talk;
    [TextArea(1, 20)]
    public List<string> c2_o_tristan_2_Brokeup_Avoid;
    [TextArea(1, 20)]
    public List<string> c2_tristan_2_NoBrokeup;
    [TextArea(1, 20)]
    public List<string> c2_o_tristan_2_NoBrokeup_Let;
    [TextArea(1, 20)]
    public List<string> c2_o_tristan_2_NoBrokeup_Divorce;
    [TextArea(1, 20)]
    public List<string> c2_tristan_3;
    [TextArea(1, 20)]
    public List<string> c2_tristan_3_time;
    [TextArea(1, 20)]
    public List<string> c2_tristan_3_money;


    ///
    /// END TRISTAN 2
    /// 
    /// START KRYPTO 2
    /// 

    [Header("[ Krypto 2 ]")]
    [TextArea(1, 20)]
    public List<string> c2_krypto_2;

    [TextArea(1, 20)]
    public List<string> c2_krypto_2_talk;

    [TextArea(1, 20)]
    public List<string> c2_krypto_2_notalk;





    /// <summary>
    /// END KRYPTO 2














    [Header("[ Variables ]")]
    public List<Sprite> Faces;
    [Range(0f, 1f)]
    public float tsLucky, tsTristan, tsKrypto, tsAirom, tsMila;
    [Range(0f, 3f)]
    public float vpLucky, vpTristan, vpKrypto, vpAirom, vpMila;

    [Header("[ PROT ]")]
    public float tsProt;
    public float vpProt;

    public Queue<string> auxQueue;

    public Animator transitionAnim;

    //option setter
    public int optset;

    //animators, ts es text speed o talk speed y vp es voice pitch.


    public AudioSource ring;
    public AudioSource app;


    [HideInInspector]
    public int currentTab;
    [HideInInspector]
    public int currentSubTab;
    [HideInInspector]
    public int currentSubSubTab;
    // Use this for initialization
    void Start()
    {

        GetComponent<SceneDialogueManager>().ResetVars();


    }


    public void AnswerPhone1()
    {
        GetComponent<SceneDialogueManager>().CounterDialogues = 1;
        optset = 0;
        ChangeOption("Black", "Blonde");
        ring.Stop();
        app.Play();
        Dialogue1();
    }

    public void AnswerPhone2()
    {
        GetComponent<SceneDialogueManager>().CounterDialogues = 19;
        ring.Stop();
        app.Play();
        DTristan1();
    }

    public void AnswerPhone3()
    {
        GetComponent<SceneDialogueManager>().CounterDialogues = 23;
        ChangeOption("Red", "Blue");
        optset = 6;
        ring.Stop();
        app.Play();
        DKrypto1();
    }
    public void AnswerPhone4()
    {
        GetComponent<SceneDialogueManager>().CounterDialogues = 24;
        ring.Stop();
        app.Play();
        DLucky1();
    }
    public void AnswerPhone5()
    {
        GetComponent<SceneDialogueManager>().CounterDialogues = 28;
        ring.Stop();
        app.Play();
        DAirom1();
        ChangeOption("Macronutrient pills","Intermitent fasting");
        optset = 10;
    }

    public void AnswerPhone6()
    {
        GetComponent<SceneDialogueManager>().CounterDialogues = 31;
        ring.Stop();
        app.Play();
        DKrypto2();
    }
    public void AnswerPhone7()
    {
        GetComponent<SceneDialogueManager>().CounterDialogues = 32;
        ring.Stop();
        app.Play();
        DMila1();

    }
    public void AnswerPhone8()
    {
        GetComponent<SceneDialogueManager>().CounterDialogues = 33;
        ring.Stop();
        app.Play();
        DAirom4();

    }



    public void Dialogue1()
    {
        StartCoroutine(StartDialogueWithTimer(d1, tsLucky, vpLucky, Faces[0], 2f));

    }
   
   
    public void Dialogue2()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d2, tsLucky, vpLucky, Faces[0]);
    }
    public void DLucky1()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        if (vodump)
        {
            if (volie != true)
            {
                GetComponent<SceneDialogueManager>().StartDialogue(d_l_dumptruth, tsLucky, vpLucky, Faces[0]);
            }
            else
            {
                GetComponent<SceneDialogueManager>().StartDialogue(d_l_dumplie, tsLucky, vpLucky, Faces[0]);
            }

        }
        else
        {
            GetComponent<SceneDialogueManager>().StartDialogue(d_l_chance, tsLucky, vpLucky, Faces[0]);
        }

    }
    public void DLucky2()
    {
        if (vodump)
        {
            ChangeOption("Yes", "No");
            optset = 7;
            GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
            GetComponent<SceneDialogueManager>().StartDialogue(d_l_dumpnext, tsLucky, vpLucky, Faces[0]);

        }
        else
        {

        }
        
    }
    public void DLucky3()
    {
        if (vodump)
        {
            ChangeOption("Get back into dating", "Spend more time on yourself");
            optset = 8;
            GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
            GetComponent<SceneDialogueManager>().StartDialogue(d_l_dumpnext2, tsLucky, vpLucky, Faces[0]);

        }
        else
        {

        }

    }
    public void DLucky4()
    {
        if (vodump)
        {
            if (vo_l_timeself)
            {
                GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
                GetComponent<SceneDialogueManager>().StartDialogue(d_l_4, tsLucky, vpLucky, Faces[0]);
            }
            else
            {
                GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
                GetComponent<SceneDialogueManager>().StartDialogue(d_l_dating_4, tsLucky, vpLucky, Faces[0]);
            }
            

        }
        else
        {

        }

    }
    /// <summary>
    /// End Lucky Convos
    /// Start Tristan Convos
    /// </summary>
    public void DTristan1()
    {
        
        ChangeOption("Ask for the raise","Don't ask for the raise");
        optset = 3;
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(dtristan1, tsTristan, vpTristan, Faces[1]);
    }
    public void DTristan2()
    {
        ChangeOption("Ignore", "Confront");
        optset = 4;
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(dtristan2, tsTristan, vpTristan, Faces[1]);
    }
    public void DTristan3()
    {
        ChangeOption("Mechanic Job", "Miner Job");
        optset = 5;
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d_tristan_3, tsTristan, vpTristan, Faces[1]);
    }
    public void DTristan4()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d_tristan_4, tsTristan-0.35f, vpTristan, Faces[1]);
    }

    /// <summary>
    /// End Tristan Convos
    /// Start Krypto Convos
    /// </summary>
    public void DKrypto1()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d_krypto_1, tsKrypto, vpKrypto, Faces[2]);
    }
    public void DKrypto2()
    {
        if (vo_k_red)
        {
            GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
            GetComponent<SceneDialogueManager>().StartDialogue(d_krypto_2_red, tsKrypto, vpKrypto, Faces[2]);
            optset = 15;
            ChangeOption("Radio", "Television");
        }
        else
        {
            GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
            GetComponent<SceneDialogueManager>().StartDialogue(d_krypto_2_blue, tsKrypto, vpKrypto, Faces[2]);
        }
        
    }
    /// <summary>
    /// end krypto convos
    /// start Airom
    /// </summary>

    public void DAirom1()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d_airom_1, tsAirom, vpAirom, Faces[3]);

    }
    public void DAirom2()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d_airom_2, tsAirom, vpAirom, Faces[3]);
        ChangeOption("Holosword", "Kickboxing");
        optset = 11;
    }
    public void DAirom3()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d_airom_3, tsAirom, vpAirom, Faces[3]);
        ChangeOption("Movie", "Host party");
        optset = 12;
    }
    public void DAirom4()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        if (vo_a_photonsword)
        {

            GetComponent<SceneDialogueManager>().StartDialogue(d_airom_4_holosword, tsAirom, vpAirom, Faces[3]);
        }
        else
        {
            GetComponent<SceneDialogueManager>().StartDialogue(d_airom_4_kickboxing, tsAirom, vpAirom, Faces[3]);
        }
        
    }
    public void DAirom5()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d_airom_4_holosword, tsAirom, vpAirom, Faces[3]);

        ChangeOption("Movie", "Host party");
        optset = 12;

    }
    /// <summary>
    /// END AIROM CONVOS
    /// START MILA CONVOS
    /// </summary>
    public void DMila1()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d_m_1, tsMila, vpMila, Faces[4]);
        ChangeOption("1", "2");
        optset = 16;
    }
    public void DMila2()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d_m_2, tsMila, vpMila, Faces[4]);
        ChangeOption("1", "2");
        optset = 19;
    }
    public void DMila3()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d_m_3, tsMila, vpMila, Faces[4]);
        ChangeOption("Yes", "No");
        optset = 20;
    }
    public void DMila4()
    {
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(d_m_4, tsMila, vpMila, Faces[4]);
    }

    /// <summary>
    /// END CONVOS
    /// </summary>

    public void DialogueSorter()
    {
        Debug.Log(GetComponent<SceneDialogueManager>().CounterDialogues);
        switch (GetComponent<SceneDialogueManager>().CounterDialogues)
        {
            case 1:{Dialogue1();break;}
            case 2:{Dialogue2();break;}
            case 3:{GetComponent<SceneDialogueManager>().NextConvo();break;}
            case 20:{DTristan2();break;}
            case 21:{DTristan3();break;}
            case 22:{DTristan4();break;}
            case 23:{GetComponent<SceneDialogueManager>().NextConvo();break;} //pasa a krypto
            case 24:{GetComponent<SceneDialogueManager>().NextConvo();break;} //termina krypto pasa a lucky-
            case 25: { DLucky2(); break; }
            case 26: { DLucky3(); break; }
            case 27: { DLucky4(); break; }
            case 28: { GetComponent<SceneDialogueManager>().NextConvo(); break; } //termina lucky pas a airom
            case 29: { DAirom2(); break; }
            case 30: { DAirom3(); break; }
            case 31: { GetComponent<SceneDialogueManager>().NextConvo(); break; } //termina airom pasa a krypto
            case 32: { GetComponent<SceneDialogueManager>().NextConvo(); break; } //termina krypto pasa a Mila
            case 33: { DMila2(); break; }
            case 34: { DMila3(); break; }
            case 35: { DMila4(); break; }
        }

    }

    public void OptionSorter(bool A)
    {
        switch (optset)
        {
            case 0:
                {//optlucky black or blondee
                    if (A) { OLBlack(); } else { OLBlonde(); }
                    break;
                }
            case 1:
                {//optlucky dump vs rip
                    if (A) { OLDump(); } else { OLChance(); }
                    break;
                }
            case 2:
                {//optlucky truth vs bullcrap
                    if (A) { OLTruth(); } else { OLLie(); }
                    break;
                }
            case 3:
                {//opttristan raise vs noraise
                    if (A) { OTRaise(); } else { OTNoRaise(); }
                    break;
                }
            case 4:
                {//opttristan ignore vs confornt
                    if (A) { OTIgnore(); } else { OTConfront(); }
                    break;
                }
            case 5:
                {//opttristan mech vs mine
                    if (A) { OTMechanic(); } else { OTMiner(); }
                    break;
                }
            case 6:
                {//optkrypto red vs blue
                    if (A) { OKRed(); } else { OKBlue(); }
                    break;
                }
            case 7:
                {//optlucky sad thing to say vs no 
                    if (A) { OLTerrible(); } else { OLNTerrible(); }
                    break;
                }
            case 8:
                {//optlucky dating vs time self
                    if (A) { OLDating(); } else { OLTimeSelf(); }
                    break;
                }
            case 9:
                {//optlucky tatto vs bar
                    if (A) { OLTattoo(); } else { OLBar(); }
                    break;
                }
            case 10:
                {//optairom cold shower vs fasting
                    if (A) { OACold(); } else { OAFasting(); }
                    break;
                }
            case 11:
                {//optairom photon sword vs kick boxing
                    if (A) { OASword(); } else { OAKick(); }
                    break;
                }
            case 12:
                {//optairom chill vs joda
                    if (A) { OAMovie(); } else { OAParty(); }
                    break;
                }
            case 13:
                {//optairom salty o sweety popcorn
                    if (A) { OAMovie_Salty(); } else { OAMovie_Sweet(); }
                    break;
                }
            case 14:
                {//optairom drug heavy o chill
                    if (A) { OAParty_Techno(); } else { OAParty_Hiphop(); }
                    break;
                }
            case 15:
                {//krypto 
                    if (A) { OKRadio(); } else { OKTelevision(); }
                        break;
                }
            case 16:
                {//mila
                    if (A) { OMMiracles(); } else { OMPredictions(); }
                    break;
                }
            case 17:
                {//mila
                    if (A) { OMMiraclesYes(); } else { OMMiraclesNo(); }
                    break;
                }
            case 18:
                {//mila
                    if (A) { OMPredictionsGalaxy(); } else { OMPredictionsGrass(); }
                    break;
                }
            case 19:
                {//mila
                    if (A) { OMChamuyo(); } else { OMSimpler(); }
                    break;
                }
            case 20:
                {//mila
                    if (A) { OMYes(); } else { OMNo(); }
                    break;
                }

        }






    }


    //lucky optionss
    public void OLBlack()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(doption, tsLucky, vpLucky, Faces[0], 2f));
        ChangeOption("Dump", "Give a second chance");
        optset = 1;
        voblack = true;
    }
    public void OLBlonde()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(doption, tsLucky, vpLucky, Faces[0], 2f));
        ChangeOption("Dump", "Give a second chance");
        optset = 1;
        voblack = false;
    }
    public void OLDump()
    {
        ChangeOption("Harsh truth", "'It's not you it's me'");
        optset = 2;
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(dodump, tsLucky, vpLucky, Faces[0], 0.5f));
        vodump = true;
    }
    public void OLTruth()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(dotruth, tsLucky, vpLucky, Faces[0], 0.5f));
        volie = false;
    }
    public void OLLie()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(dolie, tsLucky, vpLucky, Faces[0], 1f));
        volie = true;
    }
    public void OLChance()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(dochance, tsLucky, vpLucky, Faces[0], 2f));
        vodump = false;
    }
    public void OLTerrible()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(d_l_dumpnext_yes, tsLucky, vpLucky, Faces[0], 1f));
        vo_sad = true;
    }
    public void OLNTerrible()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(d_l_dumpnext_no, tsLucky, vpLucky, Faces[0], 2f));
        vo_sad = false;
    }
    public void OLTimeSelf()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(do_l_timeself, tsLucky, vpLucky, Faces[0], 1f));
        vo_l_timeself = true;
        optset = 9;
        ChangeOption("Tattoo.", "Bar.");
    }
    public void OLDating()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(do_l_dating, tsLucky, vpLucky, Faces[0], 2f));
        vo_l_timeself = false;
    }
    public void OLTattoo()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(do_l_tattoo, tsLucky, vpLucky, Faces[0], 1f));
        vo_l_bar = false;
    }
    public void OLBar()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(do_l_bar, tsLucky, vpLucky, Faces[0], 2f));
        vo_l_bar = true;
    }

    //tristan options
    public void OTRaise()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(doraise, tsTristan, vpTristan, Faces[1], 1f));
        votraise = true;
    }
    public void OTNoRaise()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(donoraise, tsTristan, vpTristan, Faces[1], 2f));
        votraise = false;
    }
    public void OTIgnore()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(do_ignore, tsTristan, vpTristan, Faces[1], 1f));
        VOTignore = true;
    }
    public void OTConfront()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(do_confront, tsTristan, vpTristan, Faces[1], 2f));
        VOTignore = false;
    }
    public void OTMechanic()
    {
        if (votraise)
        {
            GetComponent<SceneDialogueManager>().ResetVars();
            StartCoroutine(StartDialogueWithTimer(do_t_mechanic_raise, tsTristan, vpTristan, Faces[1], 1f));
            VOTmechanic = true;

        }
        else
        {

            GetComponent<SceneDialogueManager>().ResetVars();
            StartCoroutine(StartDialogueWithTimer(do_t_mechanic_noraise, tsTristan, vpTristan, Faces[1], 1f));
            VOTmechanic = true;
        }

        
    }
    public void OTMiner()
    {
        if (votraise)
        {
            GetComponent<SceneDialogueManager>().ResetVars();
            StartCoroutine(StartDialogueWithTimer(do_t_miner_raise, tsTristan, vpTristan, Faces[1], 2f));
            VOTmechanic = false;
        }
        else
        {
            GetComponent<SceneDialogueManager>().ResetVars();
            StartCoroutine(StartDialogueWithTimer(do_t_miner_noraise, tsTristan, vpTristan, Faces[1], 2f));
            VOTmechanic = false;

        }

 
    }

    /// Krypto Options
    public void OKRed()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(do_k_redblue, tsKrypto, vpKrypto, Faces[2], 0.2f));
        vo_k_red = true;
    }
    public void OKBlue()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(do_k_redblue, tsKrypto, vpKrypto, Faces[2], 0.2f));
        vo_k_red = false;
    }
    public void OKRadio()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(do_k_radiovstv, tsKrypto, vpKrypto, Faces[2], 0.2f));
        vo_k_radio = true;
    }
    public void OKTelevision()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(do_k_radiovstv, tsKrypto, vpKrypto, Faces[2], 0.2f));
        vo_k_radio = false;
    }
    /// Airom options
    public void OACold()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(do_a_cold, tsAirom, vpAirom, Faces[3], 1f));
        vo_a_coldshower = true;

    }
    public void OAFasting()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(do_a_fasting, tsAirom, vpAirom, Faces[3], 1f));
        vo_a_coldshower = false;

    }
    public void OASword()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(do_a_sword, tsAirom, vpAirom, Faces[3], 1f));
        vo_a_photonsword = true;

    }
    public void OAKick()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(do_a_kickboxing, tsAirom, vpAirom, Faces[3], 1f));
        vo_a_photonsword = false;

    }
    public void OAMovie()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(do_a_movie, tsAirom, vpAirom, Faces[3], 0.5f));
        vo_a_netflix = true;
        optset = 13;
        ChangeOption("Salty", "Sweet");

    }
    public void OAParty()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(do_a_party, tsAirom, vpAirom, Faces[3], 0.5f));
        vo_a_netflix = false;
        optset = 14;
        ChangeOption("Techno", "Hip Hop");

    }
    public void OAMovie_Salty()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(do_a_salt, tsAirom, vpAirom, Faces[3], 1f));
        vo_a_salt = true;

    }
    public void OAMovie_Sweet()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(do_a_sweet, tsAirom, vpAirom, Faces[3], 1f));
        vo_a_salt = false;

    }
    public void OAParty_Techno()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(do_a_techno, tsAirom, vpAirom, Faces[3], 1f));
        vo_a_techno = true;

    }
    public void OAParty_Hiphop()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(do_a_hiphop, tsAirom, vpAirom, Faces[3], 1f));
        vo_a_techno = false;

    }

    /// Mila options

    public void OMMiracles()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(d_m_1_op1, tsMila, vpMila, Faces[4], 1f));
        vo_m_miracles = true;
        optset = 17;
        ChangeOption("Yes","No");

    }
    public void OMMiraclesYes()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(d_m_1_op1_yes, tsMila, vpMila, Faces[4], 0.5f));
        vo_m_1_op1_yes = true;

    }
    public void OMMiraclesNo()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(d_m_1_op1_no, tsMila, vpMila, Faces[4], 1f));
        vo_m_1_op1_yes = false;

    }
    public void OMPredictions()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(d_m_1_op2, tsMila, vpMila, Faces[4], 1f));
        vo_m_miracles = false;
        optset = 18;
        ChangeOption("Galaxy", "Grassland");

    }
    public void OMPredictionsGalaxy()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(d_m_1_op2_galaxy, tsMila, vpMila, Faces[4], 0.5f));
        vo_m_1_op2_galaxy = false;

    }
    public void OMPredictionsGrass()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        StartCoroutine(StartDialogueWithTimer(d_m_1_op2_grassfield, tsMila, vpMila, Faces[4], 1f));
        vo_m_1_op2_galaxy = false;

    }
    public void OMChamuyo()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        if (vo_m_1_op1_yes || !vo_m_1_op2_galaxy)
        {
            
            StartCoroutine(StartDialogueWithTimer(d_m_2_op1, tsMila, vpMila, Faces[4], 1.5f));
            
        }
        else if (!vo_m_1_op1_yes || vo_m_1_op2_galaxy)
        {
            StartCoroutine(StartDialogueWithTimer(d_m_2_op1_varpredicted, tsMila, vpMila, Faces[4], 0.5f));
        }
        vo_m_2_long = true;

    }
    public void OMSimpler()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        if (vo_m_1_op1_yes || !vo_m_1_op2_galaxy)
        {

            StartCoroutine(StartDialogueWithTimer(d_m_2_op2_varpredicted, tsMila, vpMila, Faces[4], 0.5f));

        }
        else if (!vo_m_1_op1_yes || vo_m_1_op2_galaxy)
        {
            StartCoroutine(StartDialogueWithTimer(d_m_2_op2, tsMila, vpMila, Faces[4], 1.5f));
        }
        vo_m_2_long = false;

    }
    public void OMYes()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        if (!volie && !VOTignore && vo_sad)
        {

            StartCoroutine(StartDialogueWithTimer(d_m_3_yes_varpredicted, tsMila, vpMila, Faces[4], 0.5f));

        }
        else if (volie && VOTignore && !vo_sad)
        {
            StartCoroutine(StartDialogueWithTimer(d_m_3_yes_weird, tsMila, vpMila, Faces[4], 1f));
        }
        else
        {
            StartCoroutine(StartDialogueWithTimer(d_m_3_yes, tsMila, vpMila, Faces[4], 1.5f));
        }
        vo_m_3_yes = true;

    }
    public void OMNo()
    {
        GetComponent<SceneDialogueManager>().ResetVars();
        if (volie && VOTignore && !vo_sad)
        {
            StartCoroutine(StartDialogueWithTimer(d_m_3_novarpredicted, tsMila, vpMila, Faces[4], 0.5f));
        }
        else
        {
            StartCoroutine(StartDialogueWithTimer(d_m_3_no, tsMila, vpMila, Faces[4], 1.5f));
        }
        vo_m_3_yes = false;

    }
    // esto solamente son funciones cte








    IEnumerator StartDialogueWithTimer(List<string> texts, float ts, float vp, Sprite spr, float time)
    {
        yield return new WaitForSeconds(time);
        GetComponent<SceneDialogueManager>().DialogueBox.SetActive(true);
        GetComponent<SceneDialogueManager>().StartDialogue(texts, ts, vp, spr);

    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<SceneDialogueManager>().NextDialogue == true)
        {
            DialogueSorter();
            GetComponent<SceneDialogueManager>().NextDialogue = false;
        }
    }


    IEnumerator endscenetimed(float time)
    {
        yield return new WaitForSeconds(time);
        GetComponent<SceneDialogueManager>().endScene = true;
    }
    IEnumerator fadeout(float time, float time2)
    {
        yield return new WaitForSeconds(time);
        transitionAnim.SetTrigger("fadeout");
        yield return new WaitForSeconds(time2);
        transitionAnim.SetTrigger("fadein");
    }


    private void ChangeOption(string atext, string btext)
    {
        GetComponent<SceneDialogueManager>().ChangeOptionMM(atext, btext);
    }

}
