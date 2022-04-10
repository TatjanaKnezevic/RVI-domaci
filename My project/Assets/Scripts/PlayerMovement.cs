using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] Camera cam;

    [SerializeField] Weapon weapon;
    [SerializeField, Range(1f, 5f)] private float speed  = 5f;
    private float horizontal;
    private float vertical;

    private void Awake() {
        Debug.Log("Awake");
    }

    private void OnEnable() {
        Debug.Log("OnEnable");
    }

    private void OnDisable() {
        Debug.Log("OnDisable");
    }

    void Start()
    {
        Debug.Log("Start");
    }

    private void FixedUpdate() {
        Move();
    }

    // Update is called once per frame
    void Update() {
        GetInput();
        RotateCharacter();
        
        if (Input.GetMouseButton(0)) {
            if (weapon != null) {
                weapon.Shoot();
            }
        }
    }

    private void GetInput() {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void Move() {
        Vector3 changeInPosition = new Vector3(horizontal, 0f, vertical);
        Vector3 goToPosition = transform.position + changeInPosition * speed * Time.deltaTime;
        rigidbody.MovePosition(goToPosition);
        //transform.Translate(changeInPosition * Time.deltaTime * speed);
    }

    private void RotateCharacter() {
        RaycastHit hit;
        if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity)) {
            transform.LookAt(new Vector3(hit.point.x, 1f, hit.point.z));
        }
    }

    private void OnDestroy() {
        Debug.Log("OnDestroy");
    }
}
