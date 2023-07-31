using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subjective : MonoBehaviour
{

    public bool correct;
    [SerializeField] bool answer;

    public void AnswerTrue()
    {
        if(answer == true)
        {
            correct = true;
        }
        else
        {
            //TODO: Display Help Message
        }
    }

    public void AnswerFalse()
    {
        if (answer == false)
        {
            correct = true;
        }
        else
        {
            //TODO: Display Help Message
        }
    }
}
