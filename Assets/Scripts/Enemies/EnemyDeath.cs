using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int enemyHealth = 20;
    public bool enemyDead = false;
    public GameObject enemyAI;
    public GameObject theEnemy;

    void DamageEnemy(int damageAmount)
    {
        Debug.Log("DamageEnemy");
        Debug.Log(damageAmount);
        enemyHealth -= damageAmount;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0 && enemyDead == false)
        {
            enemyDead = true;
            theEnemy.GetComponent<Animator>().Play("infantry_death_A");
            enemyAI.SetActive(false);
            theEnemy.GetComponent<LookPlayer>().enabled = false;
        }
    }
}
