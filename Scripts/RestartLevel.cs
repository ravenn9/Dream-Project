using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
   public void RestartButton() 
    {
        SceneManager.LoadScene("0.1");
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
            Debug.Log("Oyundan Çýktýn.");
        }
    }
}
