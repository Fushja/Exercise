using UnityEngine;
using System;
using System.Collections.Generic;



public class TestArray : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //array base
        /*
        int[] buildin_array = new int[4];

        Array test = Array.CreateInstance(typeof(int), 4);

        Array.Sort(test);
        */

        Dictionary<string, int> testDict = new Dictionary<string, int>();
        testDict.Add("A", 50);
        testDict.Add("B", 60);
        testDict.Add("C", 70);
        testDict.Add("D", 80);
        testDict.Add("E", 90);

        // Altro modo di inserire

        testDict["F"] = 10;

        // Recuperiamo un valore

        int davidMoney = testDict["F"];

        // Check chiave
        if (testDict.ContainsKey("D"))
        {
            Debug.Log("D ha " + testDict["D"]);
        }

        // Check valore

        if (testDict.ContainsValue(10))
        {
            Debug.Log("Qualcuno ha 10");
        }

        Debug.Log(davidMoney);
        
        // L'ordine di un hashtable non è garantito

        // itero su ogni chiave e restituisco chiave + valore
        foreach (var key in testDict.Keys)
        {
            Debug.Log("dict has the key : "+key+" with value "+testDict[key]);
        }

        foreach (var value in testDict.Values)
        {
            Debug.Log("Dict has value " + value);

        }

        foreach (var pair in testDict)
        {
            string k = pair.Key;
            
            int v = pair.Value;
        }
        // Puliamo dizionario
        testDict.Clear();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
