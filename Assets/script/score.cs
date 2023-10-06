using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    private spawner _score;
    public TMP_Text Text;
    public float TotalScore;

    // Start is called before the first frame update
    void Start()
    {
        _score = FindObjectOfType<spawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_score != null)
        {
            _score.AddCoins(1.0f);
        }

        if (Text != null)
        {
            Text.text = "Score: " + spawner.CoinsCollected.ToString();
        }
    }
}
