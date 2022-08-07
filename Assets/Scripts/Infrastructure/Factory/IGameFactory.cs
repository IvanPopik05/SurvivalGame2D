using UnityEngine;

namespace Infrastructure.Factory
{
    public interface IGameFactory
    {
        GameObject CreateElement(GameObject prefab, Vector2 at, Transform container);
        GameObject CreateElement(GameObject prefab, Vector2 at);
        GameObject CreateElement(GameObject prefab);
        GameObject CreatePlayer(Vector3 at);
        T CreateElement<T>(T prefab) where T : MonoBehaviour;
        T CreateElement<T>(T prefab, Vector2 at) where T : MonoBehaviour;
    }
}