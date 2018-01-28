using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour {

    private Vector2 startingLocation;
    private Health health;
    private bool isVisible;
    
    public Vector2 StartingLocation
    {
        get { return startingLocation; }
        set { startingLocation = value; }

    }

    public Health Health
    {
        get { return health; }

    }

    public bool IsAlive
    {
        get { return Health.IsAlive(); }

    }

    public bool IsVisible
    {
        get { return isVisible; }
        set { isVisible = value; }

    }

    public string Name
    {
        get { return gameObject.name; }
        set { gameObject.name = value; }

    }

   
	// Use this for initialization
	void Start ()
    {
        health = gameObject.AddComponent<Health>();
        
	}
	
	// Update is called once per frame
	void Update () {
		
        if(isVisible == true)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;

        }

        else
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            
        }

        Debug.Log("Entity Health Component: " + Health.IsAlive() + " " + Health.Value);

    }
}
