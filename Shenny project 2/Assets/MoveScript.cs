using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float speed = 10f;
    public float jumpSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()

    {

        float x = Input.GetAxis("Horizontal"); //1 



        float z = Input.GetAxis("Vertical"); //2 



        Vector3 move = (transform.right * x + transform.forward * z) * speed * Time.deltaTime; //3  



        if (Input.GetKey("w"))
        {

            transform.position += move; //4 

        }

        if (Input.GetKey("s"))
        {

            transform.position += move;

        }

        if (Input.GetKey("a"))
        {

            transform.position += move;

        }

        if (Input.GetKey("d"))
        {

            transform.position += move;

        }


        if (Input.GetKey("space"))
        {

            //transform.position = transform.position + Vector3.up * speed;
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);

        }



    }
}
