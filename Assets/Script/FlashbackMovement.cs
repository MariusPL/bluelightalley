using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashbackMovement: MonoBehaviour
{

    public float speed;
    float Horizontal;
    float Vertical;
    private Rigidbody2D myrigidbody;
    private void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        Horizontal = 0;
    }

    // Update is called once per frame

    private void Update()
    {
        Horizontal = 0;


        Vertical = 0;



        myrigidbody.velocity = Vector2.zero;

            Horizontal = Input.GetAxisRaw("Horizontal");




        if (Horizontal > 0.5f || Horizontal < -0.5f)
        {

            myrigidbody.velocity = new Vector2(Horizontal * speed, myrigidbody.velocity.y);

        }

        else if (Vertical > 0.5f || Vertical < -0.5f)
        {


            myrigidbody.velocity = new Vector2(myrigidbody.velocity.x, Vertical * speed);
        }




    }






}
