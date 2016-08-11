using UnityEngine;
using System.Collections;

public class Arearettangolo: MonoBehaviour {

	// Use this for initialization
	void Start () {
        // Dati il lato l e la base b di un rettangolo, calcolarne l'area.

        int l = 7;
        int b = 13;
        int arearettangolo;

        arearettangolo = b * l;
        Debug.Log(" Avendo un rettangolo con lato di " + l + " e base di " + b + " , possiamo dire che l'area del rettangolo è di " + arearettangolo + " . ");










    }

    // Update is called once per frame
    void Update () {
	
	}
}
