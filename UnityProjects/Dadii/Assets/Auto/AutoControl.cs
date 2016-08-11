using UnityEngine;
using System.Collections;

public class AutoControl : MonoBehaviour {

	
	void Start () {

        Auto[] array = new Auto[100];
        for (int i = 0; i < 100; i++)
        {
            array[i] = new Auto();
            /// Auto element = array[i];
            /// Debug.Log(array[i].GetStatus());
        }


    }
	
	
}
