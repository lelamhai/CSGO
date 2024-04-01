using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform _camera;
    private InputPC _input;
    private PlayerMovement _playerMovement;
    private PlayerRotate _playerRotate;
    private PlayerLocomotionAnimation _playerLocomotionAnimation;

    private void Start()
    {
        _camera = Camera.main.transform;
        _input = this.transform.Find("Model").GetComponent<InputPC>();
        _playerMovement = this.transform.Find("Model").GetComponent<PlayerMovement>();
        _playerRotate = this.transform.Find("Model").GetComponent<PlayerRotate>();
        _playerLocomotionAnimation = this.transform.Find("Model").GetComponent<PlayerLocomotionAnimation>();
    }

    private void FixedUpdate()
    {
        _playerMovement.HandleMovement(_camera, _input.InputDir);
        _playerRotate.HandleRotation(_camera, _input.InputDir);
        _playerLocomotionAnimation.ChangeLocomotion(_input.InputDir);
    }
}