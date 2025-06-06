using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class BookingImageController : MonoBehaviour
{
    public Image uiImage;                // �̹��� UI
    public Sprite image01, image02, image03; // ������ �̹�����
    public Button stateButton;           // ���� ��ȭ ��ư

    private int state = 1; // ���� ���¸� ��Ÿ���� ����

    string nextSceneName = "Mission02_Success"; // ���� �� �̸�

    // Start is called before the first frame update
    void Start()
    {
        // �ʱ� ���� ����
        uiImage.sprite = image01;

        // ��ư Ŭ�� �� ChangeState �Լ� ����
        stateButton.onClick.AddListener(ChangeState);
    }

    void ChangeState()
    {
        if (state == 1)
        {
            state = 2;
            uiImage.sprite = image02;
        }
        else if (state == 2)
        {
            state = 3;
            uiImage.sprite = image03;
        }
        else if (state == 3)
        {
            SceneManager.LoadScene(nextSceneName); // �Ϸ� ��ư Ŭ�� �� ���� ������ �̵�
        }
    }
}

