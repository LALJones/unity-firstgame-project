
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public GunController theGun;
    public GameObject Guard1;
    public GameObject Guard2;

    void FixedUpdate()
    {

         
        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //Only executed if the condition is met :>
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } //FixedUpdate is always slower so beaware and cn be missed.


        if(gameObject.transform.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    } //ForceMode, ignores mass(anoyig momentum so you can change direction quicker.


    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse1))
        {
            theGun.isFiring = true;
        }
        if(Input.GetKeyUp(KeyCode.Mouse1))
        {
            theGun.isFiring = false;
        }


    }
}