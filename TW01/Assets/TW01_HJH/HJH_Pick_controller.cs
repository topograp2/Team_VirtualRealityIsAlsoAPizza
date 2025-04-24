using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HJH_Pick_controller : MonoBehaviour
{
    bool isInTheArea = false;
    public GameObject Container;
    public GameObject UI_Controller;

    private void Start()
    {
        Container.SetActive(false);
    }

    public void OnHeartClicked(GameObject Heart)
    {
        if (isInTheArea)
        {
            UI_Controller.GetComponent<HJH_D12_UI_Controller>().Increase_PickCounter();
            Destroy(Heart);
        }
        else
        {
            print("out of pick area");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "FPSController")
        {
            isInTheArea = true;
            Container.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "FPSController")
        {
            isInTheArea = false;
            Container.SetActive(false);
        }
    }
}
