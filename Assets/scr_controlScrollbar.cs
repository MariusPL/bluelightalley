using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_controlScrollbar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GetComponent<Scrollbar>().value -= 0.1f;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Scrollbar>().value += 0.1f;
        }
    }
}
