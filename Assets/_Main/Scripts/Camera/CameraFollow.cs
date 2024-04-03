using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraFollow : MonoBehaviour
{
    private Vector3 currentVelocity;
    private float _xAxis;
    private float _yAxis;
    private float _rotationSensitivity = 13f;
    private float _minRotation = -40f;
    private float _maxRotation = 80f;
    private Vector3 _targetRotation;

    public void CursorDirection(Vector2 cursor, Transform target)
    {
        _yAxis += cursor.x * _rotationSensitivity;
        _xAxis -= cursor.y * _rotationSensitivity;

        _xAxis = Mathf.Clamp(_xAxis, _minRotation, _maxRotation);

        _targetRotation = Vector3.SmoothDamp(_targetRotation, new Vector3(_xAxis, _yAxis, 0), ref currentVelocity, 0.12f);
        this.transform.eulerAngles = _targetRotation;

        this.transform.position = target.position - transform.forward * 4f;
    }

}