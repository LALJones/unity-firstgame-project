using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    private void OnCollisionEnter(Collision collisionInfo) //Writing collosion tlls Unity that we want soe info about the collision
    {
        if (collisionInfo.collider.tag == "Obstacle")

        {
            movement.enabled = false;
        }
        
    }
}
