using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Rigidbody rb;
    private void Start()
    {
        rb.freezeRotation = true;
    }
    private void OnCollisionEnter(Collision collisionInfo) //Writing collosion tlls Unity that we want soe info about the collision
    {
        if (collisionInfo.collider.tag == "Obstacle")

        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
            
        }
        if(collisionInfo.collider.tag == "Wood")
        {
            rb.freezeRotation = false;
        }
        
    }
}
