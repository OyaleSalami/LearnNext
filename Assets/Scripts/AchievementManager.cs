using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AchievementManager : MonoBehaviour
{
    [SerializeField] List<AchievementObject> achievementObjects;

    void Start()
    {
        UpdateObjects();
    }

    public void UpdateObjects()
    {
        foreach (var achievement in achievementObjects)
        {
            achievement.UpdateUI();
        }
    }

    public void Back()
    {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
    }
}
