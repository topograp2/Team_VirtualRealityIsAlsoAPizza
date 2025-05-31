using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;


public class MissionStatusUI : MonoBehaviour
{
    public Image missionCardImage;
    public Image glowImage;
    public Button leftButton;
    public Button rightButton;
    public Button backButton;
    public Image[] thumbnailImages;
    public Sprite[] missionCardSprites;
    public Sprite unknownSprite;
    public Sprite[] thumbnailSprites;
    public GameObject[] thumbnailBorders;
    public Text noMissionText; //  �̼� ���� �� ǥ���� �ؽ�Ʈ
    public Text missionDescriptionText;
    public String[] missionDescriptions;
    public String ending;

    public int complete;
    private int currentMissionIndex;

    void Start()
    {
        complete = SceneTracker.complete;
        if (complete > 0)
            currentMissionIndex = complete - 1;

        UpdateUI();

        leftButton.onClick.AddListener(OnLeft);
        rightButton.onClick.AddListener(OnRight);
        backButton.onClick.AddListener(OnBack);
    }

    void UpdateUI()
    {
        if (complete == 0)
        {
            missionCardImage.gameObject.SetActive(false);
            glowImage.gameObject.SetActive(false);
            leftButton.gameObject.SetActive(false);
            rightButton.gameObject.SetActive(false);
            noMissionText.gameObject.SetActive(true);

            for (int i = 0; i < thumbnailImages.Length; i++)
            {
                thumbnailImages[i].sprite = unknownSprite;
                thumbnailBorders[i].SetActive(false);

                // ��� ���� ũ��� ���
                StartCoroutine(AnimateScale(thumbnailImages[i].transform, Vector3.one, 0.2f));
            }

            return;
        }

        missionCardImage.gameObject.SetActive(true);
        missionCardImage.sprite = missionCardSprites[currentMissionIndex];
        if (missionDescriptions.Length > currentMissionIndex)
        {
            missionDescriptionText.text = missionDescriptions[currentMissionIndex];
        }
        else
        {
            missionDescriptionText.text = "";
        }
        // glow ����
        bool showGlow = complete == 5 && currentMissionIndex == complete - 1;

        glowImage.gameObject.SetActive(showGlow);

        // �����̱� ����
        if (showGlow)
        {
            StopAllCoroutines(); // �ߺ� ����
            StartCoroutine(BlinkGlow());
        }
        else
        {
            StopAllCoroutines(); // �ٸ� ��쿡�� ������ ����
        }
        leftButton.gameObject.SetActive(currentMissionIndex > 0);
        rightButton.gameObject.SetActive(currentMissionIndex < complete - 1 || showGlow);
        noMissionText.gameObject.SetActive(false);

        for (int i = 0; i < thumbnailImages.Length; i++)
        {
            if (i < complete)
                thumbnailImages[i].sprite = thumbnailSprites[i];
            else
                thumbnailImages[i].sprite = unknownSprite;

            thumbnailBorders[i].SetActive(false); // border�� ���� ��� ����

            // ���õ� ������� Ȯ��, �������� ���
            if (i == currentMissionIndex)
                StartCoroutine(AnimateScale(thumbnailImages[i].transform, Vector3.one * 1.2f, 0.2f));
            else
                StartCoroutine(AnimateScale(thumbnailImages[i].transform, Vector3.one, 0.2f));
        }
    }

    public void OnLeft()
    {
        Debug.Log("Click Left Button");
        if (currentMissionIndex > 0)
        {
            currentMissionIndex--;
            UpdateUI();
        }
    }

    public void OnRight()
    {
        Debug.Log("Click Right Button");
        if (currentMissionIndex < complete - 1)
        {
            currentMissionIndex++;
            UpdateUI();
        }
        if (currentMissionIndex == complete - 1 && complete == 5)
        {
            SceneManager.LoadScene(ending); // ������ �̵�
        }
    }

    public void OnBack()
    {
        string prev = SceneTracker.previousScene;

        if (!string.IsNullOrEmpty(prev))
            SceneManager.LoadScene(prev);
        else
            SceneManager.LoadScene("Scene01");
    }

    IEnumerator AnimateScale(Transform target, Vector3 to, float duration)
    {
        Vector3 from = target.localScale;
        float time = 0f;

        while (time < duration)
        {
            target.localScale = Vector3.Lerp(from, to, time / duration);
            time += Time.deltaTime;
            yield return null;
        }

        target.localScale = to;
    }

    IEnumerator BlinkGlow()
    {
        Image img = glowImage;
        Color baseColor = img.color;
        float alphaMin = 0.3f;
        float alphaMax = 1.0f;
        float speed = 2.0f;

        while (img.gameObject.activeSelf)
        {
            // Alpha�� �ε巴�� ������ �����̴� ȿ��
            float t = (Mathf.Sin(Time.time * speed) + 1f) / 2f; // 0~1 ����
            float alpha = Mathf.Lerp(alphaMin, alphaMax, t);
            img.color = new Color(baseColor.r, baseColor.g, baseColor.b, alpha);
            yield return null;
        }

        // ���� �� ���� ���� ����
        img.color = baseColor;
    }

}

