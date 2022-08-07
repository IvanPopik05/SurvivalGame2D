using DefaultNamespace;
using Infrastructure.Factory;
using UnityEngine;

namespace Player_container
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private Gun _gun;
        
        private Camera _camera;
        public void Initialize(IGameFactory gameFactory)
        {
            _gun.Initialize(gameFactory);
            _camera = Camera.main;
            CameraFollow cameraFollow = _camera.GetComponent<CameraFollow>();
            
            cameraFollow.Setup(() => transform.position);
        }
    }
}