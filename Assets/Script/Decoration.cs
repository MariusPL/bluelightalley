using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//clase para las decoraciones

public class Decoration : MonoBehaviour, IComparable<Decoration> {

    public SpriteRenderer MySR { get; set; }

    public int CompareTo(Decoration other)
    {
        if (MySR.sortingOrder > other.MySR.sortingOrder)
        { return 1; }
        else if (MySR.sortingOrder < other.MySR.sortingOrder)
        { return -1; }
        else { return 0; }
    }

    // Use this for initialization
    void Start () {
        MySR = GetComponentInParent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
