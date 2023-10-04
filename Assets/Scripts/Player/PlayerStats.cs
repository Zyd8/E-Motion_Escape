using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] public int health = 100;
    [SerializeField] public PlayerStatsGUI playerStatsGUI;

    [SerializeField] public MoveScene moveScene;

    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    private void CheckDead()
    {
        if (health <= 0)
        {
            moveScene.FailMenu();
        }
    }

    void Update()
    {
        playerStatsGUI.ShowHealth(health);
        CheckDead();    
    }
}
