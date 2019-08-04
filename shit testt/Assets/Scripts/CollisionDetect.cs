using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class CollisionDetect : MonoBehaviour
{

    public PlayaMovement movement;
     void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }
}
