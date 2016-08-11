using UnityEngine;
using System.Collections;

using MyBigStringOfAwesomeness = System.String;

public class Trucchetti : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string[] stringsArray = new string[5];
        stringsArray[0] = "Ciao";
        stringsArray[1] = "prr";
        stringsArray[2] = "bla bla";
        stringsArray[3] = "hihi";
        stringsArray[4] = "bravo";

        foreach (string s in stringsArray)
        {
            Debug.Log(s);
        }

        foreach (var item in stringsArray)
        {


        }

        int sum = AddNumbers(1, 2);

        int div;
        int resto;
        SuperDivision(5, 2, out div, out resto);
    }

    
	
	// Update is called once per frame
	

    int AddNumbers(int a, int b,int c = 0)
    {

        return a + b + c;
    }

    int AddNumberss(params int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    void SuperDivision(int a,int b,out int div, out int resto)
    {
        resto = a % b;
        div = a / b;
    }


}
