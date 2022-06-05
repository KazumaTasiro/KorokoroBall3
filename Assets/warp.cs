using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warp : MonoBehaviour
{
    public GameObject exitObject;
    private void OnTriggerEnter(Collider other)
    {
        if(exitObject != null)
        {
            other.transform.position= exitObject.transform.position;
        }
    }
}
