using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fact : MonoBehaviour
{
    public Text facts;
    public int noCalls=0;
    // Start is called before the first frame update
    

    public void TextChangeBrekingInfo(){
        if(noCalls == 0){facts.text = "HELLO";}
        else if(noCalls ==1){facts.text = "How are you ";}
        else if(noCalls ==2){facts.text = "a ";}
        else if(noCalls ==3){facts.text = "b are you ";}
        else if(noCalls ==4){facts.text = "c are you ";}
        else if(noCalls ==5){facts.text = "d are you ";}
        else if(noCalls ==6){facts.text = "e are you ";}
        else if(noCalls ==7){facts.text = "f are you ";}
        else if(noCalls ==8){facts.text = "g are you ";}
        else if(noCalls ==9){facts.text = "How are you ";}
        else if(noCalls ==10){facts.text = "How are you "; noCalls = 0;}
        noCalls++;
    }
    public void TextChangeBlindSpot(){
        facts.text = "";
    }
    // Update is called once per frame
    
}
