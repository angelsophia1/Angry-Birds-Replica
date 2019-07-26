using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour {
    public float health = 4f;
    public GameObject deathEffect;
    public static int enemyCount = 0;
    private void Start()
    {
        enemyCount++;
    }
    private void OnCollisionEnter2D(Collision2D colinfo)
    {
        if (colinfo.relativeVelocity.magnitude > health)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
        Instantiate(deathEffect,transform.position,Quaternion.identity);

        enemyCount--;
        if(enemyCount<= 0)
        {
            Debug.Log("Level Won!");
        }
    }

}

