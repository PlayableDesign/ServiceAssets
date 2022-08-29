
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CubeController : MonoBehaviour
{
    [SerializeField] private InputServiceAsset inputService;
    [SerializeField] private MovementServiceAsset movementService;

    private Rigidbody body;
    private Vector3 direction;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
        direction = Vector3.zero;
        movementService.Initialize(body, GetComponent<Collider>());
    }

    private void Update()
    {
        direction = inputService.Poll();
    }

    private void FixedUpdate()
    {
        if (direction == Vector3.zero) return;

        movementService.Move(body, direction);
    }
}
