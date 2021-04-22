using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerScore : MonoBehaviour
{
    public TMP_Text intBox;
    public int value;

    // Start is called before the first frame update
    void Start()
    {
        value = PlayerPrefs.GetInt("pScoreOne");
        intBox.text = value.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
