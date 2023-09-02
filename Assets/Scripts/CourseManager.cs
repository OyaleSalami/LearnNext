using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CourseManager : MonoBehaviour
{
    public List<string> langs; //List of languages
    public static LangType langType;

    [Header("UI Updates")]
    [SerializeField] Image langImageDisplay;
    [SerializeField] Sprite[] langImages;
    [SerializeField] Text langTitle;
    [SerializeField] int langIndex;

    void Start()
    {
        langIndex = 0;
        langType = LangType.Python;
        UpdateUI();
    }

    void UpdateUI()
    {
        //Update Images and Text
        langTitle.text = langs[langIndex];
        langImageDisplay.sprite = langImages[langIndex];
    }

    public void NextLang()
    {
        langIndex += 1;

        if (langIndex >= langs.Count)
        {
            langIndex = langs.Count - 1;
        }

        UpdateUI();
    }

    public void PrevLang()
    {
        langIndex -= 1;

        if (langIndex <= 0)
        {
            langIndex = 0;
        }

        UpdateUI();
    }

    public void Achievements()
    {
        SceneManager.LoadScene("Achievements");
    }
}
