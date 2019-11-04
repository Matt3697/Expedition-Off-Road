using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    private bool isMoving = false;
	private bool engineStart = true;

    // Update is called once per frame
    void Update()
    {
       horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
    }

    void FixedUpdate(){
        float move = horizontalMove * Time.fixedDeltaTime;
        controller.Move(move, false);

        //if game starts and user elects to move, play engine run
		if(move != 0 && engineStart == true && FindObjectOfType<AudioManager>().Playing("engineRun") == false){
			engineStart = false;
			FindObjectOfType<AudioManager>().StopPlaying("engineStart");
			FindObjectOfType<AudioManager>().Play("engineRun");
		}
		//otherwise keep playing engine idle
		else{
            if(FindObjectOfType<AudioManager>().Playing("engineIdle") == false){
			    FindObjectOfType<AudioManager>().Play("engineIdle");
            }
            else{
                return;
            }
		}

        //if we are moving and the engineRun isn't already playing
		if(move != 0){
			if(FindObjectOfType<AudioManager>().Playing("engineRun") == false){
 			    FindObjectOfType<AudioManager>().Play("engineRun"); 
            }
            else{
                return;
            }
		}
        //if move is 0, turn off the engineRun sound if it is playing and play idle.
		else{
            if(FindObjectOfType<AudioManager>().Playing("engineRun") == true){
                FindObjectOfType<AudioManager>().StopPlaying("engineRun");
                FindObjectOfType<AudioManager>().Play("engineIdle");
            }
            else if(FindObjectOfType<AudioManager>().Playing("engineIdle") == false){
                FindObjectOfType<AudioManager>().Play("engineIdle");
            }
            else{
                return;
            }
		}
    }
}
