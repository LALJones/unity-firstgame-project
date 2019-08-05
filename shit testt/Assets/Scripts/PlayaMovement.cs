using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayaMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;
    public int zForce;
    public int SidewaysForce = 600;

    void Start()
    {
        if (Input.GetKey("a"))
        {


        }

    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, zForce * Time.deltaTime);
        if (Input.GetKey("a")) {

            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }



    }


    //Player movement (right)




}
    