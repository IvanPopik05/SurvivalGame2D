using System;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

namespace DefaultNamespace
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private GameObject _poofPrefab;
        
        [SerializeField] private Vector3 _rotate;
        [SerializeField] private int _damage = 1;
        [SerializeField] private float _speed;

        private Transform _spawnTransform;
        public void Initialize(Vector2 dir)
        {
            _rigidbody.velocity = dir * _speed;
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            if (col.collider.TryGetComponent(out DestructibleObstacles obstacle))
            {
                Debug.Log("Damage");
                obstacle.TakeDamage(_damage);
            }

            GameObject effect = Instantiate(_poofPrefab, col.contacts[0].point, Quaternion.Euler(col.contacts[0].normal));
            Destroy(effect,3f);
            Destroy(gameObject);
        }

        private void Update()
        {
            transform.Rotate(_rotate * Time.deltaTime);
        }
    }
}