using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_rng : MonoBehaviour
{
    public GameObject c, t, s, x;
    // Start is called before the first frame update
    void Start()
    {
        c.SetActive(false);
        t.SetActive(false);
        s.SetActive(false);
        x.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void click()
    {
        c.SetActive(false);
        t.SetActive(false);
        s.SetActive(false);
        x.SetActive(false);
        int aux = Random.Range(0,4);
        switch (aux)
        {
            case 0:
                {
                    c.SetActive(true);
                    break;
                }
            case 1:
                {
                    t.SetActive(true);
                    break;
                }
            case 2:
                {
                    s.SetActive(true);
                    break;
                }
            case 3:
                {
                    x.SetActive(true);
                    break;
                }
        }

    }
}
