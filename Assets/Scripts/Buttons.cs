using UnityEngine;

public class Buttons : MonoBehaviour
{
    private float _speed = 3;
    private Rigidbody2D _rigidbody2D;
    private Vector2 _moveVelocity;


    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown()
    {
        transform.localScale = new Vector3(0.95f, 0.95f, 0.95f);
    }

    private void OnMouseUp()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
    }

    private void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        _moveVelocity = moveInput.normalized * _speed;
    }

    private void FixedUpdate()
    {
        _rigidbody2D.MovePosition(_rigidbody2D.position + _moveVelocity * Time.fixedDeltaTime);
    }
}
