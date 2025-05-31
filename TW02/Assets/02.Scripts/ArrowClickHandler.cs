using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // 씬 전환에 필요
using System.Collections;

public class UI_ArrowClickHandler : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public Button arrow;
    public string NextScene;

    void Start()
    {
        arrow.onClick.AddListener(OnArrowClicked);
    }

    public void OnArrowClicked()
    {
        Debug.Log("ArrowClicked");
        if (text1 != null)
            text1.SetActive(false);
        if (text2 != null)
            text2.SetActive(true);
        if (arrow != null)
            arrow.gameObject.SetActive(false);

        // 코루틴으로 씬 전환
        StartCoroutine(DelayedSceneLoad());
    }

    private IEnumerator DelayedSceneLoad()
    {
        yield return new WaitForSeconds(7f); // 7초 대기
        SceneManager.LoadScene(NextScene); // 처음 씬 이름 넣기 
    }
}