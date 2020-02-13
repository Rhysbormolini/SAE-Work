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
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            this.transform.position += this.transform.forward * movespeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            this.transform.position -= this.transform.forward * movespeed * Time.deltaTime;
        }



        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            transform.Rotate(Vector3.up * rotatespeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.Rotate(Vector3.up * -rotatespeed * Time.deltaTime);
        }


        
    }
}
