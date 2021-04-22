using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using UnityEngine.UI;

public class DialogueTwo : MonoBehaviour
{
    public Question[] dialogues;
    private static List<Question> unansweredDialogues;
    private Question currentDialogue;
    [SerializeField]
    private TMP_Text dialogueText;
    [SerializeField]
    private float timeBtwDialogues = 1f;

    public int ctr;

    // Start is called before the first frame update
    void Start()
    {
        if (unansweredDialogues == null || unansweredDialogues.Count == 0)
        {
            unansweredDialogues = dialogues.ToList<Question>();
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

        if (ctr <= 10)
        {
            int randomQuestionIndex = Random.Range(0, unansweredDialogues.Count);
            currentDialogue = unansweredDialogues[randomQuestionIndex];

            dialogueText.text = currentDialogue.fact;
        }
        else
        {
            ctr = 0;
        }
    }

    IEnumerator GoToNextQuestion()
    {
        unansweredDialogues.Remove(currentDialogue);
        yield return new WaitForSeconds(timeBtwDialogues);

        SetCurrentQuestion();
    }

    public void SelectTrue()
    {
        StartCoroutine(GoToNextQuestion());
    }

    public void SelectFalse()
    {
        StartCoroutine(GoToNextQuestion());
    }
}
