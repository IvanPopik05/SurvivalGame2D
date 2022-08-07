using System;
using DefaultNamespace;
using Infrastructure.Services;
using UnityEngine;

namespace Infrastructure.Factory
{
    public class GameFactory : IGameFactory
    {
        public GameObject PlayerObject { get; private set; }

        private readonly IAssets _assets;
        public GameFactory(IAssets assets)
        {
            _assets = assets;
        }

        public GameObject CreatePlayer(Vector3 at)
        {
            GameObject newPlayer = _assets.Instantiate(AssetPath.Player, at);
            PlayerObject = newPlayer;
            return PlayerObject;
        }
        
        public GameObject CreateElement(GameObject prefab, Vector2 at, Transform container)
        {
            GameObject element = GameObject.Instantiate(prefab, at, Quaternion.identity,container);
            return element;
        }
        public GameObject CreateElement(GameObject prefab,Vector2 at)
        {
            GameObject element = GameObject.Instantiate(prefab,at,Quaternion.identity);
            return element;
        }

        public GameObject CreateElement(GameObject prefab)
        {
            GameObject element = GameObject.Instantiate(prefab);
            return element;
        }
        public T CreateElement<T>(T prefab) where T : MonoBehaviour
        {
            T element = GameObject.Instantiate(prefab);
            return element;
        }
        public T CreateElement<T>(T prefab, Vector2 at) where T : MonoBehaviour
        {
            T element = GameObject.Instantiate(prefab, at, Quaternion.identity);
            return element;
        }
    }
}