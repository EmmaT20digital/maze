using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    GameObject camera;

    Rigidbody rb;
    float speed = 250f;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
       
        rb.velocity = new Vector3(h * speed * Time.deltaTime, 0, v * speed * Time.deltaTime);

       camera.transform.position = transform.position + new Vector3(0, 1, -3);

    }
}
