using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformButtonController : MonoBehaviour
{
    public MovingPlatform[] movingPlatforms;

    [SerializeField]
    private bool movePlatformsToPoinit;

    [SerializeField]
    private bool is_White_Button, is_Red_Button;

    private void OnTriggerEnter(Collider target)
    {
        if(target.CompareTag(Tags.PLAYER_TAG))
        {
            if(is_White_Button)
            {
                if(!target.GetComponent<PlayerColorController>().PLAYER_COLOR.Equals(Tags.WHITE_TAG))
                {
                    return;
                }
            } // if is white color

            if(is_Red_Button)
            {
                if(!target.GetComponent<PlayerColorController>().PLAYER_COLOR.Equals(Tags.RED_TAG))
                {
                    return;
                }
            } // if is red color

            if(!movePlatformsToPoinit)
            {
                movePlatformsToPoinit = true;

                for(int i = 0; i < movingPlatforms.Length; i++)
                {
                    movingPlatforms[i].ActivateMovement();
                }
            }
            else
            {
                movePlatformsToPoinit = false;

                for(int i =0; i<=movingPlatforms.Length; i++)
                {
                    movingPlatforms[i].ActivateMoveToInitial();
                           
                }
                

            
            }

        } // if we collided with the player

    }





}  // class
