using UnityEngine;
using System.Collections;

public class MyFirstPersonController : MonoBehaviour {
    [Range(1, 5)]    
    public int moveSpeed = 2;

    

    public Transform capsule;
    // Use this for initialization
    void Start () {
        Cursor.lockState = CursorLockMode.Locked;
        
    }
	
	// Update is called once per frame
	void Update () {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        /*transform.Rotate(Vector3.up, mouseX * 180 * Time.deltaTime , Space.World);

        transform.Rotate(Vector3.right, mouseY * 90 *  Time.deltaTime);*/


        transform.Rotate(Vector3.up, mouseX * 180 * Time.deltaTime, Space.World);
        

        transform.Rotate(transform.right, mouseY * -90 * Time.deltaTime, Space.World);
        Debug.Log(mouseX);


        /*if (Input.GetKey(KeyCode.W)) 
        {
            capsule.transform.position += (capsule.transform.forward *  Time.deltaTime * moveSpeed);
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            capsule.transform.position -= (capsule.transform.forward * Time.deltaTime * moveSpeed);

        }
        if (Input.GetKey(KeyCode.A))
        {
            capsule.transform.position -= (capsule.transform.right * Time.deltaTime * moveSpeed );

        }
        if (Input.GetKey(KeyCode.D))
        {
            capsule.transform.position += (capsule.transform.right * Time.deltaTime * moveSpeed);

        }

        if (Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.S))
        {
            moveSpeed = 4;
        }
        else
        {
            moveSpeed = 2;
        }*/

    }
}
