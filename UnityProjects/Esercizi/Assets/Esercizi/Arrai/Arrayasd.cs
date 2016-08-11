using UnityEngine;
using System.Collections;

public class Arrayasd : MonoBehaviour {

	// Use this for initialization
	void Start () {

        int[] array = new int[10];
        Debug.Log(array[0]);

        int a = array[4];
        int b = array[6];

        // mettiamo in numeri interi sequenziali in array
        for(int i = 0; i < array.Length; i++)
        {
            array[0] = i;
        }

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i] + array[i+1]);
        }

        // creiamo una matrice
        int[,] matrix = new int[3,2];

        for(int i = 0; i < matrix.GetLongLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLongLength(1); j++)
            {
                matrix[i, j] = i + j;
                Debug.Log(matrix[i, j]);
            }

        }


	}
	
	
}
