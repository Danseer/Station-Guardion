using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    [SerializeField] private Text _scoreText;
    public static int score=0;


    void Awake()
    {
        BallTrigger.AddScoreEvent.AddListener(UpdateScore);
        BallTrigger.FallAsteroidEvent.AddListener(Fall);
    }

    private void UpdateScore(int count)
    {
        score+=count;
        _scoreText.text = score.ToString();
    }

    private void Fall()
    {
        score = 0;
        SceneManager.LoadScene(2);
    }

    
}
