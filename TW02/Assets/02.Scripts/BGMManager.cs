using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    private static BGMManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // �� �ٲ� �ı����� �ʰ�
        }
        else
        {
            Destroy(gameObject); // �ߺ� ������ ����
        }
    }
}
