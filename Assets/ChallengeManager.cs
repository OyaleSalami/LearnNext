using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChallengeManager : MonoBehaviour
{
    [SerializeField] public int progress;
    [SerializeField] public int totalProgress;

    [SerializeField] public Text progressText;
    [SerializeField] public Image progressImage;

    public void AddProgress()
    {
        progress += 1;

        if (progress == totalProgress) //Clamp the progress value
        {
            progress = totalProgress;
        }

        UpdateUI();
        SaveProgress();
    }

    public void UpdateUI()
    {
        progressText.text = progress.ToString() + "/" + totalProgress.ToString(); //eg 3/10

        if (progress == 0)
        {
            progressImage.fillAmount = 0;
        }
        else
        {
            progressImage.fillAmount = progress/totalProgress;
        }
    }

    public void SaveProgress()
    {
        //eg 0_datatype_progress //Python data type progress
        string hash = CourseManager.langType.ToString() + "_datatype_progress";
        PlayerPrefs.SetInt(hash, progress);
    }

    public void Back() //Go back to home
    {
        SceneManager.LoadScene("Main Menu");
    }
}
