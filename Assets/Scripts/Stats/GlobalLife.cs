using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GlobalLife : MonoBehaviour
{
    [SerializeField] TMP_Text lifeDisplay;
    public static int lifeValue = 3;
    public int internalLife;

    // Update is called once per frame
    void Update()
    {
        internalLife = lifeValue;
        lifeDisplay.text = $"{lifeValue}";
    }
}
