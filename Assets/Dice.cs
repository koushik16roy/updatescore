using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dice : MonoBehaviour
{
    public Text score;
    public Text highscore;

    public void Start()
    {
        highscore.text = PlayerPrefs.GetInt("HIGHSCORE",0).ToString(); 
    }

    public void RollDice()
    {
        int number = Random.Range(1, 7);
        score.text = number.ToString();

        if(number > PlayerPrefs.GetInt("HIGHSCORE",0))
        {
            PlayerPrefs.SetInt("HIGHSCORE", number);
            highscore.text = number.ToString();
        }
    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        highscore.text = "0";
    }
}
