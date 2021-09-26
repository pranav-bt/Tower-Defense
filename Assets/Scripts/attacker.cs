using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attacker : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0,5)] [SerializeField] float attackerspeed;
    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVFX;
    GameObject target;
    void Start()
    {
        
       
    }
    public void setwalkspeed(float speed)
    {
        attackerspeed = speed;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * attackerspeed * Time.deltaTime);
        updatespeed();
    }

    private void updatespeed()
    {
        if(!target)
        {
            GetComponent<Animator>().SetBool("isattack", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag== "Playerweapon")
        {
            float damage= other.GetComponent<Projectile>().returndamage();
            Destroy(other.gameObject);
            health -= damage;
            if(health<=0)
            {
                Destroy(gameObject);
                if (deathVFX) { deatheffect(); }
                FindObjectOfType<LevelController>().attackercountminus(1);
            }
        }
        
    }
    public void attack(GameObject currenttarget)
    {
        GetComponent<Animator>().SetBool("isattack", true);
        target = currenttarget;
    }
    public void strikedamage(float damagee)
    {
        if (!target) {  return; }
        Health health = target.GetComponent<Health>();
        if(health)
        {
            health.dealdamage(damagee);
        }
    }
    private void deatheffect()
    {
        GameObject deathvfxobj =Instantiate(deathVFX, transform.position, Quaternion.identity);
        Destroy(deathvfxobj, 1f);
    }
}
