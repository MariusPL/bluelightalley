using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scr_optman : MonoBehaviour
{
    public GameObject A, B;
    public GameObject Alight, Blight;
    public Text textA, textB;
        private Color32 aux;
    private int select;
    public scr_phone Phone;
    public GameObject goDialogueManager;
    // Start is called before the first frame update
    void Start()
    {
        aux = A.GetComponent<Image>().color;
        select = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Phone.phoneout)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SelectA();
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                SelectB();
            }


            if (Input.GetKeyDown(KeyCode.Z))
            {
                ConfirmSelect();
            }
        }
        


    }


    public void ChangeName(string atext, string btext)
    {
        textA.text = atext;
        textB.text = btext;
    }

    public void ConfirmSelect()
    {
        if (select == 1)
        {
            goDialogueManager.GetComponent<scChapter1>().OptionSorter(true);

        }
        else if (select == 2)
        {
            goDialogueManager.GetComponent<scChapter1>().OptionSorter(false);

        }
        ResetSelect();

    }

    public void SelectA()
    {
       // A.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Alight.SetActive(true);
        Blight.SetActive(false);
        B.GetComponent<Image>().color = aux;
        select = 1;

    }

    public void SelectB()
    {
      //  B.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Alight.SetActive(false);
        Blight.SetActive(true);
        A.GetComponent<Image>().color = aux;
        select = 2;
    }

    public void ResetSelect()
    {
        A.GetComponent<Image>().color = aux;
        B.GetComponent<Image>().color = aux;
        Alight.SetActive(false);
        Blight.SetActive(false);
        select = 0;
    }
}
