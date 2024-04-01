using UnityEngine;
using System.Collections;

public class InputPC : MonoBehaviour
{
    private float _inputX;
    private float _inputY;
    private Vector2 input;

    public Vector2 InputDir => input;

    private void Update()
    {
        _inputX = Input.GetAxis("Horizontal");
        _inputY = Input.GetAxis("Vertical");

        input = new Vector2(_inputX, _inputY);
    }
}