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

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            Enemy enemy = Instantiate(enemyPrefab, randomSpawnPoint.position, randomSpawnPoint.rotation);

            float randomDirection = Random.Range(0f, 360f);

            Enemy enemyMovement = enemy.GetComponent<Enemy>();

            if (enemyMovement != null)
            {
                enemyMovement.DirectionFromAngle(randomDirection);
            }

            yield return new WaitForSeconds(spawnTime);
        }
    }
}
