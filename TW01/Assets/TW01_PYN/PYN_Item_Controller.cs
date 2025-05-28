using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PYN_Item_Controller : MonoBehaviour
{
    public GameObject Pick_Controller;
private void OnMouseDown() {
    
    print($"{gameObject.name}clicked.");
    Pick_Controller.GetComponent<PYN_Pick_Controller>().Increase_PickCount(gameObject);


}
}
