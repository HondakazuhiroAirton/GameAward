using UnityEngine.SceneManagement;
public class SceneChanger
{
    private bool changeFlag;

    public static void SceneChange(string sceneName)
    {
        // if(changeFlag)
        SceneManager.LoadScene(sceneName);
    }
}
