using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GlobalScore : MonoBehaviour
{
    [SerializeField] TMP_Text scoreDisplay;
    public static int scoreValue = 0;
    public int internalScore;
    [SerializeField] TMP_Text finalScore;

    // Update is called once per frame
    void Update()
    {
        internalScore = scoreValue;
        scoreDisplay.text = $"{scoreValue}";
        finalScore.text = $"{scoreValue}";
    }
}
