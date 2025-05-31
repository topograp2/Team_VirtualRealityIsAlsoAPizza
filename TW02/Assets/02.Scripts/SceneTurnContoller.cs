using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SC_SceneTurnContoller : MonoBehaviour
{
    public Button setting;
    public Button dictionary;

    public string SettingScene;
    public string DictionaryScene;
    public void Start()
    {
        setting.onClick.AddListener(OnSettingClick);
        dictionary.onClick.AddListener(OnDictionaryClick);
    }
    public void OnSettingClick()
    {
        SceneTracker.previousScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(SettingScene); // 세팅 씬 이름 넣기 
    }
    public void OnDictionaryClick()
    {
        SceneTracker.complete = 5; // 마지막 다 모았을 때
        SceneTracker.previousScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(DictionaryScene); // 수집 책 씬 이름 넣기 
    }
}
