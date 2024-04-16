using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    RaycastHit hit;
    public float force = 1.0f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    public void OnCollisionEnter(Collision collison)
    {
        rb.AddForce(Vector3.up * force);
    }
}
