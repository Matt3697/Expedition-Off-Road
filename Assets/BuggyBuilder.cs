using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class BuggyBuilder : MonoBehaviour
{
    public string playerName;
    public static BuggyBuilder instance;

    void Awake(){
        if(instance == null){
            instance = this;
        }
        else{
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        
        FindObjectOfType<AudioManager>().Play("MenuSound");
    }
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void backToMainMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void playerSelect(string name){
        playerName = name;
    }
    public string getPlayer(){
        if(playerName == null){
            return "rzrOp1";
        }
        return this.playerName;
    }
}
