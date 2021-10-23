using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class FinishedLevel : MonoBehaviour
{

    [SerializeField]
    private string nextLevelName;
    [SerializeField]
    private float timer = 2f;

    private bool levelFinished;

    private PlatformSoundFX soundFX;

    private void Awake()
    {
        soundFX = GetComponent<PlatformSoundFX>();
    }

    void LoadNewLevel()
    {
        SceneManager.LoadScene(nextLevelName);
    }

    private void OnTriggerEnter(Collider target)
    {
       if(target.CompareTag(Tags.PLAYER_TAG))
        {
            if(!levelFinished)
            {
                levelFinished = true;

                soundFX.PlayAudio(true);

                if(!nextLevelName.Equals(""))
                {
                    Invoke("LoadNewLevel", timer);
                }

            }
        }
    }




}// class
