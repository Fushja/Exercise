using UnityEngine;
using System.Collections;

public class Calcolatrice : MonoBehaviour {


    // Update is called once per frame

    public int valore1 = 0;
    public int valore2 = 0;



	void Update () {

        

        // controlliamo se il giocatore sta premendo un tasto

       
        // switch case per fare le operazioni
        string inputString = Input.inputString;

        if (inputString.Length > 0)
        {
            char inputChar = inputString[0];
            float result = 0;

            switch (inputChar)
            {
                case 'p':
                    result = valore1 + valore2;
                    break;

                case 'm':
                    result = valore1 - valore2;
                    break;

                case 'o':
                    result = valore1 * valore2;
                    break;

                case 'd':
                    result = (float)valore1 / valore2;
                    break;
            }
            Debug.Log("Il risultato dell'addizione è " + result);
        }


	}
}
