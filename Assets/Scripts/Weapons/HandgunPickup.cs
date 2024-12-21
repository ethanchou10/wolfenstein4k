using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HandgunPickup : MonoBehaviour
{
    public GameObject realHandgun;
    public GameObject fakeHandgun;
    public AudioSource handgunPickupSound;
    public GameObject pickupDisplay;
    public GameObject pistolImage;

    void OnTriggerEnter(Collider other)
    {
        realHandgun.SetActive(true);
        fakeHandgun.SetActive(false);
        handgunPickupSound.Play();
        GetComponent<BoxCollider>().enabled = false;
        pickupDisplay.SetActive(false); 
        pickupDisplay.GetComponent<TextMeshProUGUI>().text = "HANDGUN";
        pickupDisplay.SetActive(true);
        pistolImage.SetActive(true);
    }
}
