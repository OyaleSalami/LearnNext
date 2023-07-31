using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CourseManager : MonoBehaviour
{
    [SerializeField] public List<Course> courses;

    [Header("UI Updates")]
    [SerializeField] Image courseImage;
    [SerializeField] Text courseTitle;
    [SerializeField] int courseIndex;

    void Start()
    {
        courseIndex = 0;
    }

    void UpdateUI()
    {
        courseTitle.text = courses[courseIndex].title;
    }

    public void NextCourse()
    {
        courseIndex += 1;

        if (courseIndex >= courses.Count)
        {
            courseIndex = courses.Count;
        }
        UpdateUI();
    }

    public void PrevCourse()
    {
        courseIndex -= 1;

        if (courseIndex <= 0)
        {
            courseIndex = 0;
        }
        UpdateUI();
    }

    public void SelectCourse(int index)
    {

    }

    public void Achievements()
    {
        SceneManager.LoadScene("Achievements");
    }
}
