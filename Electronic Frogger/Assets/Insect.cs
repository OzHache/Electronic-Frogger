using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insect : MonoBehaviour
{
    public float distancePerBeat;
    float velocity;
    public Rigidbody rb;
    public float BPS;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void Reset()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void GetVelocity() {
        BPS = GameManager.GetGameManager.BPM / 60f;
        rb.velocity = Vector3.up * BPS;

    }

    // Update is called once per frame
    void Update()
    {
        GetVelocity();
    }

    private void FixedUpdate()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        transform.position += Vector3.down * 11f;
    }
}
