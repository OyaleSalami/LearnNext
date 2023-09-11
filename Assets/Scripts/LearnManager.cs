using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LearnManager : MonoBehaviour
{
    [Header("Progress")]
    [SerializeField] int totalPages;
    [SerializeField] int progress;
    [SerializeField] Image progressImage;
    [SerializeField] Text progressText;

    [Header("Pages")]
    int pageIndex;
    [SerializeField] List<GameObject> pages;
    [SerializeField] GameObject leftButton;
    [SerializeField] GameObject rightButton;

    void Start()
    {
        pageIndex = 0;
        progress = 1;
        totalPages = pages.Count;

        UpdateUI();
    }

    public void GoBack()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void UpdateProgressUI()
    {
        progressText.text = progress + "/" + totalPages;

        if(totalPages == 0)
        {
            return;
        }

        float percent = (float)progress / (float)totalPages;

        if(percent >= 1)
        {
            percent = 1;
        }

        progressImage.fillAmount = percent;
    }

    public void NextPage()
    {
        pageIndex++;

        leftButton.SetActive(true);
        if (pageIndex >= pages.Count)
        {
            pageIndex = pages.Count - 1;
            rightButton.SetActive(false);
        }
        AddProgress();
        UpdateUI();
    }

    public void PrevPage()
    {
        pageIndex--;

        rightButton.SetActive(true);
        if (pageIndex <= 0)
        {
            pageIndex = 0;
            leftButton.SetActive(false);
        }

        UpdateUI();
    }

    void AddProgress()
    {
        progress++;

        if(progress >= totalPages)
        {
            progress = totalPages;
        }
    }

    public void UpdateUI()
    {
        UpdateProgressUI();
        foreach (var page in pages)
        {
            page.SetActive(false); //Disable all the other pages
        }

        pages[pageIndex].SetActive(true);
    }
}
