using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] public Enemy enemyPrefab;
    [SerializeField] public Transform[] spawnPoints;
    [SerializeField] public float spawnTime = 2f;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnTime);

        while (true)
        {
            Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Enemy enemy = Instantiate(enemyPrefab, randomSpawnPoint.position, randomSpawnPoint.rotation);
            float randomDirection = Random.Range(0f, 360f);

            enemy.DirectionFromAngle(randomDirection);

            yield return wait;
        }
    }
}
