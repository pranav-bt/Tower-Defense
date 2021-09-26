using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    int damagesubtracted;
    public void Awake()
    {
        float diffval = PlayerPrefsController.GetDifficulty();
        if (diffval >= 0 && diffval <= 0.5)
        {
            damagesubtracted = 5;
        }
        else if (diffval >= 0.5 && diffval <= 1)
        {
            damagesubtracted = 8;
        }
    }
        private void OnTriggerEnter2D(Collider2D other)
    {
        HealthText healthtext = FindObjectOfType<HealthText>();
        if(other.tag=="attacker")
        {
            healthtext.subhealth(damagesubtracted);
            Destroy(other.gameObject);
            FindObjectOfType<LevelController>().attackercountminus(1);
        }
       
    }
}
