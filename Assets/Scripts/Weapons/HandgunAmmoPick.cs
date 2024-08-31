using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandgunAmmoPick : MonoBehaviour
{
    public GameObject fakeAmmoClip;
    public AudioSource ammoPickupSound;

    void OnTriggerEnter(Collider other)
    {
        fakeAmmoClip.SetActive(false);
        Destroy(fakeAmmoClip);
        ammoPickupSound.Play();
        GlobalAmmo.handgunAmmo += 10;
    }
}
