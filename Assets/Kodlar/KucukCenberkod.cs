using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KucukCenberkod : MonoBehaviour
{
    Rigidbody2D fizik;
    public float hiz;
    bool haraketKontrol = false;
    GameManager GameManager;
    
    void Start()
    {
        
        fizik = GetComponent<Rigidbody2D>();
        GameManager = FindObjectOfType<GameManager>();
    }

    void FixedUpdate()
    {
        if (!haraketKontrol)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
        }
     }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "donencembertag")
        {
            transform.SetParent(collision.transform);

            haraketKontrol = true;
        }
        if (collision.collider.tag == "donencembertag")
        {
            Destroy(fizik);
        }
        if (collision.collider.tag == "kucukcembertag")
        {
            GameManager.OyunBitti();
        }
    }
}
