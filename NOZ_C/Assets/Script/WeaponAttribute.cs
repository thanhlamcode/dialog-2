using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAttribute : MonoBehaviour
{
    public AttributesManager atm;
    private AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" && PlayerCombat.isAttacking)
        {
            other.GetComponent<AttributesManager>().TakeDamage(atm.attack);
            audioManager.PlaySFX(audioManager.enemyImpact);
        }    
    }
}
