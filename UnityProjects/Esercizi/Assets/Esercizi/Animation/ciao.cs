using UnityEngine;
using System.Collections;

public class ciao : MonoBehaviour {

    public AnimationCurve curve;

    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isWalkingRight", true);
    }

	// Use this for initialization
	void Start () {
	
	}
    float time;
    // Update is called once per frame
    /*void Update () {
        time += Time.deltaTime;

        Vector3 tmpPos = this.transform.position;
        tmpPos.x = curve.Evaluate(time);
        this.transform.position = tmpPos;
	}

    public void Ciao()
    {

        Debug.Log("Ciao");
    }*/
    
    bool facingRight = true;
    void Update()
    {
        int currentSpeed = 0;
        if (Input.GetKey(KeyCode.D))
        {
            currentSpeed = 5;
            facingRight = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            currentSpeed = -5;
            facingRight = false;
        }

        transform.Translate(transform.right * currentSpeed * Time.deltaTime);

        animator.SetInteger("XSpeed", currentSpeed);
        animator.SetBool("facingRight", facingRight);
    }
}
