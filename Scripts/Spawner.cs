using System.Collections;
using UnityEngine;

/*ѕродолжаем работать над проектом с генерацией врагов. 

“еперь кажда€ точка спауна создает свой тип врагов и имеет цель, 
то есть объект, к которому идут враги. ¬ момент создани€ точка спауна 
передает врагу свою цель, чтобы тот направилс€ к ней. 
“аких целей должно быть несколько, у каждого спавнера сво€ цель.

—ами цели движутс€ по заранее определенному маршруту, 
от одной точки к другой.

—давать как проект на Git и видео демонстрацию*/


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