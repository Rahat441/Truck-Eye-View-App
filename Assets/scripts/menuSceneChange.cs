using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuSceneChange : MonoBehaviour
{
  
    // Update is called once per frame
    public void changeScene()
    {
        SceneManager.LoadScene("movePhysicsNYC");
    }
}
