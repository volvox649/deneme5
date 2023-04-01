using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void starButton()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);



    }
    public void quit()

    {
         Application.Quit();
        Debug.Log("Quitted");



    }

     
}
