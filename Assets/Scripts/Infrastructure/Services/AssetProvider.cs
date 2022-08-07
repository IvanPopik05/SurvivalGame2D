using UnityEngine;

namespace Infrastructure.Services
{
    public class AssetProvider : IAssets
    {
        public GameObject Instantiate(string path, Vector3 at)
        {
            GameObject prefab = Resources.Load(path) as GameObject;
            return GameObject.Instantiate(prefab, at,prefab.transform.rotation);
        }
    }
}