using UnityEngine;
using System;

public class PlayerManager : MonoBehaviour{
    [HideInInspector]
    public string playerName;
    public static PlayerManager instance;

    void Awake(){
        if(instance == null){
            //DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if (instance != this){
            Destroy(gameObject);
        } 
    }

    

}
