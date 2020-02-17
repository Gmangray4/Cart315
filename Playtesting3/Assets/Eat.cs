using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{


    void OnTriggerEnter(Collider col)
    {
        Debug.Log("OnCollisionEnter works.");
        if (col.gameObject.name == "FPSController")
        {
            Debug.Log("The GameObject name is Cube.");
            Destroy(col.gameObject);
        }
    }

}
