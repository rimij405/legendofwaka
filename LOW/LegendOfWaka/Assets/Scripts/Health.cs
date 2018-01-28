using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    private int value;
    private int maxHealth;
    private int minHealth;

    public int Value
    {
        get { return value; }

    }

	// Use this for initialization
	void Start ()
    {
        Restore();


	}

    public void Restore()
    {
        Heal(maxHealth);

    }

    public void Heal(int health)
    {
        value += Mathf.Abs(health);

        if(value > maxHealth)
        {
            value = maxHealth;

        }

    }

    public void Damage(int damage)
    {
        value -= damage;

        if(value < minHealth)
        {
            value = minHealth;

        }

    }

    public bool IsAlive()
    {
        return (value > minHealth) ;
       
    }

    public bool FullHealth()
    {
        return (value == maxHealth);

    }

    public void Kill()
    {
        Damage(maxHealth);

    }


	
	


}
