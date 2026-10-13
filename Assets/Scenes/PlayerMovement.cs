using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public Vector2 speed;
    public float moveSpeed = 5f;
    public void OnMove(InputValue inputValue)
    {
        speed = inputValue.Get<Vector2>();
    }


    void Update()
    {
        transform.Translate(moveSpeed * speed * Time.deltaTime);
    }
}
