using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> spawnedEnemies;
    public GameObject enemyPrefab;
    public List<Vector3> spawnPoints;
    public int numberOfEnemies = 10;

    public GameObject SpawnEnemy() {
        Debug.Log("Enemy Spawned!");
        int index = Random.Range(0, spawnPoints.Capacity);
        Debug.Log("INDEX: " + index);
        return Object.Instantiate(enemyPrefab, spawnPoints[index], Quaternion.identity);
    }

    private void Awake() {
        for (int i=0; i<numberOfEnemies; i++) {
            spawnedEnemies.Add(SpawnEnemy());
        }
    }

    // Start is called before the first frame update
    void Start()
    {}

    // Update is called once per frame
    void Update()
    {
        
    }
}
