using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float movespeed = 10;
    public float rotatespeed = 10;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.transform.forward);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S) == true)
        {
            transform.position -= Camera.main.transform.forward * movespeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W) == true)
        {
            transform.position += Camera.main.transform.forward * movespeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * movespeed, Space.Self); //LEFT
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * movespeed, Space.Self); //RIGHT
        }
      
        /*if (Input.GetKey(KeyCode.D) == true)
        {
            transform.Rotate(Vector3.up * rotatespeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A) == true)
        {
            transform.Rotate(Vector3.up * -rotatespeed * Time.deltaTime);
        } */

    }
}

