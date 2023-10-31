using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Enemy Attributes")]
    public float health = 50f;
    public float maxHealth = 50f;
    public float moveSpeed = 3.0f;
    public float attackPower = 5f;

    protected bool isAlive = true;

    private void Start()
    {

    }

    private void Update()
    {
    }


    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0 && isAlive)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        isAlive = false;
    }

}