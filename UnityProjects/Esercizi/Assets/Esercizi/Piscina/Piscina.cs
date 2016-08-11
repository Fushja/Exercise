using UnityEngine;
using System.Collections;

public class Piscina : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Dati un numero N di secchi da 5 litri e un numero M di secchi da 2 litri, calcolare il numero
        //minimo di secchi necessario per riempire una piscina di 72 litri.

        int secchi5litri, secchi2litri;
        int piscina = 72;
        int piscinavuota = piscina;


        
        secchi5litri = piscinavuota / 5; // 14 secchi
        piscinavuota = piscinavuota - (secchi5litri * 5);
       

        secchi2litri = piscinavuota / 2; // 34 secchi
        piscinavuota = piscinavuota - (secchi2litri) * 2;
       

        Debug.Log("Abbiamo una piscina piena di litri " + piscina + " . Riempita da " + secchi5litri + " secchi da 5 litri, e da " + secchi2litri + " secchi da 2 litri ");
        











    }

    // Update is called once per frame
    void Update () {
	
	}
}
