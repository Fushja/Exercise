using UnityEngine;
using System.Collections;


public class Statistics
{
    private int health;
    private int strenght;
    private int agility;
    private int luck;

    public int this[int i]
    {
        get
        {
            switch (i)
            {
                case 0: return health;
                case 1: return strenght;
                case 2: return agility;
                case 3: return luck;
            }
            return 0;
        }
        set
        {

        }
    }
}
[System.Serializable]
public class TestIndexer : MonoBehaviour {
   
    public int ciao = 0;
    
	// Use this for initialization
	void Start () {
        Statistics st = new Statistics();
        Debug.Log("Health is " + st[0]);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
