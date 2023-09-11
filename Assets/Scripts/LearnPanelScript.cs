using UnityEngine;
using UnityEngine.SceneManagement;

public class LearnPanelScript : MonoBehaviour
{
    public void SelectLearnCourse(string hash)
    {
        Debug.Log("Changed Scene");

        if(SceneManager.GetSceneByName(hash) == null)
        {

        }
        else
        {
            SceneManager.LoadScene(hash, LoadSceneMode.Single); //Go to the scene
        }
    }
}
