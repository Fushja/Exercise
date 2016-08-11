using UnityEngine;
using System.Collections;

public class TestCrossProduct : MonoBehaviour {

    public Transform targetTransform;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // Guardiamo verso il target
        this.transform.LookAt(targetTransform);

        // Mi muovo lungo right
        //transform.position += transform.right * Time.deltaTime;

        // Calcolo la direzione 'right'
        Vector3 myRight;
        myRight = Vector3.Cross(transform.forward, Vector3.up);
        transform.position -= myRight * Time.deltaTime;

	}
}
