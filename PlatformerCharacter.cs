using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerCharacter : MonoBehaviour
{
    Rigidbody2D rb;

    public int velocidade = 5;
    public int pulo = 5;
    public bool noChao = false;
    void OnCollisionEnter2D(Collision2D collision)
    {
        noChao = true;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        noChao = false;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }  

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal") * velocidade;
        float vertical = rb.velocity.y;

        //Debug.Log(horizontal);

        if (Input.GetButtonDown("Jump") && noChao == true)
        {
            vertical = pulo;
        }

        rb.velocity = new Vector2(horizontal, vertical);
    
    }
}