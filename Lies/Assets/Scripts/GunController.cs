using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{



    public bool isFiring; // simply asking is it firing yes or no.

    public BulletController bullet; //refers to the bullet controller script

    public float bulletSpeedd; //spped of bullet

    public float timeBetweenShots; //The delay between shoots
    private float shotCounter;

    public Transform firepoint; //(Where we will fire the bullets from!)



    // Start is called before the first frame update
    void Start()
    {
        isFiring = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFiring == true)
        {
            shotCounter -= Time.deltaTime;
            if(shotCounter <=0)
            {
                shotCounter = timeBetweenShots;
                BulletController newBullet = Instantiate(bullet, firepoint.position, firepoint.rotation) as BulletController;
                newBullet.bulletSpeed = bulletSpeedd;


                Destroy(newBullet, 1f);
    
                  
            }



        }
    }
}
