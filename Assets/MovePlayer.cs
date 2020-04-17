using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody player;

    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {

        float vert = ApplySpeed(Input.GetAxis("Vertical"));
        float horiz = ApplySpeed(Input.GetAxis("Horizontal"));

        Debug.Log($"{vert} {horiz}");

        if (vert != 0f || horiz != 0f)
        {
            player.AddForce(horiz, 0f, vert, ForceMode.VelocityChange);
        }
        else
        {
            player.velocity = Vector3.zero;
            player.angularVelocity = Vector3.zero;
        }

        if (player.velocity.magnitude > 10f)
        {
            player.velocity = player.velocity.normalized * 10f;
        }
    }

    float ApplySpeed(float output)
    {
        return output * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="Domino")
        {
            player.velocity = Vector3.zero;
            player.angularVelocity = Vector3.zero;
        }
    }
}
