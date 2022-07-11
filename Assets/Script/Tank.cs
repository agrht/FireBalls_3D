using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class Tank : MonoBehaviour
    {
        [SerializeField] private Transform _shootPoint;
        [SerializeField] private Bullet _bulletTemplate;
        [SerializeField] private float _delayBtwShoots;

        private float _timeAfterShoot;

        private void Update()
        {
            _timeAfterShoot += Time.deltaTime;

            if (Input.GetMouseButton(0))
            {
                if (_timeAfterShoot > _delayBtwShoots)
                {
                    Shoot();
                    _timeAfterShoot = 0;
                }
            }
        }

        private void Shoot()
        {
            Instantiate(_bulletTemplate, _shootPoint.position, Quaternion.identity);
        }
    }
}