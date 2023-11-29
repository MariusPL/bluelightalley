using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//clase para sortear weas


public class LayerSorter : MonoBehaviour {

    private List<Decoration> decorations = new List<Decoration>();
    private SpriteRenderer R;
	// Use this for initialization
	void Start () {
        R = transform.GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Decoration")
        {
            Decoration d = collision.GetComponent<Decoration>();

            if (decorations.Count == 0 || d.MySR.sortingOrder - 1 < R.sortingOrder)
            { R.sortingOrder = d.MySR.sortingOrder - 1; }
            else
            { }
            decorations.Add(d);
            
        }
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Decoration")
        {
            Decoration d = collision.GetComponent<Decoration>();
            decorations.Remove(d);
            if (decorations.Count == 0)
            { R.sortingOrder = 50; }
            else
            {
                decorations.Sort();
                R.sortingOrder = decorations[0].MySR.sortingOrder - 1;
            }
            
        }
    }
}
