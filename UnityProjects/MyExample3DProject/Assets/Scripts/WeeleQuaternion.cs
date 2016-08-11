using UnityEngine;
using System.Collections;

public class WeeleQuaternion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
    float t = 0.0f;
    public Vector3 myDir = new Vector3(1, 1, 0);
    public float myAngle = 45;
    // Update is called once per frame
    void Update () {

        // Assegnamo un quaternione a weedle
        t += Time.deltaTime;

        
        Quaternion quat = Quaternion.AngleAxis(myAngle*t, myDir);

        transform.rotation = quat;
	}
}
