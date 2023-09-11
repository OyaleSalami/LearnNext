using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChallengeManager : MonoBehaviour
{
    [Header("Details")]
    [SerializeField] string courseHash;

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
    [SerializeField] Text winText;
    [SerializeField] GameObject winPanel;


    void Start()
    {
        pageIndex = 0;
        progress = 0;
        totalPages = pages.Count;

        UpdateUI();
    }

    public void SetProgress()
    {
        float prog = ((float)progress / (float)totalPages) * 100;
        PlayerPrefs.SetFloat(courseHash, prog);
    }

    public void GoBack()
    {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
    }

    public void CheckAchievements()
    {
        SceneManager.LoadScene("Achievements", LoadSceneMode.Single);
    }

    public void UpdateProgressUI()
    {
        progressText.text = progress + "/" + totalPages;

        if (totalPages == 0)
        {
            return;
        }

        float percent = (float)progress / (float)totalPages;

        if (percent >= 1)
        {
            percent = 1;
        }

        progressImage.fillAmount = percent;

        winText.text = "Your Progress: \n" + progress + "/" + totalPages;
    }

    public void NextPage()
    {
        pageIndex++;

        leftButton.SetActive(true);

        if (pageIndex >= pages.Count)
        {
            pageIndex = pages.Count - 1;
            rightButton.SetActive(false);

            //Challenges Done
            SetProgress();
            winPanel.SetActive(true);
        }

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

    public void AddProgress()
    {
        progress++;

        if (progress >= totalPages)
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
