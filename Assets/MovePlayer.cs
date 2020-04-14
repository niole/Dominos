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

        player.AddForce(horiz, 0f, vert, ForceMode.VelocityChange);

    }

    float ApplySpeed(float output)
    {
        return output * speed * Time.deltaTime;
    }
}
