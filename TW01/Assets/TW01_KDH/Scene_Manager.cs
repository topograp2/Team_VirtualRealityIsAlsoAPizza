using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    public void ReloadScene()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadTargetScene()
    {
        SceneManager.LoadScene("BY_HomeScene"); 
    }


}
