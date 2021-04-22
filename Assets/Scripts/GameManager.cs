using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Question[] questions;
    private static List<Question> unansweredQuestions;
    private Question currentQuestion;

    [SerializeField]
    private TMP_Text factText;

    [SerializeField]
    private float timeBtwQuestions = 1f;

    //[SerializeField]
    //private TMP_Text trueAnswerText;

    //[SerializeField]
    //private TMP_Text falseAnswerText;

    //[SerializeField]
    //private Animator anim;

    public int scoreGameOne;
    public int mistakesGameOne;
    public int ctr;

    // Start is called before the first frame update
    void Start()
    {
        if(unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }
        SetCurrentQuestion();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void SetCurrentQuestion()
    {
        ++ctr;

        if(ctr <= 15)
        {
            int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
            currentQuestion = unansweredQuestions[randomQuestionIndex];

            factText.text = currentQuestion.fact;

            if (currentQuestion.isTrue)
            {
               //trueAnswerText.text = "CORRECT";
               //falseAnswerText.text = "WRONG";
            }
            else
            {
               //trueAnswerText.text = "WRONG";
               //falseAnswerText.text = "CORRECT";
            }
        }
        else
        {
            PlayerPrefs.SetInt("pScoreOne", scoreGameOne);
            PlayerPrefs.SetInt("mScoreOne", mistakesGameOne);
            unansweredQuestions = null;
            ctr = 0;
            SceneManager.LoadScene("ScoreScene");
        }
    }

    IEnumerator GoToNextQuestion()
    {   
        unansweredQuestions.Remove(currentQuestion);
        yield return new WaitForSeconds(timeBtwQuestions);

        SetCurrentQuestion();
    }

    public void SelectTrue()
    {
        if(currentQuestion.isTrue)
        {
            //anim.SetTrigger("True");
            Debug.Log("CORRECT!");
            ++scoreGameOne; 
        }
        else
        {
            Debug.Log("WRONG!");
            ++mistakesGameOne;
        }

        StartCoroutine(GoToNextQuestion());
    }

    public void SelectFalse()
    {
        //anim.SetTrigger("False");
        if (!currentQuestion.isTrue)
        {
            Debug.Log("CORRECT!");
            ++scoreGameOne;
        }
        else
        {
            Debug.Log("WRONG!");
            ++mistakesGameOne;
        }

        StartCoroutine(GoToNextQuestion());
    }
}
