using UnityEngine;
using System.Collections;

public class Areacerchio : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Dato il raggio r di un cerchio, calcolarne l'area (usare la variabile Mathf.PI per ottenere il pi greco)

        int r = 6;
        float areacerchio;


        areacerchio = ( r * r ) * Mathf.PI;
        Debug.Log("Se raggio del nostro cerchio è " + r + " , con la formula (raggio * raggio) * pigrego , troveremo la nostra area del cerchio che sarà " + areacerchio + " . ");









    }

    // Update is called once per frame
    void Update () {
	
	}
}
