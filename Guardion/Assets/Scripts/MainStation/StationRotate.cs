using UnityEngine;

public class StationRotate : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
   
    void FixedUpdate()
    {
        transform.Rotate(0, 0, _speed * Time.deltaTime);
    }
}
