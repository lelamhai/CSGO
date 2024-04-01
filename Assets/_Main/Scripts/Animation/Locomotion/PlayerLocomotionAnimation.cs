using UnityEngine;

public class PlayerLocomotionAnimation : MonoBehaviour
{
    private Animator _animator;
    private int _horizontal;
    private int _vertical;

    private float _movementAmount;

    private void Start()
    {
        _animator = this.GetComponent<Animator>();
        _horizontal = Animator.StringToHash("Horizontal");
        _vertical = Animator.StringToHash("Vetical");
    }

    public void ChangeLocomotion(Vector2 input)
    {
        _animator.SetFloat(_horizontal, input.x, 0.1f, Time.deltaTime);
        _animator.SetFloat(_vertical, input.y, 0.1f, Time.deltaTime);
    }
}