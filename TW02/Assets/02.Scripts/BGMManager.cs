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
            DontDestroyOnLoad(gameObject); // 씬 바뀌어도 파괴되지 않게
        }
        else
        {
            Destroy(gameObject); // 중복 생성을 방지
        }
    }
}
