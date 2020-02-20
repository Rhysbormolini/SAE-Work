using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour

{

    public float speed = 7;

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

    }
}