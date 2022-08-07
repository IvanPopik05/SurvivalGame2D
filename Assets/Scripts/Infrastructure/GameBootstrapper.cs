using DefaultNamespace;
using Infrastructure.Factory;
using Infrastructure.Services;
using UnityEngine;

namespace Infrastructure
{
    public class GameBootstrapper : MonoBehaviour
    {
        [SerializeField] private PlayerSpawner _playerSpawner;
        [SerializeField] private BoxSpawner _boxSpawner;
        private void Start()
        {
            IAssets assets = new AssetProvider();
            IGameFactory gameFactory = new GameFactory(assets);
            _playerSpawner.Initialize(gameFactory);
            _boxSpawner.Initialize(gameFactory);
        }
    }
}