using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FloorTimer : MonoBehaviour
{
    public int secondCount = 0;
    public int minuteCount = 0;
    public bool addingTime = false;
    [SerializeField] TMP_Text timeDisplay;

    // Update is called once per frame
    void Update()
    {
        if (addingTime == false)
        {
            StartCoroutine(AddSecond());
        }
    }

    IEnumerator AddSecond()
    {
        addingTime = true;
        yield return new WaitForSeconds(1);
        secondCount += 1;
        if (secondCount == 60)
        {
            secondCount = 0;
            minuteCount += 1;
        }
        timeDisplay.text = $"{minuteCount}:{secondCount}";
        addingTime = false;
    }
}
