using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    public Rigidbody rb;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        

        Vector3 force = new Vector3(moveHorizontal, 0, 0);

        rb.AddForce(force * speed);
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Pick Up"))
    //    {
    //        other.gameObject.SetActive(false);
    //    }
    }
