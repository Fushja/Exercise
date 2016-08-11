using UnityEngine;
using System.Collections;

public class Resto : MonoBehaviour {

	void Start () {
        // Start Logic
        // Crea un programma che fatto un prezzo in euro (530.70) restituisca il numero di banconote usando pezzi da 50 20 5
        // e il resto a parte

        float prezzo = 530.70f;
        int p50, p20, p5;
        float prezzofinale = prezzo;

        p50 = (int)prezzofinale / 50;
        prezzofinale = prezzofinale - (p50 * 50);
        // prezzofinale = 30.70

        p20 = (int)prezzofinale / 20;
        prezzofinale = prezzofinale - (p20 * 20);
        // prezzofinale = 10.70

        p5 = (int)prezzofinale / 5;
        prezzofinale = prezzofinale - (p5 * 5);
        // prezzofinale = 0.70

        Debug.Log(" Partendo da " + prezzo + " abbiamo " + p50 + " banconote da 50 euro, " + p20 + " banconata da 20, " + p5 + " banconote da 5. Il resto di " + prezzofinale);        

              
            

    // End Logic
	}
	
}
