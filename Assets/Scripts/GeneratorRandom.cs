using UnityEngine;

namespace DefaultNamespace
{
    public class GeneratorRandom
    {
        private readonly float _screenCoordsX = 200f;
        private readonly float _screenCoordsY = 90f;
        
        private Vector2 _randomPoint;

        public Vector2 GetRandomPosition()
        {
            _randomPoint = new Vector2(GetRandomValue(_screenCoordsX),GetRandomValue(_screenCoordsY));
            return _randomPoint;
        }

        private float GetRandomValue(float value) => 
            Random.Range(-value, value);
    }
}