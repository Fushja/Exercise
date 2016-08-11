using UnityEngine;
using System.Collections;

public class For : MonoBehaviour {

    // Use this for initialization
    public int n = 10;

    void Start() {

        int somma = 0;
        for (int i = 0; i < n; i++)
        {
            somma += i;
        }

        Debug.Log(somma);         
	    
	}
	
	
}
