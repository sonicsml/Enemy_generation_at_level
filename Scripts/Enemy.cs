using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 _direction;
    private float _speed = 5f;
    private Transform _target;

    private void Update()
    {
        _direction = (_target.position - transform.position).normalized;
        transform.Translate(_direction * _speed * Time.deltaTime, Space.World);
    }

    public void SetTarget(Transform newTarget)
    {
        _target = newTarget;
    }
}
