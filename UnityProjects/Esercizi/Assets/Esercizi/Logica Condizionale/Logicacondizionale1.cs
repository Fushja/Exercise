using UnityEngine;
using System.Collections;

public class Logicacondizionale1 : MonoBehaviour {
    public int valorecheinseriamo;

    // Use this for initialization
    void Start()
    {


        if (true)
        {
            Debug.Log("SEMPRE VERO");
        }
        if (false)
        {
            Debug.Log("SEMPRE FALSO");
        }



        int valoregiusto = 5;
        int valoreinserito = valorecheinseriamo;

        if (valoregiusto == valoreinserito)
        {
            Debug.Log("BRAVO! HAI ISERITO IL VALORE GIUSTO");
        }
        else if(valoreinserito == 42)
        {
            Debug.Log("Addio E grazie per tutti i pesci");

        }
        else
        {
            Debug.Log("CHE SCHIFO HAI SBAGLIATO");
        }
    }
	

	// Update is called once per frame
	void Update () {
	
	}
}
