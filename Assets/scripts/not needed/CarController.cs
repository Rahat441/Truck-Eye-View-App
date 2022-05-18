using UnityEngine;
using System.Collections;
using System.Collections.Generic;


     
public class CarController : MonoBehaviour {
    public float speed;
    public float rotationSpeed;
     
     void Update(){
        //Move front and back 
         if(Input.GetKey(KeyCode.Space)){Debug.Log("HIT");}
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;


        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);

        // Rotate around our y-axis
        transform.Rotate(0, rotation, 0);

    }
}