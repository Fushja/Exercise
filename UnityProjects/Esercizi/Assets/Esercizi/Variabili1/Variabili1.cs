using UnityEngine;
using System.Collections;

public class Variabili1 : MonoBehaviour {

	void Start () {
        // Start Logic
        int a = 0;
        int b = a;
        Debug.Log(b);

        b = a + 5;
        b = b - 3;
        Debug.Log(b);

        b *= 10;
        Debug.Log(b);

        // Complex expression   
        int exp = a + b * b - a / b;
        Debug.Log(exp);

        // Casting
        float f1 = 15.0f;
        
        int i1 = (int) f1;
        Debug.Log("f1 castato ad int è: " + i1);

        // y = mx + q
        int m = 10, q = -5;
        float y;
        float x = 12;
        y = m * x + q;
        Debug.Log(y);       


    // End Logic
	}
	
}
