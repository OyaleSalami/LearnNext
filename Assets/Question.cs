using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    public bool isCorrect; //Is the answer correct or not
    public string question;
    public Text questionText;


    public GameObject helpPanel;
    public GameObject winPanel;

    public void Start()
    {
    }
}
