using UnityEngine;
using System.Collections;


// Esegue le istruzioni anche in edit mode
[ExecuteInEditMode]
public class TestEditor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.zero;
	}
}
