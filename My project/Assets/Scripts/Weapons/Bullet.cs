using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    private int damage;

    public void SetUp(int damage) {
        this.damage = damage;
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }

    private void OnCollisionEnter(Collision other) {
        if (other != null) {
            Enemy character = other.gameObject.GetComponent<Enemy>();
            if(character != null) {
                Debug.Log(character);
                character.TakeDamage(damage);
            }

            Destroy(gameObject);
        }
    }
}
