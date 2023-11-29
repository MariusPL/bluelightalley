using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_objectText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hover()
    {

        GetComponentInParent<scr_createwords>().HoverWord(this.gameObject);

    }
    public void Click()
    {
        GetComponentInParent<scr_createwords>().AddWord();
    }
}
