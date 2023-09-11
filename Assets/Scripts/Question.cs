using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    [SerializeField] string question;
    [SerializeField] string help;
    [SerializeField] string[] answers;
    [SerializeField] int correctAnswer;

    [Header("UI")]
    [SerializeField] Text questionText;
    [SerializeField] Text helpText;
    [SerializeField] Text answer1;
    [SerializeField] Text answer2;


    [SerializeField] GameObject helpPanel;
    [SerializeField] ChallengeManager challengeManager;

    void Start()
    {
        questionText.text = question;
        answer1.text = answers[0];
        answer2.text = answers[1];
        helpText.text = help;

        challengeManager = FindObjectOfType<ChallengeManager>();
    }

    public void AnswerQuestion(int answer)
    {
        if(answer == -1)
        {
            //Move on but don't add to the progress
            challengeManager.NextPage();
        }
        else if(answer == correctAnswer)
        {
            //Passed the question
            challengeManager.AddProgress();
            challengeManager.NextPage();
        }
        else
        {
            //Wrong Answer, Display help
            helpPanel.SetActive(true);
        }
    }
}
