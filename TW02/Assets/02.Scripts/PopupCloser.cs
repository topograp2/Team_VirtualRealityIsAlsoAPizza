using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupCloser : MonoBehaviour
{
    public GameObject popupPanel;

    public void ClosePopup()
    {
        popupPanel.SetActive(false);
    }
}
