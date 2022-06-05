using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;

public class TimeController : MonoBehaviour {

    [SerializeField] int min, seg;
    //[SerializeField] Text tiempo;

    public GameObject tiempo;
    private float restante;
    public static bool enMarcha;

    public GameObject gameOver;

    private void Awake() {
        restante = (min * 60) + seg;
        enMarcha = true;
    }
   
    // Update is called once per frame
    void Update() {
        if (enMarcha) {
            restante -= Time.deltaTime;
            if (restante < 1) {
                gameOver.SetActive(true);
                Other();
                ScoringSystem.theScore = 0;
                enMarcha = false;
            }
            int tempMin = Mathf.FloorToInt(restante / 60);
            int tempSeg = Mathf.FloorToInt(restante % 60);
            tiempo.GetComponent<Text>().text = string.Format("{00:00}:{01:00}", tempMin, tempSeg);
        }
    }

    protected async void Other() {
        await Task.Delay(3000);
        SceneSwitcher.OpenScene(1);
        await Task.Delay(100);
    }
}
