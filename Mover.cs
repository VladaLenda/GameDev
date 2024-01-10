using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Movement
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private bool _faceRight;

        private Rigidbody2D _rigidbody2D;
        private float _direction;

        private void Update()
        {
             _direction = Input.GetAxisRaw("Horizontal"); 
        }
        private void FixedUpdate()
        {
            Move(_direction);
        }
        private void Move(float direction)
        {
            _rigidbody2D.velocity = Vector2.right * _speed * direction;
        }

    }
}