using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private float _spawnTime = 2f;
    [SerializeField] private Transform _target;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        WaitForSeconds wait = new WaitForSeconds(_spawnTime);

        while (enabled)
        {
            Enemy enemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);

            enemy.SetTarget(_target);

            yield return wait;
        }
    }
}
