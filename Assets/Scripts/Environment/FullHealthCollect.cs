using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullHealthCollect : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        GlobalHealth.healthValue = 1000;
        collectSound.Play();
        GetComponent<BoxCollider>().enabled = false;
        this.gameObject.SetActive(false);
    }
}
