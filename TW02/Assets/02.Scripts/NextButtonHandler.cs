using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextButtonHandler : MonoBehaviour
{
    [Header("넘어갈 씬 이름")]
    public string nextSceneName;

    public void OnNextButtonClicked()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
