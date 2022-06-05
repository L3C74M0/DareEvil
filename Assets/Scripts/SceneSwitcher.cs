using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {
     
    public static void OpenScene(int index) {
        SceneManager.LoadScene(index);
    }
}
