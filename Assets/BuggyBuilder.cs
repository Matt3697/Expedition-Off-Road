using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class BuggyBuilder : MonoBehaviour{
    void Awake(){
        FindObjectOfType<AudioManager>().Play("MenuSound");
    }
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void backToMainMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}