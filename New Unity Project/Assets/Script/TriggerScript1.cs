using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript1 : MonoBehaviour
{

    public GameObject entry;

    void OnTriggerEnter()
    {
        Destroy(entry);
    }

}
