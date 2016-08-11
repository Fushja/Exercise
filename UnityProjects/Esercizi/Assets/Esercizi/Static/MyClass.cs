using UnityEngine;
using System.Collections;

public class MyClass : MonoBehaviour {

    private static int Count = 0;

    public int myNum = 0;
	
	void Start () {
        MyStatic.ciaoString = "Muori";
        MyStatic.SayCiao();

        Count++;
        Debug.Log(Count);

        MyClass.SayNum(this);

	}

    static void SayNum(MyClass whatClass)
    {
        Debug.Log(whatClass.myNum);
    }
    
	
	
}
