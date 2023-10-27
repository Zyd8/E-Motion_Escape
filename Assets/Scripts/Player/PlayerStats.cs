using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] public float health = 100f;
    [SerializeField] public PlayerStatsGUI playerStatsGUI;

    [SerializeField] public MoveScene moveScene;

    public void TakeDamage(float damage)
    {
        health -= damage;
    }

    private void CheckDead()
    {
        if (health <= 0)
        {
            moveScene.Restart();
        }
    }

    void Update()
    {
        playerStatsGUI.ShowHealth(health);
        CheckDead();    
    }
}
