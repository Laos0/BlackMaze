using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStat : MonoBehaviour {

    private string name;
    private float moveSpeed;
    private int lightAbsorb;
    private int dmg;

	// Use this for initialization
	void Start () {
        name = "Crawler";
        moveSpeed = 2.5f;
        lightAbsorb = 0;
        dmg = 1;
	}

    public string getName()
    {
        return name;
    }
	
    public float getMoveSpeed()
    {
        return moveSpeed;
    }

    public int getLightAbsorb()
    {
        return lightAbsorb;
    }
	
    public int getDmg()
    {
        return dmg;
    }
}
