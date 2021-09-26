using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float attackspeed = 1f;
    [SerializeField] float ProjectileDamage = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float returndamage()
    {
        return ProjectileDamage;
    }
    // Update is called once per frame
    void Update()
    {
        var spr = GetComponent<SpriteRenderer>();
        Sprite sprit = spr.sprite;
        if(sprit.name=="Bullet_001")
        {
            transform.Translate(Vector2.right * attackspeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.up * attackspeed * Time.deltaTime);
        }
    }
}
