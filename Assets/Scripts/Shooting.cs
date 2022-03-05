using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private GameObject _positionBullet;

    [SerializeField] private int _maxAmmo = 0;
    [SerializeField] private int _currentAmmo;

    [SerializeField] private float _fireRate = 15f;
    [SerializeField] private float _nextTimeToFire = 0f;

    [SerializeField] private float _reloadTime = 2f;

    private bool _isReloading = false;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject newBullet = Instantiate(_bulletPrefab);
        newBullet.transform.position = _positionBullet.transform.position + _positionBullet.transform.forward;
        newBullet.transform.forward = _positionBullet.transform.forward;
    }
}
