using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform _camera;
    private CameraFollow _cameraFollow;
    private InputPC _input;
    private PlayerCursor _playerCursor;
    private PlayerMovement _playerMovement;
    private PlayerRotate _playerRotate;
    private PlayerLocomotionAnimation _playerLocomotionAnimation;


    private void Start()
    {
        _camera = Camera.main.transform;
        _cameraFollow = _camera.GetComponent<CameraFollow>();
        _input = this.transform.Find("Model").GetComponent<InputPC>();
        _playerCursor = this.transform.Find("Model").GetComponent<PlayerCursor>();
        _playerMovement = this.transform.Find("Model").GetComponent<PlayerMovement>();
        _playerRotate = this.transform.Find("Model").GetComponent<PlayerRotate>();
        _playerLocomotionAnimation = this.transform.Find("Model").GetComponent<PlayerLocomotionAnimation>();
    }

    private void FixedUpdate()
    {
        _playerMovement.HandleMovement(_camera, _input.InputDir);
        _playerRotate.HandleRotation(_camera, _input.InputDir);
        _playerLocomotionAnimation.ChangeLocomotionAnimation(_input.InputDir);
    }

    private void LateUpdate()
    {
        _cameraFollow.CursorDirection(_playerCursor.CursorGamePlay, this.transform.Find("Model").Find("Target"));
    }
}