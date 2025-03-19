using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _spawnTime = 2f;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        WaitForSeconds wait = new WaitForSeconds(_spawnTime);

        while (enabled)
        {
            Transform randomSpawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
            Enemy enemy = Instantiate(_enemyPrefab, randomSpawnPoint.position, randomSpawnPoint.rotation);
            float randomDirection = Random.Range(0f, 360f);

            Vector3 direction = new Vector3(Mathf.Cos(randomDirection), 0, Mathf.Sin(randomDirection)).normalized;

            enemy.SetDirection(direction);

            yield return wait;
        }
    }
}