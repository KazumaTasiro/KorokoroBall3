using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpPlayer : MonoBehaviour
{
    public float power = 15;
    public Vector3 jumpAngle = new Vector3(1, 0, 0);
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody r=other.GetComponent<Rigidbody>();
        if (r != null)
        {
            r.velocity = jumpAngle.normalized*power;
        }
    }
}
