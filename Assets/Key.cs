using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(door);
        Destroy(gameObject);
    }
}
