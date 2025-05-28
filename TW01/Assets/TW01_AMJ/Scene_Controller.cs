using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Controller : MonoBehaviour
{
    public TMP_Text PickCounts;
    public TMP_Text PutCounts;

    public void OnLoadNextScene(string sceneName)
    {
        //GameDataManager.Instance.PickCount = int.Parse(PickCounts.text);
        //GameDataManager.Instance.PutCount = int.Parse(PutCounts.text);

        SceneManager.LoadScene(sceneName);
    }
}
