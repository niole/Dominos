using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleDominoCollision : MonoBehaviour
{
    public Rigidbody domino;

    public float collisionMultiplier = 50f;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="Domino")
        {
            domino.velocity += (Time.deltaTime * collisionMultiplier * domino.velocity);
        }
    }
}
