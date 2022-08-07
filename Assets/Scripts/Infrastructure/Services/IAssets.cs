using UnityEngine;

namespace Infrastructure.Services
{
    public interface IAssets
    {
        GameObject Instantiate(string path, Vector3 at);
    }
}