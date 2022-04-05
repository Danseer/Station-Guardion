using UnityEngine;
using UnityEngine.Events;

public class BallTrigger : MonoBehaviour
{
    public static UnityEvent<int> AddScoreEvent = new UnityEvent<int>();
    public static UnityEvent FallAsteroidEvent = new UnityEvent();
    public static UnityEvent CollisionSound = new UnityEvent();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CollisionSound?.Invoke();

        if (collision.gameObject.tag == "Enemy")
            EnemyTrigger(collision);
       
        else if (collision.gameObject.tag == "Bonus")
            BonusTrigger(collision);
       
        Destroy(collision.gameObject);
     

    }

    private void EnemyTrigger(Collider2D collision)
    { 
        FallAsteroidEvent?.Invoke();
    }

    private void BonusTrigger(Collider2D collision)
    {
        AddScoreEvent?.Invoke(5);
    }

}
