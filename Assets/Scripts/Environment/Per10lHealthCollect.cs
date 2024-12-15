using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Per10HealthCollect : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        if (GlobalHealth.healthValue > 901) {
            GlobalHealth.healthValue = 1000;
        }
        else {
            GlobalHealth.healthValue += 100;
        }
        collectSound.Play();
        GetComponent<BoxCollider>().enabled = false;
        this.gameObject.SetActive(false);
    }
}
