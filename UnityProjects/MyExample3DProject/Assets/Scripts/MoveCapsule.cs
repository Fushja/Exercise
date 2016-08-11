using UnityEngine;
using System.Collections;

public class MoveCapsule : MonoBehaviour {
    public Transform cameraObj;
    public Transform cameraWeedle;
    public Transform pivotCamera;

    public GameObject pokeball;
    public Transform spawnBall;

    [Range(1, 5)]
    int moveSpeed = 2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += (cameraObj.transform.forward * Time.deltaTime * moveSpeed);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= (cameraObj.transform.forward * Time.deltaTime * moveSpeed);

        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.position -= (cameraObj.transform.right * Time.deltaTime * moveSpeed);
            cameraObj.Rotate(Vector3.up);

        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.position += (cameraObj.transform.right * Time.deltaTime * moveSpeed);
            cameraObj.Rotate(-Vector3.up);
        }

        if (Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.S))
        {
            moveSpeed = 4;
        }
        else
        {
            moveSpeed = 2;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            GameObject newGo = Instantiate(pokeball);
            newGo.transform.position = spawnBall.position;
            newGo.GetComponent<Rigidbody>().AddForce(spawnBall.transform.forward * 10, ForceMode.Impulse );
        }
        float f = Input.GetAxis("Mouse ScrollWheel");
        if (f > 0)
        {
            if (cameraWeedle.localPosition.z < -2)
            {
                cameraWeedle.localPosition += new Vector3(0, 0, f);
                
            }
            
        }
        if (f < 0)
        {
            if (cameraWeedle.localPosition.z > -10)
            {
                cameraWeedle.localPosition -= new Vector3(0, 0, -f);
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pivotCamera.Rotate(new Vector3(0,50,0) *Time.deltaTime,Space.World );
            //

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pivotCamera.Rotate(new Vector3(0, -50, 0)*Time.deltaTime, Space.World);
            //

        }
    }
}
