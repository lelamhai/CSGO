using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MouseLookAtAround : MonoBehaviour
{
    //private float _rotateX;
    //private float _rotateY;

    //private float _sensitivity = 15f;
    //public Transform _target;

    private Vector3 currentVelocity;
    private float _xAxis;
    private float _yAxis;
    private float _rotationSensitivity = 0.3f;
    private float _minRotation = -40f;
    private float _maxRotation = 80f;
    private Vector3 _targetRotation;


    private void Update()
    {
        //_rotateY += Input.GetAxis("Mouse X") * _sensitivity;
        //_rotateX += Input.GetAxis("Mouse Y") * _sensitivity;

        //_rotateX = Mathf.Clamp(_rotateX, -40f, 40f);

        //this.transform.eulerAngles = new Vector3(_rotateX, _rotateY, 0);
        //this.transform.position = _target.position - this.transform.forward * -4f;

        _yAxis += Input.GetAxis("Mouse X") * _rotationSensitivity;
        _xAxis -= Input.GetAxis("Mouse Y") * _rotationSensitivity;

        _xAxis = Mathf.Clamp(_xAxis, _minRotation, _maxRotation);

        _targetRotation = Vector3.SmoothDamp(_targetRotation, new Vector3(_xAxis, _yAxis, 0), ref currentVelocity, 0.12f);
        this.transform.eulerAngles = _targetRotation;

        this.transform.position = _targetRotation - transform.forward * 4f;
    }
}