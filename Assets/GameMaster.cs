using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;


[System.Serializable]
public class GameMaster : MonoBehaviour {
    static public int daycount, repD, repT, repF, repI;
    /// <summary>
    /// ALL THE FUCKING GAME OBJECTS OSEA NPCS VAN ACA XDDDD
    /// </summary>

     public List<GameObject> NPCPool;

    public List<GameObject> ActiveNPCS;

    public Queue<string> GOnames;

     public bool nextweek;

	// Use this for initialization
	void Start () {
        ActiveNPCS = NPCPool;
        if (ActiveNPCS!=null)
        {
            GOnames = new Queue<string>() ;
            foreach (GameObject go in ActiveNPCS)
            {
                GOnames.Enqueue(go.name);

            }
        }
        sActivePool.ActivePool = GOnames;
        repD = 0;
        repT = 0;
        repF = 0;
        repI = 0;
	}


    public void WashRep()
    {
        daycount = 0;
        
        repD = 0;
        repT = 0;
        repF = 0;
        repI = 0;
        
        nextweek = true;




    }
    // Update is called once per frame
    void Update () {
        if (daycount==0) {
            Debug.Log("nextweek");
            PassDay();
            nextweek = false;
        }
	}

    public void D(){  repD+=1; }
    public void T() { repT+=4; }
    public void F() { repF+=2; }
    public void I() { repI+=3; }

    public void DB()
    {
    }

    public void PassDay()
    {
        //if (daycount == 3) { if (CheckNPC("Akyro Jin") && CheckNPC("Trash")) { FindObjectOfType<Cutscenes>().StartLoadScene("AkyroJinTrash"); } }
        //if (daycount == 4) { if (CheckNPC("Midlight Blossom")) { FindObjectOfType<Cutscenes>().StartLoadScene("MidlightBlossom"); } }
        daycount++;
        ReviveNPCs();
        Debug.Log("GM daycount: " + daycount);
        




        if (daycount == 7)
        {
            FindObjectOfType<Cutscenes>().StartLoadScene("TrialDay");
        }


    }

    public void ReviveNPCs()
    {
        foreach (GameObject go in ActiveNPCS)
        {
            if (!go.activeSelf)
            {
                go.SetActive(true);
            }
        }
    }

    public bool CheckNPC(string cmprname)
    {
        foreach (GameObject go in ActiveNPCS)
        {
            Debug.Log(go.name);
            if (go.name.Equals(cmprname))
            {
                return true;
            }
            else {;}
        }
        return false;

    }




}




