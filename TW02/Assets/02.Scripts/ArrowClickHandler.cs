using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // �� ��ȯ�� �ʿ�
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

        // �ڷ�ƾ���� �� ��ȯ
        StartCoroutine(DelayedSceneLoad());
    }

    private IEnumerator DelayedSceneLoad()
    {
        yield return new WaitForSeconds(7f); // 7�� ���
        SceneManager.LoadScene(NextScene); // ó�� �� �̸� �ֱ� 
    }
}