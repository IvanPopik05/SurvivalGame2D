using System.Collections.Generic;
using Infrastructure.Factory;
using UnityEngine;

namespace DefaultNamespace
{
    public class BoxSpawner : MonoBehaviour
    {
        [SerializeField] private TransBox _transBox;
        [SerializeField] private int amountItems = 20;

        private List<TransBox> _boxes = new List<TransBox>();
        private GeneratorRandom _generatorRandom;
        private IGameFactory _gameFactory;
        public void Initialize(IGameFactory gameFactory)
        {
            _gameFactory = gameFactory;
            _generatorRandom = new GeneratorRandom();

            for (int i = 0; i < amountItems; i++)
            { 
                Spawn();
            }
        }

        private void Spawn()
        {
            GameObject newObject = _gameFactory.CreateElement(_transBox.gameObject, _generatorRandom.GetRandomPosition(),transform);
            TransBox newBox = newObject.GetComponent<TransBox>();
            _boxes.Add(newBox);
        }
    }
}