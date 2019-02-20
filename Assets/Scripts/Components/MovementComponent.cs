using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rb;

    private bool moving;
    private Vector2 direction;

    private void Start()
    {
        if (rb == null) rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var move = new Vector3(direction.x, 0, direction.y) * Time.deltaTime * speed;
        rb.MovePosition(rb.position + move);

        if (moving)
        {
            
        }
    }

    public void SetMoveInput(Vector2 dir)
    {
        moving = !(dir.x == 0 && dir.y == 0);
        direction = dir;
    }
}
