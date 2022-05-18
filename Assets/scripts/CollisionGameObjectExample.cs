using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionGameObjectExample : MonoBehaviour
{
    //Detect collisions between the GameObjects with Colliders attached
     private void OnCollisionEnter(Collision other)
    {
        // Print how many points are colliding with this transform
        Debug.Log("Points colliding: ");

        // Print the normal of the first point in the collision.

    }

    
}
