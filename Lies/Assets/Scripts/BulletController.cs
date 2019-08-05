using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;
    public float bulletSpeed = 40000f;
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("Helllo");
        rb.AddForce(0, 0, bulletSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            gameObject.SetActive(false);
        }
    }
}
