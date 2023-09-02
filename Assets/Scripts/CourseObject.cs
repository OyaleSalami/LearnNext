using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Course
{
    public string hash;
    public int points;
}

public class CourseObject : MonoBehaviour
{
    [SerializeField] Course course;
}

public enum LangType
{
    Python,
    JavaScript,
    CPlusPlus,
    CSharp
}

