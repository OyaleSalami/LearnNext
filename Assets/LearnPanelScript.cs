using UnityEngine;
using UnityEngine.SceneManagement;

public class LearnPanelScript : MonoBehaviour
{
    public void SelectLearnCourse(string hash)
    {
        if(SceneManager.GetSceneByName(hash) == null)
        {

        }
        else
        {
            SceneManager.LoadScene(hash); //Go to the scene
        }
    }
}
