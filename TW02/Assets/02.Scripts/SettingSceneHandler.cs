using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SettingSceneHandler : MonoBehaviour, IPointerClickHandler
{
    private string previousScene;

    [Header("BackButton 이미지 오브젝트")]
    public GameObject backButtonImage;

    void Start()
    {
        previousScene = PlayerPrefs.GetString("PreviousScene", "");
    }

    public void OnRestartMission()
    {
        SceneTracker.complete = 0;
        SceneManager.LoadScene("OnBoarding");
    }

    public void QuitApp()
    {
        Debug.Log("앱 종료 시도됨");
        Application.Quit();
    }

    public void GoBackToPreviousScene()
    {
         if (!string.IsNullOrEmpty(SceneTracker.previousScene))
    {
        SceneManager.LoadScene(SceneTracker.previousScene);
    }
        else
        {
            Debug.LogWarning("이전 씬 정보가 없습니다.");
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerCurrentRaycast.gameObject == backButtonImage)
        {
            GoBackToPreviousScene();
        }
    }
}
