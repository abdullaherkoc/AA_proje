using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menukontrol : MonoBehaviour
{

    public void Start()
    {
        PlayerPrefs.DeleteAll();
    }
    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }
    public void oyunagit()
    {
        int kayıtlılevel = PlayerPrefs.GetInt("kayıt");
        if (kayıtlılevel == 0)
        {
            SceneManager.LoadScene(kayıtlılevel + 1);

        }
        else
        {
            SceneManager.LoadScene(kayıtlılevel);
        }

    }


    public void oyundancik()
    {
        Application.Quit();
    }
}
