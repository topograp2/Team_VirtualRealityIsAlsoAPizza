using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextButtonHandler : MonoBehaviour
{
    public string nextSceneName;

    public void OnNextButtonClicked()
    {
        if (string.IsNullOrWhiteSpace(nextSceneName))
        {
            Debug.LogError("[NextButtonHandler] Error: 'Next Scene Name'이 비어 있습니다! 인스펙터에서 씬 이름을 설정하세요.");
            return;
        }

        string trimmedSceneName = nextSceneName.Trim();
        Debug.Log($"[NextButtonHandler] 로딩할 씬 이름: '{trimmedSceneName}'");
        SceneManager.LoadScene(trimmedSceneName);
    }
}


