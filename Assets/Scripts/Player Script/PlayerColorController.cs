using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerColorController : MonoBehaviour
{

    public string PLAYER_COLOR = "";

    public Material GetMaterial;

    public GameObject Sheep;

     void Start()
    {
        PLAYER_COLOR = Tags.WHITE_TAG;

    }

    private void OnTriggerEnter(Collider target)
    {
       if(target.gameObject.tag == "Player")
        {
            Sheep.GetComponent<Renderer>().material = GetMaterial;
        }
    }


}

