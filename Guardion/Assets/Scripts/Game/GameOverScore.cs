using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{
    [SerializeField] private Text _text;

    void Start()
    {
        //_text.text = PlayerPrefs.GetInt("Score").ToString();
       // PlayerPrefs.SetInt("Score", 0);
    }

  
}
