using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeContent : MonoBehaviour
{
    [SerializeField] GameObject leftButton;
    [SerializeField] GameObject rightButton;

    [Header("Contents")]
    [SerializeField] int index;
    [SerializeField] List<GameObject> contents;

    void Awake()
    {
        index = 0;

        foreach (var cont in contents)
        {
            cont.SetActive(false);
        }

        UpdateUI();
    }

    public void NextContent()
    {
        leftButton.SetActive(true);
        if(index >= contents.Count)
        {
            index = contents.Count - 1;
            rightButton.SetActive(false);
        }
        UpdateUI();
    }

    public void PrevContent()
    {
        rightButton.SetActive(true);
        if(index <= 0)
        {
            index = 0;
            leftButton.SetActive(false);
        }
        UpdateUI();
    }

    public void UpdateUI()
    {
        contents[index].SetActive(true);
    }
}
