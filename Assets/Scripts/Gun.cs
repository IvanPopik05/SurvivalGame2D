using System;
using Infrastructure.Factory;
using UnityEngine;

namespace DefaultNamespace
{
    public class Gun : MonoBehaviour
    {
        private const string FIRE = "Fire1";
        
        [SerializeField] private Bullet _bulletPrefab;
        [SerializeField] private Transform _spawnBullet;
        
        private IGameFactory _gameFactory;
        private Collider2D _playerCollider;
        private Camera _camera;
        public void Initialize(IGameFactory gameFactory)
        {
            _camera = Camera.main;
            _gameFactory = gameFactory;
        }

        private void Update()
        {
            var mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0;

            var direction = (mousePosition - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            
            transform.eulerAngles = new Vector3(0,0,angle);
            if (Input.GetButtonDown(FIRE)) 
                Spawn();
        }

        private void Spawn()
        {
            Bullet element = _gameFactory.CreateElement(_bulletPrefab,_spawnBullet.position);
            element.Initialize(transform.right);
        }
    }
}