using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
   //Load Scene
    public void play()
    {
        SceneManager.LoadScene(1);
    }

  //Quit Game
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game");
    }

}
