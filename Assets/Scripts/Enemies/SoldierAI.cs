using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAI : MonoBehaviour
{
    public string hitTag;
    public bool lookingAtPlayer = false;
    public GameObject theSoldier;
    public AudioSource fireSound;
    public bool isFiring = false;
    public float fireRate = 1.5f;

    void Update() {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            hitTag = Hit.transform.tag;
        }
        if (hitTag == "Player" && isFiring == false)
        {
            StartCoroutine(EnemyFire());
        }
        if (hitTag != "Player")
        {
            theSoldier.GetComponent<Animator>().Play("assault_combat_idle");
            lookingAtPlayer = false;
        }
    }

    IEnumerator EnemyFire()
    {
        isFiring = true;
        theSoldier.GetComponent<Animator>().Play("assault_combat_shoot", -1, 0);
        theSoldier.GetComponent<Animator>().Play("assault_combat_shoot");
        fireSound.Play();
        lookingAtPlayer = true;
        GlobalHealth.healthValue = GlobalHealth.healthValue - 5;
        yield return new WaitForSeconds(fireRate);
        isFiring = false;
    }
}
