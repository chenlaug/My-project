using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlle : MonoBehaviour
{
    public float HorizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    public GameObject ProjectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(ProjectilePrefab, transform.position, ProjectilePrefab.transform.rotation);
        }
    }
}
