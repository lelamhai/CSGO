using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    private float _speed = 13f;

    public void HandleRotation(Transform camera, Vector2 input)
    {
        Vector3 targetDirection = Vector3.zero;

        targetDirection = camera.forward * input.y;
        targetDirection = targetDirection + camera.right * input.x;

        targetDirection.Normalize();
        targetDirection.y = 0;

        if(targetDirection == Vector3.zero)
        {
            targetDirection = this.transform.forward;
        }

        Quaternion targetRotate = Quaternion.LookRotation(targetDirection);
        Quaternion playerRotate = Quaternion.Lerp(this.transform.rotation, targetRotate, _speed * Time.deltaTime);
        this.transform.rotation = playerRotate;
    }
}