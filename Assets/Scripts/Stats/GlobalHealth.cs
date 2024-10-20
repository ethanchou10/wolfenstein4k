using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour
{
    [SerializeField] TMP_Text healthDisplay;
    public static int healthValue;
    public int internalHealth;
    // Start is called before the first frame update
    void Start()
    {
        healthValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (healthValue <= 0) {
            SceneManager.LoadScene(0);
        }
        internalHealth = healthValue;
        healthDisplay.text = $"{healthValue}%";
    }
}
