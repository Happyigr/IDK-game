using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private int _lifes;

    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            var vertSpeed = Input.GetAxis("Vertical");
            var horizSpeed = Input.GetAxis("Horizontal");

            _rb.velocity = new Vector2(0, 0);
            _rb.AddForce(new Vector2(vertSpeed * _speed * Time.deltaTime, horizSpeed * Time.deltaTime * _speed));
        }
    }
}
