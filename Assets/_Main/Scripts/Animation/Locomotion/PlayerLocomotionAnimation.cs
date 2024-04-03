using UnityEngine;

public class PlayerLocomotionAnimation : MonoBehaviour
{
    private Animator _animator;
    private int _velocityHash;

    private void Start()
    {
        _animator = this.GetComponent<Animator>();
        _velocityHash = Animator.StringToHash("Velocity");
    }

    public void ChangeLocomotionAnimation(Vector2 inputDir)
    {
        float speed = (inputDir.normalized).magnitude;
        _animator.SetFloat(_velocityHash, speed);
    }    
}