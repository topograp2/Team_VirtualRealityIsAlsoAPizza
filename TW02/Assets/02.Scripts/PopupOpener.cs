using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupOpener : MonoBehaviour
{
    public GameObject popupPanel;

    public void TogglePopup()
    {
        popupPanel.SetActive(!popupPanel.activeSelf);
    }
}
