using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] public DisplayDeathMessage deathMessage;
    [SerializeField] public float health = 100f;
    [SerializeField] public PlayerStatsGUI playerStatsGUI;
    [SerializeField] public MoveScene moveScene;

    [SerializeField] public PlayerMovement playerMovement;

    private bool isDead = false;

    public void TakeDamage(float damage)
    {
        health -= damage;
    }

    private void CheckDead()
    {
        if (health <= 0 && !isDead)
        {
            isDead = true;
            playerMovement.canMove = false;
            deathMessage.ShowDeathMessage();
            StartCoroutine(DeathRoutine());
        }
    }

    private IEnumerator DeathRoutine()
    {
        // Wait for 2 seconds
        yield return new WaitForSeconds(2f);

        playerMovement.canMove = true;
        deathMessage.HideDeathMessage();
        moveScene.Restart();
    }

    void Update()
    {
        playerStatsGUI.ShowHealth(health);
        CheckDead();
    }
}
