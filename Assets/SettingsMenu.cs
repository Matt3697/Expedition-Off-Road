using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{

    public void QuitToMainMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void playClick(){
        FindObjectOfType<AudioManager>().Play("buttonClick");
    }

    public void enableObject(GameObject obj){
        obj.SetActive(true);
    }

    public void disableObject(GameObject obj){
        obj.SetActive(false);
    }

    public void disablePlayer(){
        FindObjectOfType<CameraController>().getPlayer().SetActive(false);
    }
    public void enablePlayer(){
        FindObjectOfType<CameraController>().getPlayer().SetActive(true);
    }
}
