using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Transform[] childrem;

    [SerializeField]
    private bool deactivateInStart;




    void Start()
    {
        childrem = transform.GetComponentsInChildren<Transform>();    

        if(deactivateInStart)
        {
            OpenDoors();
        }


    }

   public void OpenDoors()
    {
        foreach(Transform c in childrem)
        {
            if(c.CompareTag(Tags.DOOR_TAG))
            {
                c.gameObject.GetComponent<Collider>().isTrigger = true;
            }
        }
    }
    
}
