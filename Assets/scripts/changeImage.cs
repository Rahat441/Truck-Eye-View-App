using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class changeImage : MonoBehaviour
{
    public Image oldImg;
    public Sprite newImg;
    public Sprite newImg2;
    public Sprite newImg3;
    public Sprite newImg4;
    public Sprite newImg5;
    public Sprite newImg6;
    public Sprite newImg7;
    public Sprite newImg8;
    public Sprite newImg9;
    public Sprite newImg10;
    public Sprite newImg11;

    public int noCalls=0;
    // Start is called before the first frame update
    

    public void TextChangeBrekingInfo(){
        if(noCalls == 0){oldImg.sprite = newImg;}
        else if(noCalls ==1){oldImg.sprite = newImg2;}
        else if(noCalls ==2){oldImg.sprite = newImg3;}
        else if(noCalls ==3){oldImg.sprite = newImg4;}
        else if(noCalls ==4){oldImg.sprite = newImg5;}
        else if(noCalls ==5){oldImg.sprite = newImg6;}
        else if(noCalls ==6){oldImg.sprite = newImg7;
        noCalls = 0;}
        
        
        noCalls++;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void imgChange(){
        oldImg.sprite = newImg;
    }
}
