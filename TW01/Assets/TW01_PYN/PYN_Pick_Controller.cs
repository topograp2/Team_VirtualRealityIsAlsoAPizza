using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PYN_Pick_Controller : MonoBehaviour
{
   int pickCount =0;
   bool isInTheArea = false;
   public GameObject UI;
    //public D13_UI_Controller UI;
   public void Increase_PickCount(GameObject Clone){
    if(isInTheArea){
        pickCount++;
        print($"pick count: {pickCount}");
        Destroy(Clone);
        UI.GetComponent<PYN_UI_Controller>().Display_PickCounts(pickCount);
    }
   }

   void OnTriggerStay(Collider other){

    if(other.name == "FPSController"){
        isInTheArea = true;
    }
   }

   void OggerExit(Collider other){
        if(other.name == "FPSController"){
        isInTheArea = false;
    }
   }
}
