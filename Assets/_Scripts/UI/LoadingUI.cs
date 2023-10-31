using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadingUI : MonoBehaviour
{
    [Header("UI Elements")]
    public Slider loadingBar;
    public Text loadingPercentageText;
    public Text loadingStatusText;

    private AsyncOperation asyncOperation;

    public void LoadScene(string sceneName)
    {
        StartCoroutine(LoadSceneAsync(sceneName));
    }

    private IEnumerator LoadSceneAsync(string sceneName)
    {
        asyncOperation = SceneManager.LoadSceneAsync(sceneName);
        asyncOperation.allowSceneActivation = false;

        while (!asyncOperation.isDone)
        {
            float progress = Mathf.Clamp01(asyncOperation.progress / 0.9f);
            
            // Ažuriranje UI elemenata
            loadingBar.value = progress;
            loadingPercentageText.text = (progress * 100).ToString("0") + "%";
            loadingStatusText.text = "Loading...";

            // Kada je učitavanje završeno
            if (asyncOperation.progress >= 0.9f)
            {
                loadingStatusText.text = "Press any key to continue...";
                if (Input.anyKeyDown)
                {
                    asyncOperation.allowSceneActivation = true;
                }
            }

            yield return null;
        }
    }

}
