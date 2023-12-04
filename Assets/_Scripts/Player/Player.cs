using UnityEngine;

public class Player : MonoBehaviour, IDamagable
{
    [Header("Health attributes")] // ----------------------------
    public float health = 100f;
    public float maxHealth = 100f;
    [HideInInspector] public bool playerIsDead;
    // ---------------------------------------------------------
    [SerializeField] GameObject playerAbility;
    // script references ----------------------------------------
    private PlayerFeedback playerFeedback;
    [SerializeField] private Healthbar hpBarScript;
    [SerializeField] public PlayerMovement playerMovement;


    private void Start()
    {
        health = maxHealth; 
        playerIsDead = false;
    }

    private void Update()
    {
        playerMovement.Move();
    }

    // ------------------------------------------------------------- Hp Stuff

    public void TakeDamage(float damage, Transform source){
        if(playerIsDead)
            return;
        
        health -= damage;
        hpBarScript.UpdateHealthbar(health, maxHealth);
        if(health < 0){
            health = 0;
            Die();
        }
        
    }

    public void Heal(float amount)
    {

    }

    private void Die()
    {
        // Death animation
        hpBarScript.gameObject.SetActive(false);
    }

    // -----------------------------------------------------------------
    public void FireAbility(){
        Instantiate(playerAbility, transform.position, Quaternion.Euler(transform.forward));
        Debug.Log("player: "+transform.forward);
    }


}
