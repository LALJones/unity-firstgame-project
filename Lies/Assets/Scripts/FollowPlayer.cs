
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{


    //Need referamce to the player (transform component is another datatype pretty much) it comes from the component fromthe squareee!)
    //To point which objects transform to refer to just drag the plauer into it inside inspector lylylylullulu
    //IF we WRITE TRANSFORM WITH  A LOWER CASE T it actually refers to the trasnform of the object that we are curretnly on :)
    public Transform player;
    public Vector3 offset;                              //Vector 3 is another data type like transform. A vector stores 3 floats. Therefor, its optimal to se for postions (since we have a x y and z axis.)



    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;

    }
}
