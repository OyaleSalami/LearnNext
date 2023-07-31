using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Course
{
    public string hash;
    public string title;
    public int points;
}

public class CourseObject : MonoBehaviour
{
    [SerializeField] Course course;
}

public enum CourseType
{
    Python,
    CPlusPlus,
    CSharp
}

