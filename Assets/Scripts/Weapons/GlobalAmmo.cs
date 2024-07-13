using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalAmmo : MonoBehaviour
{
    public static int handgunAmmo;
    [SerializeField] TMP_Text ammoDisplay;

    // Update is called once per frame
    void Update()
    {
        ammoDisplay.text = $"{handgunAmmo}";
    }
}
