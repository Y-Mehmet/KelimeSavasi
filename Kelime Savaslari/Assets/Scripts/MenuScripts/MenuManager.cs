using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
   
    public void ChangeSceen(){
        
        SceneManager.LoadScene("Game");
    }
    public void ChangeSceenToScore(){
        SceneManager.LoadScene("ScoreTable");
    }
    public void QuitGame()
    {
        Application.Quit(); // Uygulamayı kapat
    }
}
