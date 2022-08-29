
using UnityEngine;

[CreateAssetMenu(fileName = "MovementServiceAsset", menuName = "ServiceAssets/MovementServiceAsset")]
public class MovementServiceAsset : ScriptableObject
{
    [Header("Movement Settings")]
    [Space(10)]

    [SerializeField] private float speed;

    [Header("RigidBody Settings")]
    [Space(10)]

    [SerializeField] private ForceMode forceMode;
    [SerializeField] private bool freezeRotation;

    [Header("Collider Settings")]
    [Space(10)]

    [Tooltip("Optional")]
    [SerializeField] private PhysicMaterial material;


    public void Initialize(Rigidbody body, Collider collider)
    {
        if (freezeRotation) body.constraints |= RigidbodyConstraints.FreezeRotation;
        if (material != null) collider.material = material;
    }

    public void Move(Rigidbody body, Vector3 direction)
    {
        Debug.Log($"Moving {body.name} in direction: {direction}");

        body.AddForce(direction * speed, forceMode);
    }
}
