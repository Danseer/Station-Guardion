using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    private AudioSource _collisionSound;

    private void Awake()
    {
        BallTrigger.CollisionSound.AddListener(PlayCollisionSound);
    }
    void Start()
    {
        _collisionSound = GetComponent<AudioSource>();
    }

    public void PlayCollisionSound()
    {
        _collisionSound.Play();
    }
}
