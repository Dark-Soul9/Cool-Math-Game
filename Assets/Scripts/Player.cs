using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float speed = 5;
    private bool gameEnd;
    // Start is called before the first frame update
    void Start()
    {
        gameEnd = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameEnd)
        {
            return;
        }    
        Move();
    }

    void Move()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        float newPosX = speed * horizontalInput * Time.deltaTime;
        float newPosY = speed * verticalInput * Time.deltaTime;
        transform.Translate(Vector3.right * newPosX);
        transform.Translate(Vector3.forward * newPosY);
        Bounds();
        
        
    }
    void Bounds()
    {
        if (transform.position.z < -9)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -9);
        }
        if (transform.position.z > -8)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -8);
        }
        if (transform.position.x < -2)
        {
            transform.position = new Vector3(-2, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 2)
        {
            transform.position = new Vector3(2, transform.position.y, transform.position.z);
        }
        if( transform.position.y < -4)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Equation"))
        {
            gameEnd = true;
        }
    }
}
