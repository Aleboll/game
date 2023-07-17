using UnityEngine;
using TMPro;

public sealed class ScoreCounte : MonoBehaviour
{
    public static ScoreCounte Instance { get; private set; }

    private int _score;

    public int Score
    {
        get => _score;

        set
        {
            if (_score == value) return;

            _score = value;

            scoreText.SetText(sourceText: $"Score = {_score}");
        }
    }

    [SerializeField] private TextMeshProUGUI scoreText;

    private void Awake() => Instance = this;

    public int HighScore = 0;


}
