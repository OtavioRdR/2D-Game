using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EightDirection : MonoBehaviour
{
    Rigidbody2D rb;

    int velocidade = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Udate é chamado sempre
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        rb.velocity = new Vector2(horizontal, vertical) * velocidade;
    }

}
