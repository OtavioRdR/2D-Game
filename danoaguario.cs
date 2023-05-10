using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danoaguario : MonoBehaviour
{
    Rigidbody2D rb;

    int movimento = -20;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(movimento, 0);
    }
}
