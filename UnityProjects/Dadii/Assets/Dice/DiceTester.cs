using UnityEngine;
using System.Collections;

public class DiceTester : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // Definiamo una variabile di tipo Dice
        Dice d;

        // creiamo un oggetto di tipo Dice e lo menttiamo nella variabile d
        d = new Dice();

        // Serttiamo il nemro di facce
        d.SetFaces(6);


        // Tiriamo il dado per ottenere un numero casuale
        int result = d.Throw();
        Debug.Log("Hai tirato " + result);

        // lanciamo 10 dadi e sommiamo il risultato
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            Dice di = new Dice();
            di.SetFaces(6);
            int r = di.Throw();
            sum += r;
        }
        Debug.Log(sum/10f);




	}
	
	
}
