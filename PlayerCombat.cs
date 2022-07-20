using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator anim;
    private float health = 0f;
    [SerializeField] private float maxHealth = 50f;
    private float attackDamage = 10f;

    private void Start()
    {
        health = maxHealth;
        anim = GetComponent<Animator>(); 

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
        
        if (Input.GetButtonDown("Fire2"))
        {
            Attack1();
        }

    }
    
    void Attack()
    {
        anim.SetTrigger("Attack");
    }
    
    void Attack1()
    {
        anim.SetTrigger("Attack1");
    }

void OnTriggerEnter2D (Collider2D col)
        {
        if (col.gameObject.tag == "Enemy")
        {
            health -= attackDamage;
                anim.SetTrigger("Hurt");
        } 
        }



    public void UpdateHealth(float mod)
    {

        if (health > maxHealth)
        {
            health = maxHealth;
        }
        else if (health <= 0f)
        {
            health = 0f;
            anim.SetBool("Dead", true);
            Debug.Log("Player RIP");
            Destroy(gameObject, 1.5f);
        }
    }

    

}
