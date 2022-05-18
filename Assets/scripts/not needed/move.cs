using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Forward Script button 
public class move : MonoBehaviour
{
    
    public float speed = 10.0f;
    public float acceleration = 10.0f;
    public float rotationSpeed = 15.0f;
    public bool gas;
    public bool reverse;
    public bool left;
    public bool right;
    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        //float translation = Input.GetAxis("Vertical") * speed;
        float translation = 0;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
      
        // Make it move 10 meters per second instead of 10 meters per frame...
        // Move Forward as forward return +1
        if(gas){
            translation = forward() * speed;
            
        }
        // Move back as back() returns -1
        if(reverse){
            translation = back() * speed;
            speed += .1f;
        }
        if(left && gas){
            rotation = leftTurn() * rotationSpeed;
        }
        if(right && gas){
            rotation = rightTurn() * rotationSpeed;
        }


        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        
        transform.Translate(0, 0, translation);

        // Rotate around our y-axis
        transform.Rotate(0, rotation, 0);

        
        

    }
    // To give it hold donw funtionality 
    // Functions for forward button
    public int forward(){return 1;}
    public void onPress(){gas = true;}
    public void onRelease(){gas = false;}
    // functions for back buton 
    public int back(){return -1;}
    public void onPressReverse(){reverse = true;}
    public void onReleaseReverse(){reverse = false;}
    //functiom for left
    public int leftTurn(){return -1;}
    public void onPressLeft(){left = true;}
    public void onReleaseLeft(){left = false;}
    //functiom for left
    public int rightTurn(){return 1;}
    public void onPressRight(){right = true;}
    public void onReleaseRight(){right = false;}
   
}
