using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove2 : MonoBehaviour
{
	int playerSpeed = 150;
	Rigidbody _rigidBody;
    Vector3 startPos;
    Vector3 startScale;
    float etime = 0f;

    // Start is called before the first frame update
    private void Start()
    {
    	_rigidBody = GetComponent<Rigidbody>();
        startPos = transform.position;
        startScale = transform.localScale;
    }

    // Update is called once per frame
    private void Update(){
        etime += Time.deltaTime;
    }
    private void FixedUpdate()
    {
        // add wasd movement
        float zSpeed = Input.GetAxis("Vertical") * playerSpeed;
        float xSpeed = Input.GetAxis("Horizontal") * playerSpeed;
        float ySpeed = 0f;

        Vector3 add_vec = new Vector3(xSpeed, ySpeed, zSpeed);
        _rigidBody.AddForce(add_vec);
        // Debug.Log("Added Vector:" + add_vec.ToString());

        // Timer mechanic
        transform.localScale *= 1f - (etime/15000f);
        // Debug.Log("Scale: " + transform.localScale.ToString() + ", Time: " + etime.ToString());
        if (transform.localScale.x <= 0.35){
            transform.localScale = startScale;  // reset player if too small
            transform.position = startPos;
            // TODO: change color over time
        }
        // transform.rotation (forces  = addTorque)
    }
}
