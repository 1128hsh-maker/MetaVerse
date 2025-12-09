using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
public class Score : MonoBehaviour
{
    private TextMeshProUGUI text;
    private int bestScore;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        
    }
    private void Start()
    {
        bestScore = PlayerPrefs.GetInt(ScoreManager.BESTSCORE);

    }
    private void Update()
    {
        
        if (ScoreManager.instance == null)
        {
            text.text = "---"; 
            return;
        }
        else
        {
            text.text = bestScore.ToString();
        }
            
    }
}
