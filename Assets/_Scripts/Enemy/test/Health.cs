using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace ParrotGame.Enemy{
    public class Health : MonoBehaviour
    {
        [SerializeField] private float defaultHealth = 100f;

        [HideInInspector] public UnityEvent OnHit;
        [HideInInspector] public UnityEvent OnDeath;

        private bool isDead;
        private float health { get; set; }
        
        public bool IsDead => isDead;
        public float CurrentHealth => health;

        private void Awake()
        {
            isDead = false;
            health = defaultHealth;
        }

        public void TakeDamage(float damage)
        {
            if (isDead)
                return;

            health -= damage;
            OnHit.Invoke();

            if(health <= 0)
            {
                Die();
            }
        }

        public void Die()
        {
            // death
            isDead = true;
            OnDeath.Invoke();
        }
    }
}
