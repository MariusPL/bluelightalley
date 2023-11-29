using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptFLucky : MonoBehaviour {

    public GameObject triggeringObj;
    // Use this for initialization
    private GameObject Receptor;
    private bool grabbedf;
    private SpriteRenderer parentRenderer;

    public List<Sprite> imgs;
    public GameObject flower, flowerfell, dumbass1, dumbass2,bitch,witch,text;


    void Start () {
        parentRenderer = transform.GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {

        
      


    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.name == "Flower")
        {
            
            triggeringObj = other.gameObject;
            flower.SetActive(false);
            parentRenderer.sprite = imgs[0];
            grabbedf = true;
           
        }
        if (other.gameObject.name == "Bitch")
        {
            if (grabbedf)
            {
                triggeringObj = other.gameObject;
                flowerfell.SetActive(true);
                parentRenderer.sprite = imgs[1];
                dumbass1.GetComponent<SpriteRenderer>().sprite = imgs[2];
                dumbass2.GetComponent<SpriteRenderer>().sprite = imgs[3];
                text.SetActive(true);
                StartCoroutine(Couroutine1());
                
            }
            

        }

    }

    IEnumerator Couroutine1()
    {
        
        yield return new WaitForSecondsRealtime(1.5f);
        bitch.SetActive(false);
        witch.SetActive(true);
        text.SetActive(false);


    }

}
