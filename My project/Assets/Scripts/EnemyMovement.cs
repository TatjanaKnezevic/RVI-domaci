using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField, Range(1f, 5f)] private float speed  = 5f;
    private float horizontal;
    private int counter = 0;
    private float vertical;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if (counter == 100) {
            counter = 0;
            CalculateDirection();
        }
        Move();
    }

    private void CalculateDirection() {
        horizontal = Random.Range(-1, 2);
        vertical = Random.Range(-1, 2);
    }

    private void Move() {
        Vector3 changeInPosition = new Vector3(horizontal, 0f, vertical);
        transform.Translate(changeInPosition * speed * Time.deltaTime);
    }
}
