using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;

    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = Vector2.right * speed;
            anim.SetBool("Correndo", true);
            transform.eulerAngles = new Vector2(0f, 0f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = Vector2.left * speed;
            anim.SetBool("Correndo", true);
            transform.eulerAngles = new Vector2(0f, 180f);
        }
        else
        {
            anim.SetBool("Correndo", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("Pulando", true);
        }
        else
        {
            anim.SetBool("Pulando", false);
        }
    }
}
