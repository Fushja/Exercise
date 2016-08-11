using UnityEngine;
using System.Collections;

public class TestBottles : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Bottle a = new Bottle(5);
        Bottle b = new Bottle(5);
        Bottle c = a + b;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
