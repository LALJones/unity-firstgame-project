using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayaMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;
    public int zForce;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, zForce * Time.deltaTime);
    }
}
