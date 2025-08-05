using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    private float _xSpeed;
    private float _ySpeed;

    public float speed = 3;

    private string xInput = "Horizontal";
    private string yInput = "Vertical";




    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _xSpeed = Input.GetAxis(xInput);
        _ySpeed = Input.GetAxis(yInput);

        _rigidbody2D.velocity = new Vector2(_xSpeed, _ySpeed) * speed ;
    }
}
