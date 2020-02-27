using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour

{

    public float speed = 7;
    public float jumpHeight = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float Straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        Straffe *= Time.deltaTime;

        transform.Translate(Straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
        
        if (Input.GetKey(KeyCode.Space) == true && Mathf.Abs(this.GetComponent<Rigidbody>().velocity.y) < 0.01f)
        {
            this.GetComponent<Rigidbody>().velocity += Vector3.up * this.jumpHeight;
        }
    }
}