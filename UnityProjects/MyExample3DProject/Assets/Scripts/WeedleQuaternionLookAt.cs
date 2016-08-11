using UnityEngine;
using System.Collections;

public class WeedleQuaternionLookAt : MonoBehaviour {

    public Transform targetTransform;
    public Vector3 fromDirection ;
    Quaternion fromRot;
    void Start()
    {
        fromDirection = transform.forward;
        fromRot = this.transform.rotation;
        targetTransform = this.transform;

    }
    float t = 0.0f;
    public Vector3 myDir = new Vector3(1, 1, 0);
    public float myAngle = 45;
    // Update is called once per frame
    void Update()
    {
        // Direzione dove voglio arrivare
        Vector3 lookAtDirection = targetTransform.position - this.transform.position;

        // Direzione da dove parto
        t += Time.deltaTime;
        
        lookAtDirection.Normalize();




        // Assegno la rotazione per farmi ruotare verso 'lookat'

        if (fromDirection != lookAtDirection)
        {
            Quaternion finalQuat = Quaternion.FromToRotation(fromDirection, lookAtDirection);
            Quaternion slerpQuat = Quaternion.Slerp(Quaternion.identity, finalQuat, t);
            transform.rotation = slerpQuat * fromRot;
        }
        
    }
}
