using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionGuide : MonoBehaviour
{
    [Header("이 씬에 해당하는 미션 번호 (1~5)")]
    public int missionNumber = 1;

    void Start()
    {
        // 현재 미션의 이전 단계까지만 도감에서 보이도록 설정
        SceneTracker.complete = missionNumber - 1;
        Debug.Log($"[MissionGuide] SceneTracker.complete = {SceneTracker.complete}");
    }
}
