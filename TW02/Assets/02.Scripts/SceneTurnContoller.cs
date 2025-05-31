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
        SceneManager.LoadScene(SettingScene); // ���� �� �̸� �ֱ� 
    }
    public void OnDictionaryClick()
    {
        SceneTracker.complete = 5; // ������ �� ����� ��
        SceneTracker.previousScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(DictionaryScene); // ���� å �� �̸� �ֱ� 
    }
}
