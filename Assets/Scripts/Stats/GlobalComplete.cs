using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalComplete : MonoBehaviour
{
    public static int enemyCount;
    public static int treasureCount;
    [SerializeField] TMP_Text enemyDisplay;
    [SerializeField] TMP_Text treasureDisplay;
    public static int nextFloor = 5;

    // Update is called once per frame
    void Update()
    {
        enemyDisplay.text = $"{enemyCount}";
        treasureDisplay.text = $"{treasureCount}";
    }
}
