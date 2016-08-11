using UnityEngine;
using System.Collections;

public class Weedle : MonoBehaviour {
    public Transform player;
	// Use this for initialization
	void Start () {
        StartCoroutine(Move());
        
    }
	
	// Update is called once per frame
	void Update () {
        
        //
        transform.LookAt(player);
        

	}

    IEnumerator Move()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            GetComponent<Rigidbody>().AddForce(transform.forward, ForceMode.Impulse);
        }
        
    }
}
