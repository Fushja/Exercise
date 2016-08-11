using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Liste : MonoBehaviour {

	// Use this for initialization
	void Start () {
        List<int> listaInt = new List<int>();

        listaInt.Add(5);
        listaInt.Add(3);
        int[] tmpList = new int[3] { 1, 2, 3 };
        listaInt.AddRange(tmpList);

        // inserisco un valore in mezzo
        listaInt.Insert(2, 7);

        // rimuove il primo valore 7 dalla lista
        //listaInt.Remove(7);
        // rimuove il primo valore dalla lista
        listaInt.RemoveAt(0);

        // controlla se c'è un determinato valore nella lista

        if (listaInt.Contains(7))
        {
            Debug.Log("Sette");
        }
        
        // per ogni elemento
        foreach(int valore in listaInt)
        {
            Debug.Log(valore);
        }

        // ribalta la lista
        listaInt.Reverse();
        listaInt.Sort();


        for (int i = 0; i < listaInt.Count; i++)
        {
            Debug.Log(listaInt[i]);


        }

        // svuola la lista
        listaInt.Clear();
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
