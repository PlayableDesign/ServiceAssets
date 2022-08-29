
using UnityEngine;

[CreateAssetMenu(fileName = "InputServiceAsset", menuName = "ServiceAssets/InputServiceAsset")]
public class InputServiceAsset : ScriptableObject
{
    [Header("Key Mappings")]
    [Space(10)]

    [SerializeField] private KeyCode up;
    [SerializeField] private KeyCode left;
    [SerializeField] private KeyCode down;
    [SerializeField] private KeyCode right;

    public Vector3 Poll()
    {
        var direction = Vector3.zero;

        if (Input.GetKey(up)) direction += Vector3.forward;
        if (Input.GetKey(left)) direction += Vector3.left;
        if (Input.GetKey(down)) direction += Vector3.back;
        if (Input.GetKey(right)) direction += Vector3.right;

        return direction.normalized;
    }
}
