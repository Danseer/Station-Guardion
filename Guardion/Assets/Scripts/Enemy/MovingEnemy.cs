using UnityEngine;

public class MovingEnemy : MonoBehaviour
{
    [SerializeField] private float _speedMove;

    void FixedUpdate()
    {
        transform.Translate(_speedMove * Time.deltaTime, 0, 0);
    }
}
