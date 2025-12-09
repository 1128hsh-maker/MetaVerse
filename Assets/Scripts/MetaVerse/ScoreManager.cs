using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public const string BESTSCORE = "BESTSCORE";
    public int score; // 씬 간에 공유할 데이터

    void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
