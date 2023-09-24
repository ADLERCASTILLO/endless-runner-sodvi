using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour
{
    public float fuerzaSalto;
    private Rigidbody2D rigidbody2D;
    private Animator animator;
    private Boolean jumping;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); //recbe componente animator
        rigidbody2D = GetComponent<Rigidbody2D>();
        jumping = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && jumping==false)
        {
            animator.SetBool("estaSlatando", true);
            jumping = true;
            rigidbody2D.AddForce(new Vector2(0,fuerzaSalto));
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag=="Suelo") 
        {
            animator.SetBool("estaSlatando", false);
            jumping = false;
        }
    }
}
