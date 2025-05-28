using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneControl : MonoBehaviour
{
  
    public void OnClick_LoadScene(Object SceneObject)
    {
        SceneManager.LoadScene(SceneObject.name);
    }
}
