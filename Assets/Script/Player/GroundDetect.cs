using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetect : MonoBehaviour
{
    PlayerController player;

    private void Awake()
    {
        player = gameObject.transform.root.GetComponent<PlayerController>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        
        //player.GroundedState(true);
    }

    private void OnCollisionStay(Collision collision)
    {
       
        //player.GroundedState(true);
        Debug.LogError(collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
       
        //player.GroundedState(false);
    }
}


