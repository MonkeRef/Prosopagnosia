using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour {

    private int movementSpeed = 5;
    [SerializeField] private GameInput gameInput;

    private void Update () {
        HandleMovement();
    }

    private void HandleMovement () {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();
        Vector3 moveDir = new Vector3(inputVector.x, inputVector.y, 0f);
        transform.position += moveDir * movementSpeed * Time.deltaTime;
    }
}
