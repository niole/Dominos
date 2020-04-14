using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoAdder : MonoBehaviour
{
    public float rotationSpeed = 1000f;

    public GameObject particle;

    private bool isDown = false;

    // Update is called once per frame
    void Update()
    {

        Debug.Log($"particl {particle}, is down: {isDown}");

        Vector3 mousePos=new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f);
        Debug.Log(particle.transform);
        if(Input.GetMouseButtonDown(0)) {
            isDown = true;
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit,1000f)) {
                GameObject newParticle = Instantiate(particle, hit.point, Quaternion.identity);
                particle = newParticle;
                //or for tandom rotarion use Quaternion.LookRotation(Random.insideUnitSphere)
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDown = false;
        }

        if (isDown)
        {
            // check for rotations
            float x = AddRotationSpeed(Input.GetAxis("Mouse X"));
            particle.transform.Rotate(0, x, 0);
        }

        float AddRotationSpeed(float output)
        {
            return output * rotationSpeed * Time.deltaTime;
        }
    }
}
