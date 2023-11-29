using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    float speed;
    float Horizontal;
    float Vertical;
    private Rigidbody2D myrigidbody;
    public Animator anim;
    bool movingv;
    bool movingh;
    public bool talking;
    private void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        speed = 1;
        movingv = false;
        movingh = false;
        Horizontal = 0;
    }

    // Update is called once per frame

    private void Update()
    {
        speed = 1;
        movingv = false;
        movingh = false;
        anim.SetBool("Movingv", movingv);
        anim.SetBool("Movingh", movingh);

        Horizontal = 0;
        anim.SetFloat("Horizontal", Horizontal);

        Vertical = 0;
        anim.SetFloat("Vertical", Vertical);


        myrigidbody.velocity = Vector2.zero;
        if (talking)
        {
            ;
        }
        else
        {
            Horizontal = Input.GetAxisRaw("Horizontal");
            Vertical = Input.GetAxisRaw("Vertical");
        }
        

        if ((Horizontal > 0.5f || Horizontal < -0.5f) && (Vertical > 0.5f || Vertical < -0.5f))
        { speed = speed * 0.7f; }


            if (Horizontal > 0.5f || Horizontal < -0.5f ){

            myrigidbody.velocity = new Vector2(Horizontal * speed, myrigidbody.velocity.y);

            if (Horizontal < 0)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            else
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
            anim.SetFloat("Horizontal", Horizontal);


            movingh = true;

            anim.SetBool("Movingh", movingh);



        }

         if (Vertical > 0.5f || Vertical < -0.5f ){

            
            myrigidbody.velocity = new Vector2(myrigidbody.velocity.x, Vertical * speed);

            anim.SetFloat("Vertical", Vertical);

            movingv = true;

            anim.SetBool("Movingv", movingv);
        }




    }

    




}
