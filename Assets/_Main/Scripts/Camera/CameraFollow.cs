using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Vector3 _offeset = Vector3.zero;
    private float _speed = 0.3f;
    private Vector3 _cameraVelocity = Vector3.zero;

    public void FollowTarget(Vector3 target)
    {
        Vector3 targetPostion = target + _offeset;
        this.transform.position = Vector3.SmoothDamp(this.transform.position, targetPostion, ref _cameraVelocity, _speed);
    }
}