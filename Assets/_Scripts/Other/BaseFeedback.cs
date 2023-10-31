using UnityEngine;

public class BaseFeedback : MonoBehaviour
{
    [Header("Visual Effects")]
    public ParticleSystem hitEffect; 
    public ParticleSystem healEffect; 
    public ParticleSystem deathEffect; 

    [Header("Audio Effects")]
    public AudioSource audioSource; 
    public AudioClip hitSound; 
    public AudioClip healSound; 
    public AudioClip deathSound; 

    public void ShowHitEffect()
    {
        hitEffect.Play();
    }

    public void ShowHealEffect()
    {
        healEffect.Play();
    }

    public void ShowDeathEffect()
    {
        deathEffect.Play();
    }

    public void PlayHitSound()
    {
        audioSource.PlayOneShot(hitSound);
    }

    public void PlayHealSound()
    {
        audioSource.PlayOneShot(healSound);
    }

    public void PlayDeathSound()
    {
        audioSource.PlayOneShot(deathSound);
    }

}
