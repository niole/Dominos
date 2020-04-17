using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleDominoCollision : MonoBehaviour
{
    public Rigidbody domino;

    public float collisionMultiplier = 40f;

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Domino Collided");
        if (other.gameObject.tag=="Domino")
        {
            Debug.Log("Collided with domino");
            domino.velocity += (Time.deltaTime * collisionMultiplier * domino.velocity);
        }
    }
}
