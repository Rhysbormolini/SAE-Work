using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{

    public GameObject door;

    void OnTriggerEnter()
    {
        Destroy(door);
    }
   
}
