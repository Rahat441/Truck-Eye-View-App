using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class AxleInfo {
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor;
    public bool steering;
}           // Making wheel coliders so we can selsct each wheel seperately 
     
public class exampleMove : MonoBehaviour {
    public List<AxleInfo> axleInfos; 
    public float maxMotorTorque;
    public float maxSteeringAngle;
    //for buttons 
    public bool gas;
    public bool reverse;
    public bool left;
    public bool right;
    public bool seatBelt = false;
    public bool checkMirror = false;
    public bool startCar = false;
    
     
    // finds the corresponding visual wheel
    // correctly applies the transform
    
    public void ApplyLocalPositionToVisuals(WheelCollider collider)
    {
        if (collider.transform.childCount == 0) {
            return;
        }
     
        Transform visualWheel = collider.transform.GetChild(0);    
     
        Vector3 position;
        Quaternion rotation;
        collider.GetWorldPose(out position, out rotation);
     
        visualWheel.transform.position = position;
        visualWheel.transform.rotation = rotation;

        //For BRAKE CHANGE 
    }
    
    
     
    public void FixedUpdate()
    {   
        //MOVEMENT takes a 1/-1 value from getAXis and transforms object
        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");        // GetAxis returns 1/-1 depending on the input from keyboard 
        //MOVEMENT WITH BUTTONS 
        
        
        //Instead of getting input from keyboard we want input from buttons 
        if(seatBelt){
            if(checkMirror){
                if(startCar){
                    if(gas){   motor = forward() * maxMotorTorque;}
                    if(reverse){  motor = back() * maxMotorTorque;}
                    if(left){   steering = maxSteeringAngle * leftTurn();}
                    if(right){   steering = maxSteeringAngle * rightTurn();}
                }
            }
        }
      
        if(Input.GetKey(KeyCode.Space)){
             
            transform.position = new Vector3(254.3f, 20.3f, 167.8f);
            
            }
            
          //  if(motor >= 20 ){motor = -3f * maxMotorTorque ;}
        
            
        
       
// Applies changed values of ottor after taking input from user and transforms the value and object 
        foreach (AxleInfo axleInfo in axleInfos) {
            if (axleInfo.steering) {
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;
            }
            if (axleInfo.motor) {
                axleInfo.leftWheel.motorTorque = motor;
                axleInfo.rightWheel.motorTorque = motor;
            }
             
            ApplyLocalPositionToVisuals(axleInfo.leftWheel);
            ApplyLocalPositionToVisuals(axleInfo.rightWheel);
        }
    }
    //For BUTTONS Movements pressing buttons returns  bools which calls function forward which returns one to move 
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

    //Safety check Like seatbel bool
    public void seatCheck(){
        seatBelt = true;
    }
    public void mirrorCheck(){
        checkMirror = true;
    }
    public void start(){
        startCar = true;
    }
    public void goToMenu()
    {
        SceneManager.LoadScene("menu");
    }


    
}