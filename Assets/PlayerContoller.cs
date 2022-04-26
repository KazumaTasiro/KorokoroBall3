using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    public float power = 10;
    public Rigidbody rigidbody;
    public Vector3 respawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce(new Vector3(0, 0, 1) * power);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(new Vector3(-1, 0, 0) * power);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddForce(new Vector3(0, 0, -1) * power);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(new Vector3(1, 0, 0) * power);
        }
        if (Input.GetKeyDown(KeyCode.Return)|| transform.position.y <= -20)
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        transform.position = respawnPoint;
        rigidbody.velocity = new Vector3(0, 0, 0);
        rigidbody.angularVelocity = new Vector3(0, 0, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ChakePoint")
        {
            respawnPoint=other.transform.position;
        }
    }

}
