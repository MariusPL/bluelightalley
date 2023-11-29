using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scr_createwords : MonoBehaviour
{
    public string[] sentences;
    private string[] auxstrarray;
    private bool hasEndl;

    public Transform textPlacer;
    public Transform textPrefab;

    public float linespace;
    public int paragraphwidth;

    private float lastGoEnd;
    private bool auxbool;
    private int line;

    private float textareaW;
    private float textareaH;

    public scr_notebook Note;




    public List<int> cWords;


    public GameObject Noteblock;
    private List<GameObject> cache;

    // Start is called before the first frame update
    void Start()
    {
        Note = Noteblock.GetComponent<scr_notebook>();
        cache = new List<GameObject>();
        cWords = new List<int>();

        textareaH = GetComponent<RectTransform>().sizeDelta.y;
        textareaW = GetComponent<RectTransform>().sizeDelta.x;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void convert()
    {

        lastGoEnd = 0;
        line = 0;
        
        sentences = GetComponent<Text>().text.Split(' ');
       
        cWords.Add(0);
        foreach (string word in sentences)
        {
            
            
            hasEndl = false;
            foreach (char c in word)
            {
                if (c == '\n')
                {
                    
                    auxstrarray = word.Split('\n');
                    hasEndl = true;
                }
            }

            if (hasEndl)
            {
                int iterator = 0;
                foreach (string auxword in auxstrarray)
                {

                    
                    Debug.Log(iterator);
                    Debug.Log(auxword);
                    GameObject auxgo = Instantiate(textPrefab.gameObject, textPlacer);
                    auxgo.GetComponent<Text>().text = auxword + ' ';

                    float wFC = auxgo.GetComponent<Text>().preferredWidth / 2;
                    float hFC = auxgo.GetComponent<Text>().preferredHeight / 2;
                    auxgo.transform.SetParent(textPlacer.transform);


                    Vector2 auxvect = Vector2.zero;

                    if (iterator == 0)
                    {

                        
                        auxvect.x -= textareaW / 2;
                        auxvect.y += (textareaH / 2) - hFC - (line * linespace);
                        auxvect.x += lastGoEnd + wFC;



                    }
                    else
                    {
                        Debug.Log("line: " + line + ", wordcount: " + cWords[line]);
                        auxvect = Vector2.zero;
                        line++;
                        cWords.Add(0);
                        lastGoEnd = 0;
                        auxvect.x -= (textareaW / 2) - wFC;

                        auxvect.y += (textareaH / 2) - hFC - (line * linespace);
                        
                        
                    }



                    auxgo.GetComponent<RectTransform>().localPosition = auxvect;



                    Note.AddRawWord(auxgo);
                    cache.Add(auxgo);

                    lastGoEnd += (wFC * 2);
                    iterator++;
                    cWords[line]++;
                }


            }
            else
            {
                
                GameObject go = Instantiate(textPrefab.gameObject, textPlacer);
                go.GetComponent<Text>().text = word + ' ';


                //     auxvector2.x = go.GetComponent<Text>().preferredWidth;

                float wFC = go.GetComponent<Text>().preferredWidth / 2;
                float hFC = go.GetComponent<Text>().preferredHeight / 2;
                go.transform.SetParent(textPlacer.transform);




                Vector2 auxvect = Vector2.zero;
                auxvect.x -= textareaW / 2;
                auxvect.y += (textareaH / 2) - hFC - (line * linespace);

                auxvect.x += lastGoEnd + wFC;
                if (textareaW / 2 < auxvect.x + wFC)
                {
                    Debug.Log("line: " + line + ", wordcount: " + cWords[line]);
                    auxvect = Vector2.zero;
                    line++;
                    cWords.Add(0);
                    lastGoEnd = 0;
                    auxvect.x -= (textareaW / 2) - wFC;

                    auxvect.y += (textareaH / 2) - hFC - (line * linespace);
                    
                }
                go.GetComponent<RectTransform>().localPosition = auxvect;





                Note.AddRawWord(go);
                cache.Add(go);
                cWords[line]++;



                //auxvect.x = go.GetComponent<Renderer>().bounds.size.x/2;
                // auxvect.y = (go.GetComponent<Renderer>().bounds.size.y/2) * -1;
                // go.GetComponent<BoxCollider2D>().cebter = auxvect;
                //if (lastGoSize > 1000)
                //  {
                //      line -= linespace;
                //       lastGoSize = 0;

                //   }
                //    else
                //   {
                lastGoEnd += (wFC * 2);
                //  }
            }


        }
        Debug.Log("line: " + line + ", wordcount: " + cWords[line]);
    }





    public void AddWord()
    {
        Note.AddSelectedWord();
    }
    public void HoverWord(GameObject word)
    {
        int i = 0;
        foreach (GameObject go in cache)
        { 
            if (go == word)
            {
                Note.SelectedWordChange(i);
                break;
            }
            i++;
        }
        Note.HighlightSelected();
    }

    public void ClearCache()
    {

        if (cache.Count > 0)
        {
            foreach (GameObject go in cache)
            {
                Destroy(go);
            }
            cache.Clear();
        }

        if (cWords.Count > 0)
        {
            cWords.Clear();

        }

    }







    





}
