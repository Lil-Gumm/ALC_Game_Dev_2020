using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour

{
    public float horizontalInput;
    public float speed = 15f;
    public float xrange = 15f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xrange)
        {
            transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xrange)
        {
            transform.position = new Vector3(xrange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);

        if (Input.GetKeyDown(KeyCode.Mouse0

            ))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
