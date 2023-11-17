using UnityEngine;

public class Enemy : MonoBehaviour
{
    private MovementBall _movement;

    private void Awake()
    {
        _movement = GetComponent<MovementBall>();
    }

    public void SetTarget(Transform target) => _movement.SetTarget(target);
}
