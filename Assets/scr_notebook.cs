using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_notebook : MonoBehaviour
{
    public bool noteshowing;
    public bool p_page, p_selectingwords, p_editing;
    private int IndexCounter, WordC = 0;
    private int LastIndexCounter, LWordC = 0;
    private int currentline, storedlineints, laststored;
    private bool auxboolopen, isRunning1, isRunning2;
    private GameObject selected;
    private Color32 auxcolor, wordcolor;
    public List<GameObject> references;
    public scr_phone Phone;
    private int currentpage = 0;
    public GameObject PagePanel;
    public GameObject go_indexhandler;

    public List<GameObject> RawWords;

    public GameObject highlighbutton, go_edit, go_endl, go_delete, go_backtoselect;


    public scr_createwords CreateWords;

    public Text PageText;
    private List<string> dataPageText;

    public GameObject go_Next;

    public int numberOfPages = 10;
    private List<string> AuxList = new List<string>();
    private string auxstring;
    // Start is called before the first frame update
    void Start()
    {
       
        selected = references[0];
        auxcolor = selected.GetComponent<SpriteRenderer>().color;
        HighlightSelected();
        dataPageText = new List<string>();
        for (int i = 0; i < 10; i++)
        {
            string text2 = "Page " + (i+1 )+ ": " + '\n';
            dataPageText.Add(text2);

        }
        highlighbutton.SetActive(false);
        go_endl.SetActive(false);
        go_edit.SetActive(false);
        go_delete.SetActive(false);
        go_backtoselect.SetActive(false);
        


    }

    // Update is called once per frame
    void Update()
    {
       
        if (!Phone.phoneout)
        {
            if (!noteshowing)
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    ShowIndex();
                }
            }
            else
            {
                //if (p_index)
                //{
                //    if (Input.GetKeyDown(KeyCode.Z))
                //    {
                //        OpenPage(IndexCounter);

                //    }
                //    if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.X))
                //    {
                //        HideIndex();

                //    }

                //    LastIndexCounter = IndexCounter;
                //    if (Input.GetKeyDown(KeyCode.UpArrow))
                //    {

                //        if (IndexCounter > 0)
                //        {
                //            IndexCounter -= 1;
                //        }
                //    }
                //    if (Input.GetKeyDown(KeyCode.DownArrow))
                //    {

                //        if (IndexCounter < references.Count - 1)
                //        {
                //            IndexCounter += 1;
                //        }


                //    }
                //    if (LastIndexCounter != IndexCounter)
                //    {
                //        HighlightSelected();
                //    }


                //}

                 if (p_page)
                {
                    if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {

                        if (currentpage > 0)
                        {
                            currentpage -= 1;
                            OpenPage(currentpage);
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.RightArrow))
                    {

                        if (currentpage < numberOfPages - 1)
                        {
                            currentpage += 1;
                            OpenPage(currentpage);
                        }


                    }
                    if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.X))
                    {
                        HideIndex();
                        // BackToIndex();
                    }
                    if (Input.GetKeyDown(KeyCode.Z))
                    {
                        if (go_Next.activeSelf)
                        {
                            HighlightMode();
                        }
                        else
                        {
                            Debug.Log("no dialogue box!");
                        }


                    }
                    if (go_Next.activeSelf)
                    {
                        highlighbutton.SetActive(true);
                    }
                    else
                    {
                        highlighbutton.SetActive(false);
                    }
                }
                else if (p_editing)
                {
                    
                    //viejo borrar
                    //if (Input.GetKeyDown(KeyCode.A))
                    //{
                    //    p_editing = true;
                    //    auxstring = null;
                    //    AuxList.Clear();
                    //    string[] auxarray = PageText.text.Split(' ');
                    //    foreach (string word in auxarray)
                    //    {
                    //        AuxList.Add(word);
                    //    }
                    //    for (int i = 0; i < AuxList.Count - 2; i++)
                    //    {
                    //        Debug.Log(auxstring);
                    //        auxstring += AuxList[i] + ' ';
                    //    }


                    //    dataPageText[currentpage] = auxstring;
                    //    PageText.text = auxstring;

                    //}
                   if (Input.GetKeyDown(KeyCode.Z))
                    {
                        if (AuxList.Count > 3)
                        {
                            AuxList.RemoveAt(AuxList.Count - 1);

                            for (int i = 0; i < AuxList.Count - 1; i++)
                            {
                                auxstring += AuxList[i] + ' ';
                            }
                            dataPageText[currentpage] = auxstring;
                            PageText.text = auxstring;
                            ReListAux();
                            Debug.Log(AuxList.Count);


                        }
                        
                    }
                    if (Input.GetKeyDown(KeyCode.A))
                    {
                        if (AuxList.Count > 3)
                        {
                            for (int i = 0; i < AuxList.Count - 1; i++)
                            {

                                if (i == AuxList.Count - 2)
                                {
                                    auxstring += "<color=#00ff00ff>" + AuxList[i] + "</color>" + ' ';
                                }
                                else
                                {
                                    auxstring += AuxList[i] + ' ';
                                }
                            }
                            dataPageText[currentpage] = auxstring;
                            PageText.text = auxstring;
                            ReListAux();
                            Debug.Log(AuxList.Count);


                        }

                    }
                    if (Input.GetKeyDown(KeyCode.Q))
                    {
                        if (AuxList.Count > 3)
                        {
                            for (int i = 0; i < AuxList.Count - 1; i++)
                            {

                                if (i == AuxList.Count - 2)
                                {
                                    auxstring += "<color=#ff0000ff>" + AuxList[i] + "</color>" + ' ';
                                }
                                else
                                {
                                    auxstring += AuxList[i] + ' ';
                                }
                            }
                            dataPageText[currentpage] = auxstring;
                            PageText.text = auxstring;
                            ReListAux();
                            Debug.Log(AuxList.Count);


                        }

                    }
                    if (Input.GetKeyDown(KeyCode.X))
                    {
                        p_editing = false;
                        go_delete.SetActive(false);
                        go_backtoselect.SetActive(false);
                        go_endl.SetActive(true);
                        go_edit.SetActive(true);
                        
                    }

                }
                else if (p_selectingwords)
                {

                    LWordC = WordC;
                   

                    if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {

                        if (WordC > 0)
                        {
                            WordC -= 1;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.RightArrow))
                    {

                        
                        if (WordC < RawWords.Count - 1)
                        {
                            WordC += 1;
                        }


                    }
                    if (Input.GetKeyDown(KeyCode.DownArrow))
                    {



                        if (currentline < CreateWords.cWords.Count - 1)
                        {
                            Debug.Log("WordC: " + WordC + "= " + storedlineints + " + " + (CreateWords.cWords[currentline]));
                            WordC = storedlineints + CreateWords.cWords[currentline];

                        }
                        else
                        {
                            WordC = RawWords.Count -1;
                            storedlineints = WordC;
                            Debug.Log("out of range");

                        }
                    }
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {




                        if (currentline > 0 )
                        {
                            if (currentline == 1)
                            {
                                WordC = 0;
                                currentline = 0;
                                laststored = 0;
                                storedlineints = 0;
                            }
                            else
                            {
                                Debug.Log((CreateWords.cWords[currentline-2]) + " + " + storedlineints);


                                WordC = CreateWords.cWords[currentline-2];


                            }
                            
                        }
                        else
                        {
                            Debug.Log("out of range");

                        }
                    }
                    if (Input.GetKeyDown(KeyCode.S))
                    {
                        dataPageText[currentpage] += ' ';
                        dataPageText[currentpage] += '\n';
                        PageText.text += ' ';
                        PageText.text += '\n';

                    }
                    if (Input.GetKeyDown(KeyCode.A))
                    {
                        p_editing = true;
                        
                        ReListAux();
                        go_delete.SetActive(true);
                        go_backtoselect.SetActive(true);
                        go_endl.SetActive(false);
                        go_edit.SetActive(false);

                    }
                    if (Input.GetKeyDown(KeyCode.X))
                    {
                        BackToPage();
                        CreateWords.ClearCache();
                    }
                    if (Input.GetKeyDown(KeyCode.Z))
                    {

                        AddSelectedWord();

                    }
                    if (LWordC != WordC)
                    {
                        HighlightSelected();
                    }

                    if (CreateWords.cWords.Count > 0)
                    {
                        if (WordC >= (CreateWords.cWords[currentline] + storedlineints))
                        {
                            laststored = storedlineints;
                            storedlineints += CreateWords.cWords[currentline];
                            currentline++;
                        }
                        else
                        {
                            if (currentline > 1)
                            {
                                laststored = CreateWords.cWords[currentline - 2];
                                if (WordC < (CreateWords.cWords[currentline - 1] + laststored))
                                {

                                    storedlineints = laststored;
                                    currentline--;
                                }

                            }
                            else if (currentline == 1)
                            {




                                if (WordC < (CreateWords.cWords[currentline - 1]))
                                {

                                    storedlineints = 0;
                                    currentline--;
                                }
                            }


                        }

                    }
                    

                }



            }
        }

    }

    public void ReListAux()
    {
        auxstring = null;
        AuxList.Clear();

        string[] auxarray = PageText.text.Split(' ');
        foreach (string word in auxarray)
        {
            AuxList.Add(word);
        }


    }



    public void HideIndex()
    {
        if (!auxboolopen)
        {

            auxboolopen = true;
            GetComponent<Animator>().SetTrigger("hide");

            resetvars();

            if (!isRunning2)
            { StartCoroutine(wHide()); }
        }


    }

    IEnumerator wHide()
    {

        isRunning2 = true;
        yield return new WaitForEndOfFrame();
        noteshowing = false;
        p_page = false;

        yield return new WaitForSecondsRealtime(1f);

        if (auxboolopen)
        {
            auxboolopen = false;
        }
        isRunning2 = false;
    }

    public void ShowIndex()
    {
        if (!auxboolopen)
        {
            if (!isRunning1)
            { StartCoroutine(wShow()); }
            auxboolopen = true;

        }


    }

    IEnumerator wShow()
    {
        isRunning1 = true;
        GetComponent<Animator>().SetTrigger("show");
        yield return new WaitForEndOfFrame();

        noteshowing = true;
        OpenPage(currentpage);
        p_page = true;
        yield return new WaitForSecondsRealtime(1f);

        if (auxboolopen)
        {
            auxboolopen = false;
        }
        isRunning1 = false;
    }

    public void InstaOpen()
    {
        GetComponent<Animator>().SetTrigger("show");
        noteshowing = true;
        p_page = true;
    }

    private void resetvars()
    {

        IndexCounter = 0;
        WordC = 0;
        LWordC = 0;
        currentline = 0;
        storedlineints = 0;
        laststored = 0;
        
        HighlightSelected();

        LastIndexCounter = 0;
        

    }
    public void SelectedWordChange(int ID)
    {
        WordC = ID;


    }
    public void HighlightSelected()
    {
        if (p_selectingwords)
        {
            selected = RawWords[WordC];
            RawWords[LWordC].GetComponent<Text>().color = wordcolor;
            wordcolor = selected.GetComponent<Text>().color;
            selected.GetComponent<Text>().color = new Color32(255, 0, 0, 100);

        }

    }


    public void OpenPage(int id)
    {
        resetvars();
       /// esto es para q cambie sprite cuandoabris PagePanel.GetComponent<Image>().sprite = PageList[id];
        PagePanel.SetActive(true);
        go_indexhandler.SetActive(false);
        StartCoroutine(wOpenPage());
        currentpage = id;
        PageText.text = dataPageText[currentpage];
        
    }
    IEnumerator wOpenPage()
    {//para  cuando el createwords salga con z no se abra todo de una
        yield return new WaitForEndOfFrame();
        p_page = true;


    }


    public void BackToPage()
    {
        resetvars();
        RawWords.Clear();
        p_page = true;
        p_selectingwords = false;
        highlighbutton.SetActive(true);
        go_edit.SetActive(false);
        go_endl.SetActive(false);

    }

    public void AddRawWord(GameObject go_word)
    {
        RawWords.Add(go_word);

    }


    public void HighlightMode()
    {
        go_edit.SetActive(true);
        go_endl.SetActive(true);

        StartCoroutine(OpenNotes());

    }
    IEnumerator OpenNotes()
    {

        if (!noteshowing)
        {
            InstaOpen();
        }
        yield return new WaitForEndOfFrame();

        if (!p_page)
        {
            OpenPage(0);
        }
        yield return new WaitForEndOfFrame();

        resetvars();
        RawWords.Clear();
        p_page = false;
        p_selectingwords = true;
        highlighbutton.SetActive(false);

        yield return new WaitForEndOfFrame();

        CreateWords.ClearCache();
        yield return new WaitForEndOfFrame();
        CreateWords.convert();
        
        wordcolor = RawWords[0].GetComponent<Text>().color;
        resetvars();
    }

    public void AddSelectedWord()
    {
        dataPageText[currentpage] += selected.GetComponent<Text>().text;
        PageText.text += selected.GetComponent<Text>().text;

    }


}
