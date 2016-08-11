using UnityEngine;
using System.Collections;

public class Percent : MonoBehaviour {

	
	void Start () {
        // tira un dado da 100 facce e controlla se esce un numero di 50
        Dice p = new Dice();
        p.SetFaces(100);
        int result = p.Throw();
        if(result < 50)
        {
            Debug.Log("Hai vinto! " + result);
        }
        else
        {
            Debug.Log("Hai Perso! " + result);
        }

	}
	
	
}
