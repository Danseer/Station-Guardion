using UnityEngine;

public class MovingBall : MonoBehaviour
{
    [SerializeField] private float _speedRotate;

    void FixedUpdate()
    {
        startRotate();
    }

    public void startRotate()
    {
       transform.Rotate(0, 0, _speedRotate);
    }

    public void changeDirection()
    {
        _speedRotate = -_speedRotate;
    }
}
