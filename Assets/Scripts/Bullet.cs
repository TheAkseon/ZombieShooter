using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour 
{
    [SerializeField] private float _speed = 65f;
    [SerializeField] private float _lifeTimeBullet = 2f;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
        _lifeTimeBullet -= Time.deltaTime;
        if (_lifeTimeBullet <= 0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
