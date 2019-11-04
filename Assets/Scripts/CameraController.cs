using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class CameraController : MonoBehaviour
{
    public GameObject player;        //Public variable to store a reference to the player game object
    public GameObject[] players;

    [Header("Events")]
	[Space]

    private Vector3 offset;            //Private variable to store the offset distance between the player and camera


    private void Awake(){
        string selectedPlayerName = PlayerManager.instance.playerName;
        foreach(GameObject p in players){
            if(p.name == selectedPlayerName){
                p.SetActive(true);
                player = p;
                Debug.Log(p.name);
            }
            else{
                p.SetActive(false);
            }
        }
	}
    // Use this for initialization
    void Start () 
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate () 
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = player.transform.position + offset;
    }
}
