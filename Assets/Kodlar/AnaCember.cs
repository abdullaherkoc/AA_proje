using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaCember : MonoBehaviour
{
    public GameObject kucukCember;
    GameManager GameManager;
    void Start()
    {
        GameManager = FindObjectOfType<GameManager>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown("space")||Input.GetMouseButtonDown(0))
        {
            kucukCemberOlustur(); 
        }
    }
    void kucukCemberOlustur()
    {
        Instantiate(kucukCember, transform.position, transform.rotation);
        GameManager.KucukCemberdeTextGosterme();
    
    }

  
}
