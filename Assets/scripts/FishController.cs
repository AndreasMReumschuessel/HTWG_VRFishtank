using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishController : MonoBehaviour {
    public float velocity = 0.01F;
    public float scale = 1F;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        transform.localScale = new Vector3(scale, scale, scale);
        transform.position = new Vector3(Random.Range(1, 9), Random.Range(1, 9), Random.Range(1, 9));
        transform.Rotate(Random.Range(-5, 5), Random.Range(1, 180), 0);
    }
    // Update is called once per frame
    void Update () {
        transform.Translate(0, 0, velocity*Time.deltaTime);
    } 

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("verticalPlane"))
        {
            transform.Rotate(0, transform.rotation.y + Random.Range(70,100), 0);
        }

        if (other.gameObject.CompareTag("horizontalPlane"))
        {
            transform.Rotate(transform.rotation.x + Random.Range(70, 100), 0, transform.rotation.z + Random.Range(70, 100));
        }
    }  
}
