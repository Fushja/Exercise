using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum MyEnum { Uno,Due,Tre}

public class TestSortedList : MonoBehaviour {


	// Use this for initialization
	void Start () {

        SortedList<MyEnum, string> mySortedList = new SortedList<MyEnum, string>();

        // Aggiungiamo dei valori

        mySortedList.Add(MyEnum.Due, "DUE");
        mySortedList.Add(MyEnum.Tre, "TRE");
        mySortedList[MyEnum.Uno] = "UNO";

        // Cicliamo sui valori

        Debug.Log(mySortedList.IndexOfKey(MyEnum.Uno));

        foreach (var pair in mySortedList)
        {
            Debug.Log("K: " + pair.Key + " V: " + pair.Value);
            
        }

        var k = mySortedList.Keys[2];
        Debug.Log(k);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
