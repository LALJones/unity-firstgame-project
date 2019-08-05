using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObistcleExplode : MonoBehaviour
{
    public Material obsticaleMat;
    public float cubeSize = 0.2f;
    public int cubesInRow = 5;
    public int x = 0;
    float cubesPivotDistance;
    public float blastRadius = 5;
    Vector3 cubesPivot;
    public float force = 200;
    public BulletController bullet;

    // Start is called before the first frame update
    void Start()
    {
        //We are going to calculate the pivot distance of the whole box
        cubesPivotDistance = cubeSize * cubesInRow / 2;
        cubesPivot = new Vector3(cubesPivotDistance, cubesPivotDistance, cubesPivotDistance);
        //Now that we have th epivot disance i ntotal we cab reate pivot vector



    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Bullet")
        {
            Explode(3);
        }
    }
    public void Explode(int cubesInRow)
    {
        gameObject.SetActive(false);


        for (int x = 0; x < cubesInRow; x++)
        {
            for (int y = 0; y < cubesInRow; y++)
            {
                for (int z = 0; z < cubesInRow; z++)
                {
                    BrokenPiece(x, y, z);
                }
            }
        }

        Collider[] colliders = Physics.OverlapSphere(transform.position, blastRadius); //<-This will get an array of all colliders that are detected within the sphere. The sphere is made at  the object pos. (one of the cube s I think), then it checks within a distance of 5 for objects.
        foreach (Collider detectedCube in colliders)
        {
            Rigidbody rb = detectedCube.GetComponent<Rigidbody>(); //Now that is getting rigidbody component from each of the objects
            if (rb != null)                                         //Must make sure to check it has rigidbody because not all nearby objects will....
            {
                rb.AddExplosionForce(Random.Range(0, 20000), transform.position, blastRadius);
                    
            }



        } //Now we have an array called collliders
    }


    //Now we must make afuctnion that creates a new piece when we disbale old one!!!!

    void BrokenPiece(float x, float y, float z)
    {
        //First, make new GameObject
        GameObject broken;   //Heads up were making a game object called broken
        broken = GameObject.CreatePrimitive(PrimitiveType.Cube); //This game object needs to be a cube tell is by using GameObkect.CreatePrimite(PrimitiveeType,squareeeeee

        //Now we need to set the position and the scale for t he newly broken obkect so
        broken.transform.position = transform.position + new Vector3(cubeSize * x, cubeSize * y, cubeSize * z) - cubesPivot;
        broken.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);
        //now we need to add a rigid body and some mass to this shit ok so for the position adn scal eapperntly yo can just typ ethe gameobject.transform.scale and .pos but it appears
        // that since rigidbody isnt a default comonent then you must add it manually first using broken.AddComponent<Rigidbody>(); then to modify a certain shit in it, since its an added
        // component you still must go broken.AsddComponent<Rigidbody>().mass = 0.2f, its appear white thats kinda annoying lets fix that
        broken.AddComponent<Rigidbody>();
        broken.GetComponent<Rigidbody>().mass = cubeSize;

        //add the material color
        broken.GetComponent<Renderer>().material = obsticaleMat;
        //We only mad e a small one. But we nee d a5 x 5 so we must make a loop for spasing in
        Destroy(broken, Random.Range(0.1f, 0.5f));






    }





}
