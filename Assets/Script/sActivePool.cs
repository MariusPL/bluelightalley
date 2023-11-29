using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sActivePool : MonoBehaviour {
    static public Queue<string> ActivePool;
	// Use this for initialization
	void Start () {

        

    }
	
	// Update is called once per frame
	void Update () {


    }

    public bool CheckNPC(string cmprname)
    {
        foreach (string str in ActivePool)
        {
            if (str.Equals(cmprname))
            {
                return true;
            }
            else {; }
        }
        return false;

    }


}
