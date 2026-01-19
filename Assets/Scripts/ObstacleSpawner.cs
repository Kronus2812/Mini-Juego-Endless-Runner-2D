using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2f;  
    public float spawnDistance = 5f;  
    public float extraRandomDistance = 2f;  

    private float timer;
    private float lastSpawnX = 0f;

    private void Start()
    {
        ResetTimer();
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            SpawnObstacle();
            ResetTimer();
        }
    }

    private void SpawnObstacle()
    {
        float spawnX = lastSpawnX + spawnDistance + Random.Range(0.5f, extraRandomDistance);
        Vector3 spawnPosition = new Vector3(spawnX, transform.position.y, 0);
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
        lastSpawnX = spawnX;
    }

    private void ResetTimer()
    {
        timer = spawnInterval;
    }
}
