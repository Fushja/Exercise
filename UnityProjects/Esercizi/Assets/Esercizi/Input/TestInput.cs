using UnityEngine;
using System.Collections;

public class TestInput : MonoBehaviour {
    public SpriteRenderer sr;
    [Range(0,1)]
    public float myXM;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Jump"))
        {
            sr.color = Color.red;
        }
        else
        {
            sr.color = Color.green;
        }

        float x = Input.GetAxis("Horizontal");
        sr.color = Color.Lerp(Color.red, Color.blue, x);
	}

}
