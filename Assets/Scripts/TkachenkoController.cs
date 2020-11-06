using UnityEngine;

public class TkachenkoController : MonoBehaviour
{
    [SerializeField]
    private Transform _handsHolder;

    [SerializeField]
    private float _rotateSpeed = 50f;

    void Start()
    {
        Debug.Log("Alexander Tkachenko greets you!");
    }

    private void Update()
    {
        _handsHolder.Rotate(new Vector3(Time.deltaTime * _rotateSpeed, 0, 0), Space.Self);
    }
}
