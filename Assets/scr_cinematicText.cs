using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_cinematicText : MonoBehaviour
{
    [TextArea(3, 10)]
    public List<string> d1;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SceneDialogueManager>().StartDialogue(d1,2,0,null);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
