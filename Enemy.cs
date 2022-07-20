using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] private float attackDamage = 40f;
    [SerializeField] private float attackSpeed = 0.5f;
    private float canAttack;
    private float health = 0f;
    [SerializeField] private float maxHealth = 50f;
    private Animator anim;


    void Start()
    {
        health = maxHealth;
    }

   private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            health -= attackDamage;
            anim.SetTrigger("Hurt");
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (attackSpeed <= canAttack)
            {
                other.gameObject.GetComponent<PlayerCombat>().UpdateHealth(-attackDamage);
                canAttack = 0.5f;
            } else
            {
                canAttack += Time.deltaTime;
            }
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
            Debug.Log("Enemy Dead");
            Destroy(gameObject, 1f);
        }
    }
}
