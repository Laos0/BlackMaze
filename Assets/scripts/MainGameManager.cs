using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameManager : MonoBehaviour {

    public GameObject player;
    public PlayerStats playerStats;
    public MonsterStat monsterStat;

    private bool isGameOver;


	// Use this for initialization
	void Start () {
        isGameOver = false;
        
	}

    void createPlayer(PlayerType playerType)
    {

        if(playerType == PlayerType.BOY)
        {
            playerStats.setName("Bob");
            playerStats.setHp(3);
            playerStats.setStamina(5);
            playerStats.setMoveSpeed(3.0f);
            playerStats.setFearScale(5);
        }else if (playerType == PlayerType.GIRL)
        {
            playerStats.setName("Sully");
            playerStats.setHp(2);
            playerStats.setStamina(7);
            playerStats.setMoveSpeed(3.0f);
            playerStats.setFearScale(5);
        }
        else if (playerType == PlayerType.FATBOY)
        {
            playerStats.setName("Gak");
            playerStats.setHp(4);
            playerStats.setStamina(5);
            playerStats.setMoveSpeed(3.0f);
            playerStats.setFearScale(5);
        }
        else if (playerType == PlayerType.KID)
        {
            playerStats.setName("Kid");
            playerStats.setHp(1);
            playerStats.setStamina(10);
            playerStats.setMoveSpeed(3.0f);
            playerStats.setFearScale(3);
        }
    }

    void createMonster()
    {

    }
}
