using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 5;
    int currentHitPoints = 0;
    
    void OnEnable()
    {
        currentHitPoints = maxHitPoints;
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
        if (currentHitPoints < 1)
        {
            KillEnemy();
        }   
    }

    void ProcessHit()
    {
        currentHitPoints --;  
    }
    
    void KillEnemy()
    {
        gameObject.SetActive(false);
    }
}
