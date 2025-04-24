using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HJH_Heart_Controller : MonoBehaviour
{
    public GameObject Pick_Controller;
    //public GameObject UI_Controller;

    private void OnMouseDown()
    {
        Pick_Controller.GetComponent<HJH_Pick_controller>().OnHeartClicked(gameObject);
        print($"clicked {gameObject.name}");
    }
}
