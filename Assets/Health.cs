using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] float health = 100;
    [SerializeField] GameObject deathVFX;
    public void dealdamage(float damage)
    {
        health -= damage;
        if(health<=0)
        {
            TriggerdeathVFX();
            Destroy(gameObject);

        }
    }

    private void TriggerdeathVFX()
    {
        if (!deathVFX) { return; }
        GameObject deathVFXobj = Instantiate(deathVFX, transform.position, Quaternion.identity);
        Destroy(deathVFXobj, 1f);
    }
}
