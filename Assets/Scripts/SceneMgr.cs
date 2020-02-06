using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMgr : MonoBehaviour
{
    void Start()
    {
        
    }

    public void OpenPlayScene()
    {
        LoadingSceneManager.LoadScene("PlayScene");
    }

    public void OpenToolScene()
    {
        // TODO. tool 씬이 아직 없으므로 지금은 스타트 씬 로드
        LoadingSceneManager.LoadScene("StartScene");
    }
}
