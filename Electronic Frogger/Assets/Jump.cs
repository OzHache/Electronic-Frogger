using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    bool jump = false;
    bool jumping = false;
    public float height;
    public Rigidbody rb;
    public Vector3 gravity;
    public float sideMove;
    bool movingSide = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Reset()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = false;
        }
        if (Physics.gravity != gravity)
        {
            Physics.gravity = gravity;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) && !movingSide) {
            if (Input.GetKeyDown(KeyCode.LeftArrow)){
                sideMove = -1;
            } else
            {
                sideMove = 1;
            }
            movingSide = true;
        }
    }
    private void FixedUpdate()
    {
        jump = Input.GetKey(KeyCode.Space);
        if (jump && !jumping)
        {
            jump = false;
            jumping = true;
            rb.AddForce(Vector3.up * height, ForceMode.Acceleration);
        }
        if (jump)
        {
            jump = false;
        }
        if(sideMove != 0)
        {
            var pos = transform.position;
            float x = Mathf.Clamp(pos.x + sideMove, -5, 5);
            transform.position = new Vector3(x, pos.y, pos.z);
            sideMove = 0f;
            movingSide = false;

        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        jumping = false; 
    }
}
