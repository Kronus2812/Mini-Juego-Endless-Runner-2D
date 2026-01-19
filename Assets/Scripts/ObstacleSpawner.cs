using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2f;  // Intervalo de spawn
    public float spawnDistance = 5f;  // Distancia MÍNIMA reducida para spawns más cerca
    public float extraRandomDistance = 2f;  // ← Distancia extra aleatoria REDUCIDA (era 4f)

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
        // Spawn MÁS CERCA: spawnX = lastSpawnX + spawnDistance + Random.Range(0.5f, extraRandomDistance)
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
