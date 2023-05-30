using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour
{
    // Start is called before the first frame update
    public float fuerzaSalto;
    private Rigidbody2D rb2d;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space)) 
        {
            animator.SetBool("estaSaltando",true);
            rb2d.AddForce(new Vector2(0,fuerzaSalto));
        
        } 
    }

    //para ver si choca

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Suelo")
        {
            animator.SetBool("estaSaltando", false);
        }
    }

}
