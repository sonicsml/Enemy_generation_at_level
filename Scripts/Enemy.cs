using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 _direction;
    private float _speed = 5f;

    private void Update()
    {
        Move();
    }

    public void DirectionFromAngle(float angle)
    {
        float angleOnRadians = angle * Mathf.Rad2Deg;
        _direction = new Vector3(Mathf.Cos(angleOnRadians), 0, Mathf.Sin(angleOnRadians)).normalized;
    }

    private void Move()
    {
        transform.Translate(_direction * _speed * Time.deltaTime, Space.World);
    }
}
