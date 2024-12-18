using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemyPrefabs; // Array of enemy prefabs to spawn
    private float _spawnInterval; // Time interval between enemy spawns
    
    void Start()
    {
        _spawnInterval = Random.Range(7f, 12f); // Randomize the spawn interval
        
    }
    
    void Update()
    {
        _spawnInterval -= Time.deltaTime; // Decrease the spawn interval
        
        if (_spawnInterval <= 0)
        {
            // Randomly select an enemy prefab from the array
            GameObject enemyPrefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
            
            // Instantiate the enemy prefab at the spawner's position
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            
            _spawnInterval = Random.Range(7f, 12f); // Randomize the spawn interval
        }
    }
}