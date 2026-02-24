using System;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : NetworkBehaviour
{
    [SerializeField] private CharacterController characterController;
    [SerializeField] private float speed = 1f;
    
    private Vector3 _movement;

    private void Start()
    {
        //_movement = new Vector3(1, 0, 1);
    }

    private void Update()
    {
        if (!IsOwner) { return; }
        characterController.Move(new Vector3(_movement.x, 0f, _movement.y) * (Time.deltaTime * speed));
    }

    void OnMovements(InputValue value)
    {
        _movement = value.Get<Vector2>();
    }
}
