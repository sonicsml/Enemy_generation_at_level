using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 _direction;
    private float _speed = 5f;

    private void Update()
    {
        transform.Translate(_direction * _speed * Time.deltaTime, Space.World);
    }

    public void SetDirection(Vector3 direction)
    {
        _direction = direction.normalized;
    }
}

