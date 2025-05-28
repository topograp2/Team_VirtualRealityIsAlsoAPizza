using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YJH_Heart_Controller : MonoBehaviour
{
    public GameObject Pick_Controller;
    //public GameObject UI_Controller;

    private void OnMouseDown()
    {
        Pick_Controller.GetComponent<YJH_Pick_Controller>().OnHeartClicked(gameObject);
        print($"clicked {gameObject.name}");
    }
}
