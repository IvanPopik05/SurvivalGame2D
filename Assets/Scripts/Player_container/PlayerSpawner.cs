using Infrastructure.Factory;
using Player_container;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    
    private PlayerController _playerController;
    public void Initialize(IGameFactory gameFactory)
    {
        GameObject newObject = gameFactory.CreatePlayer(_spawnPoint.position);

        _playerController = newObject.GetComponent<PlayerController>();
        _playerController.Initialize(gameFactory);
    }
}