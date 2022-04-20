using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject donencember;
    public GameObject anacember;
    public Animator animator;
    public Text donencemberlevel;
    public Text cembertext1;
    public Text cembertext2;
    public Text cembertext3;
    public int kactanekucukcember;
    private bool oyunBitti =false;

    public void Start()

    {

        PlayerPrefs.SetInt("kayıt", int.Parse(SceneManager.GetActiveScene().name));


        donencember = GameObject.FindGameObjectWithTag("donencembertag");
        anacember = GameObject.FindGameObjectWithTag("anacembertag");
        donencemberlevel.text = SceneManager.GetActiveScene().name;

        if (kactanekucukcember < 2)
        {
            cembertext1.text = kactanekucukcember + "";

        }
        else if (kactanekucukcember < 3)
        {
            cembertext1.text = kactanekucukcember + "";
            cembertext2.text = (kactanekucukcember - 1) + "";

        }
        else
        {
            cembertext1.text = kactanekucukcember + "";
            cembertext2.text = (kactanekucukcember - 1) + "";
            
        }

    }
    public void KucukCemberdeTextGosterme()
    {
        kactanekucukcember--;
        if (kactanekucukcember < 2)
        {
            cembertext1.text = kactanekucukcember + "";
            cembertext2.text = "";
           
        }
        else if (kactanekucukcember < 3)
        {
            cembertext1.text = kactanekucukcember + "";
            cembertext2.text = (kactanekucukcember - 1) + "";
            
        }
        else
        {
            cembertext1.text = kactanekucukcember + "";
            cembertext2.text = (kactanekucukcember - 1) + "";
            
        }

        if (kactanekucukcember == 0)
        {
            donencember.GetComponent<Dondurme>().enabled = false;
            anacember.GetComponent<AnaCember>().enabled = false;
            NextLevel();
        }
    }

    public void NextLevel()
    {
        if (oyunBitti)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            sceneIndex++;
            sceneIndex = sceneIndex % 10;
            SceneManager.LoadScene(sceneIndex);
        }
    }

    public void OyunBitti()
    {
        oyunBitti = true;
        animator.SetTrigger("oyun bitti");
        if (!oyunBitti)
        {
        GetComponent<Menukontrol>().oyundancik();
        }
        

    }

    public void MenuyeDon()
    {
        donencember.GetComponent<Dondurme>().enabled = false;
        anacember.GetComponent<AnaCember>().enabled = false;
        SceneManager.LoadScene("Menu");
    }

}
