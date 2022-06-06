using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputName : MonoBehaviour {

    public InputField inputText;
    public Text inputName;
    public GameObject buttonOk;

    protected string nickName = "";
    protected Text time;

    void Start() {
        
    }

    void Update() {
        if (inputName.text.Length < 3) {
            buttonOk.SetActive(false);
        }

        if (inputName.text.Length >= 3) {
            buttonOk.SetActive(true);
        }
    }

    public void accept() {
        if (inputName.text.Length > 3) {
            nickName = inputName.text;
            PlayerPrefs.SetString("currentNick", nickName);
            GameManager.saved = true;
            SceneSwitcher.OpenScene(1);
        } else {
            Debug.LogError("Nombre muy corto");
        }
    }
}
