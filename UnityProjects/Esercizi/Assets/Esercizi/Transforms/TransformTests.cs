using UnityEngine;
using System.Collections;

public class TransformTests : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //posizione locale
        //transform.localPosition = new Vector3(0, 0, 0);
        //posizione globale
        //transform.position = new Vector3(0, 0, 0);

        Debug.Log(transform.localPosition);

        transform.localEulerAngles = new Vector3(0, 0, 90);
        transform.eulerAngles = new Vector3(0, 0, 90);

        //modifichiamo lo scale relativo al padre
        //transform.localScale = new Vector3(2, 2, 2);

        //scaling globale
        //transform.lossyScale = new Vector3 (3,3,3);

        Vector3  globalRight = Vector3.right;
        Vector3 globalUp = Vector3.up;

        Vector3 localRight = transform.right;
        Vector3 localUp = transform.up;

        transform.position += globalRight * 2;
        transform.Translate(localRight * 2);

        
        transform.Rotate(0, 0, 90);
        //Cerca un figlio ma non nipoti
        transform.Find("A");

        //ritorna il padre
        //transform.parent;

        //prende la lista dei figli e ritorna il figlio in base all'indice
        //transform.GetChild(1);

        //numero di figli
        //transform.childCount;

        //setta il padre tramite il nome
        //transform.SetParent(p);
        
        //mette come primo lui stesso tra i fratelli
        transform.SetAsFirstSibling();

        foreach(Transform tr in transform)
        {
            Debug.Log(tr);
        }

        //routa la transform data una determinata posizione
        transform.LookAt(Vector3.zero);
        //in 2d usiamo questo comando
        transform.Rotate(0, -90, 0);



	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
