using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public int pontuacao = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.CompareTag("COXINHA") ) 
        {
            pontuacao += 1;
            Destroy(collision.gameObject);
        }

        // Destroy(gameobject);
        // Debug.Log("ENCOSTOU EM UM OBJETO DE GATILHO!");
    }    
}    