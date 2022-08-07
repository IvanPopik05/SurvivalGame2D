using System;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private float _cameraMoveSpeed = 3f;
        
    private Vector3 _cameraFollowPosition;
        
    private Func<Vector3> GetUpdatedCamera;
    public void Setup(Func<Vector3> getCameraUpdated) => 
        GetUpdatedCamera = getCameraUpdated;

    private void Update()
    {
        _cameraFollowPosition = GetUpdatedCamera();

        _cameraFollowPosition.z = transform.position.z;
        Vector3 cameraMoveDir = (_cameraFollowPosition - transform.position).normalized;
        float distance = Vector3.Distance(_cameraFollowPosition, transform.position);
            
        CameraPositionDetection(distance, cameraMoveDir);
    }

    private void CameraPositionDetection(float distance, Vector3 cameraMoveDir)
    {
        if (distance > 0)
        {
            Vector3 newCameraPosition = transform.position + cameraMoveDir * (distance * _cameraMoveSpeed * Time.deltaTime);

            float distanceAfterMoving = Vector3.Distance(newCameraPosition, _cameraFollowPosition);

            if (distanceAfterMoving > distance)
            {
                newCameraPosition = _cameraFollowPosition;
            }

            transform.position = newCameraPosition;
        }
    }
}