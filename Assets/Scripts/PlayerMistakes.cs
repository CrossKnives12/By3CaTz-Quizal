using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerMistakes : MonoBehaviour
{
    public TMP_Text intBoxed;
    public int mistakes;

    // Start is called before the first frame update
    void Start()
    {
        mistakes = PlayerPrefs.GetInt("mScoreOne");
        intBoxed.text = mistakes.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
