using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    // Player stats
    private string name;
    private float moveSpeed;
    private int hp;
    private int stamina;
    private int fearScale;


    // Use this for initialization
    void Start () {
		
	}

    public void setName(string name)
    {
        this.name = name;
    }

    public void setMoveSpeed(float moveSpeed)
    {
        this.moveSpeed = moveSpeed;
    }

    public void setHp(int hp)
    {
        this.hp = hp;
    }

    public void setStamina(int stamina)
    {
        this.stamina = stamina;
    }

    public void setFearScale(int fearScale)
    {
        this.fearScale = fearScale;
    }

    public string getName()
    {
        return name;
    }

    public float getMoveSpeed()
    {
        return moveSpeed;
    }

    public int getHp()
    {
        return hp;
    }

    public int getStamina()
    {
        return stamina;
    }

    public int getFearScale()
    {
        return fearScale;
    }

}
