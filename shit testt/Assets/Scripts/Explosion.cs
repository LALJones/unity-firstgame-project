using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public Material alive;
    public Material alive2;
    public float cubeSize = 0.2f;
    public int cubesInRow = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            explode();
            brokenPiece();
        }
    }
    public void explode()
    {
        gameObject.SetActive(false);
    }

    //Now we must make afuctnion that creates a new piece when we disbale old one!!!!

    void brokenPiece(int x, int y, int z)
    {
        //First, make new GameObject
        GameObject broken;   //Heads up were making a game object called broken
        broken = GameObject.CreatePrimitive(PrimitiveType.Cube); //This game object needs to be a cube tell is by using GameObkect.CreatePrimite(PrimitiveeType,squareeeeee

        //Now we need to set the position and the scale for t he newly broken obkect so
        broken.transform.position = transform.position;
        broken.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);

        //now we need to add a rigid body and some mass to this shit ok so for the position adn scal eapperntly yo can just typ ethe gameobject.transform.scale and .pos but it appears
        // that since rigidbody isnt a default comonent then you must add it manually first using broken.AddComponent<Rigidbody>(); then to modify a certain shit in it, since its an added
        // component you still must go broken.AsddComponent<Rigidbody>().mass = 0.2f, its appear white thats kinda annoying lets fix that
        broken.AddComponent<Rigidbody>();
        broken.GetComponent<Rigidbody>().mass = cubeSize;

        //add the material color
        broken.GetComponent<Renderer>().material = alive;
        //We only mad e a small one. But we nee d a5 x 5







    }





}
