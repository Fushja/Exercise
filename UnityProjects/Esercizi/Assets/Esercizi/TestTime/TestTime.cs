using UnityEngine;
using System.Collections;

public class TestTime : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("in start il tempo è: " + Time.time);
        //Time.timeScale = 10;
        Debug.Log("Real time : " + Time.realtimeSinceStartup);
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Update " + Time.time + "\n dt:"+Time.deltaTime);

        //non viene modificato dal time scale
        Debug.Log("Unscaled: " + Time.unscaledTime + "\n dt: " + Time.unscaledDeltaTime);
        
	}

    void FixedUpdate()
    {
        Debug.LogWarning("Fixed Update " + Time.fixedTime + "\n dt:" + Time.fixedDeltaTime);


    }


}
