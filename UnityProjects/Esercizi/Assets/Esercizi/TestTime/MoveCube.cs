using UnityEngine;
using System.Collections;

public class MoveCube : MonoBehaviour {

    public float speed = 1f;
    public Transform targetTr;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 distance = targetTr.position - this.transform.position;
        Vector3 direction =(targetTr.position-this.transform.position).normalized;

        


        if (distance.magnitude > 0.1f)
        {
            
            transform.position = transform.position + direction * speed * Time.deltaTime;
            //this.enabled = false;
        }

        else
        {
            transform.position = targetTr.position;
        }
        /*
        if (transform.position.y > targetTr.position.y)
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        else
        {
            transform.position = targetTr.position;
        }
        */
	
	}
}
