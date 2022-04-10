using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFizika : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Rigidbody rigidbody2;
    [SerializeField] MeshRenderer meshRenderer;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.J)) {
            rigidbody2.AddForce(Vector3.up*100, ForceMode.Force);
        }
        if(Input.GetKeyUp(KeyCode.K)) {
            rigidbody2.AddForce(Vector3.up*4, ForceMode.Impulse);
        }
        if(Input.GetKeyUp(KeyCode.L)) {
            rigidbody2.AddTorque(Vector3.up*10, ForceMode.VelocityChange);
        }
    }

    private void OnTriggerEnter(Collider other) {
        meshRenderer.material.color = Color.red; 
    }

    private void OnTriggerExit(Collider other) {
        meshRenderer.material.color = Color.white;
    }

    private void OnCollisionEnter(Collision other) {
        meshRenderer.material.color = Color.blue;
    }

    private void OnCollisionExit(Collision other) {
        meshRenderer.material.color = Color.white;
    }
}
