using UnityEngine;

public class PlayerCursor : MonoBehaviour
{
    private float _x;
    private float _y;
    private Vector2 _cursor = Vector2.zero;
    public Vector2 CursorGamePlay => _cursor;

    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        _x = Input.GetAxis("Mouse X");
        _y = Input.GetAxis("Mouse Y");
        _cursor = new Vector2(_x,_y);
    }
}