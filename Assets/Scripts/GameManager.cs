using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public bool isAlive = true;

    public Text currentScore;
    public Text highScoreText;
    public string nickName = "";

    public int score { get; private set; }
    public int highScore { get; private set; }
    protected ArrayList highScores;
    protected ArrayList names;
    public HighScores high;
    public const string pathData = "SaveGames";
    public const string nameFile = "HighScores";

    public InputField inputText;
    public Text inputName;
    public GameObject buttonOK;
    public GameObject inputDisable;

    protected bool nullField = true;
    protected bool gameOver = false;
    protected int place = 0;

    void Start() {
        
    }

    void Update() {
        if (isAlive) {
            if (!TimeController.enMarcha) {
                Debug.Log("TimeOut");
            }

            saveScores();
        }
    }

    private void NewGame() {
        var dataFound = LoadAndSaveData.LoadData<HighScores>(pathData, nameFile);
        if (dataFound != null)  {
            high = dataFound;
            highScores = new ArrayList();
            highScores.Add(high.top1);
            highScores.Add(high.top2);
            highScores.Add(high.top3);
            highScores.Add(high.top4);
            highScores.Add(high.top5);
            highScores.Add(high.top6);
            highScores.Add(high.top7);
            highScores.Add(high.top8);
            highScores.Add(high.top9);
            highScores.Add(high.top10);

            names = new ArrayList();
            names.Add(high.str1);
            names.Add(high.str2);
            names.Add(high.str3);
            names.Add(high.str4);
            names.Add(high.str5);
            names.Add(high.str6);
            names.Add(high.str7);
            names.Add(high.str8);
            names.Add(high.str9);
            names.Add(high.str10);

            updateHighScore();
        }
        else
        {
            high = new HighScores();
            saveScores();
        }

        //SetScore(0);
    }

    protected void save()
    {
        //saveNicks();
        names[place] = nickName;

        high.top1 = (int)highScores[0];
        high.top2 = (int)highScores[1];
        high.top3 = (int)highScores[2];
        high.top4 = (int)highScores[3];
        high.top5 = (int)highScores[4];
        high.top6 = (int)highScores[5];
        high.top7 = (int)highScores[6];
        high.top8 = (int)highScores[7];
        high.top9 = (int)highScores[8];
        high.top10 = (int)highScores[9];

        high.str1 = (string)names[0];
        high.str2 = (string)names[1];
        high.str3 = (string)names[2];
        high.str4 = (string)names[3];
        high.str5 = (string)names[4];
        high.str6 = (string)names[5];
        high.str7 = (string)names[6];
        high.str8 = (string)names[7];
        high.str9 = (string)names[8];
        high.str10 = (string)names[9];

        //resetHighScores();
        LoadAndSaveData.SaveData(high, pathData, nameFile);
    }

    protected void saveScores()
    {
        if (score > (int)highScores[0])
        {
            highScores[9] = highScores[8];
            names[9] = names[8];
            highScores[8] = highScores[7];
            names[8] = names[7];
            highScores[7] = highScores[6];
            names[7] = names[6];
            highScores[6] = highScores[5];
            names[6] = names[5];
            highScores[5] = highScores[4];
            names[5] = names[4];
            highScores[4] = highScores[3];
            names[4] = names[3];
            highScores[3] = highScores[2];
            names[3] = names[2];
            highScores[2] = highScores[1];
            names[2] = names[1];
            highScores[1] = highScores[0];
            names[1] = names[0];
            highScores[0] = score;
            place = 0;
            //visibleButtons();
        }
        else if (score > (int)highScores[1])
        {
            highScores[9] = highScores[8];
            names[9] = names[8];
            highScores[8] = highScores[7];
            names[8] = names[7];
            highScores[7] = highScores[6];
            names[7] = names[6];
            highScores[6] = highScores[5];
            names[6] = names[5];
            highScores[5] = highScores[4];
            names[5] = names[4];
            highScores[4] = highScores[3];
            names[4] = names[3];
            highScores[3] = highScores[2];
            names[3] = names[2];
            highScores[2] = highScores[1];
            names[2] = names[1];
            highScores[1] = score;
            place = 1;
            //visibleButtons();
        }
        else if (score > (int)highScores[2])
        {
            highScores[9] = highScores[8];
            names[9] = names[8];
            highScores[8] = highScores[7];
            names[8] = names[7];
            highScores[7] = highScores[6];
            names[7] = names[6];
            highScores[6] = highScores[5];
            names[6] = names[5];
            highScores[5] = highScores[4];
            names[5] = names[4];
            highScores[4] = highScores[3];
            names[4] = names[3];
            highScores[3] = highScores[2];
            names[3] = names[2];
            highScores[2] = score;
            place = 2;
            //visibleButtons();
        }
        else if (score > (int)highScores[3])
        {
            highScores[9] = highScores[8];
            names[9] = names[8];
            highScores[8] = highScores[7];
            names[8] = names[7];
            highScores[7] = highScores[6];
            names[7] = names[6];
            highScores[6] = highScores[5];
            names[6] = names[5];
            highScores[5] = highScores[4];
            names[5] = names[4];
            highScores[4] = highScores[3];
            names[4] = names[3];
            highScores[3] = score;
            place = 3;
            //visibleButtons();
        }
        else if (score > (int)highScores[4])
        {
            highScores[9] = highScores[8];
            names[9] = names[8];
            highScores[8] = highScores[7];
            names[8] = names[7];
            highScores[7] = highScores[6];
            names[7] = names[6];
            highScores[6] = highScores[5];
            names[6] = names[5];
            highScores[5] = highScores[4];
            names[5] = names[4];
            highScores[4] = score;
            place = 4;
            //visibleButtons();
        }
        else if (score > (int)highScores[5])
        {
            highScores[9] = highScores[8];
            names[9] = names[8];
            highScores[8] = highScores[7];
            names[8] = names[7];
            highScores[7] = highScores[6];
            names[7] = names[6];
            highScores[6] = highScores[5];
            names[6] = names[5];
            highScores[5] = score;
            place = 5;
            //visibleButtons();
        }
        else if (score > (int)highScores[6])
        {
            highScores[9] = highScores[8];
            names[9] = names[8];
            highScores[8] = highScores[7];
            names[8] = names[7];
            highScores[7] = highScores[6];
            names[7] = names[6];
            highScores[6] = score;
            place = 6;
            //visibleButtons();
        }
        else if (score > (int)highScores[7])
        {
            highScores[9] = highScores[8];
            names[9] = names[8];
            highScores[8] = highScores[7];
            names[8] = names[7];
            highScores[7] = score;
            place = 7;
            //visibleButtons();
        }
        else if (score > (int)highScores[8])
        {
            highScores[9] = highScores[8];
            names[9] = names[8];
            highScores[8] = score;
            place = 8;
            //visibleButtons();
        }
        else if (score > (int)highScores[9])
        {
            highScores[9] = score;
            place = 9;
            //visibleButtons();
        }
        else
        {
            //SceneManager.LoadScene("MainMenu");
        }
    }

    protected void saveNicks()
    {
        if (score > (int)highScores[0])
        {
            names[0] = nickName;
        }
        else if (score > (int)highScores[1])
        {
            names[1] = nickName;
        }
        else if (score > (int)highScores[2])
        {
            names[2] = nickName;
        }
        else if (score > (int)highScores[3])
        {
            names[3] = nickName;
        }
        else if (score > (int)highScores[4])
        {
            names[4] = nickName;
        }
        else if (score > (int)highScores[5])
        {
            names[5] = nickName;
        }
        else if (score > (int)highScores[6])
        {
            names[6] = nickName;
        }
        else if (score > (int)highScores[7])
        {
            names[7] = nickName;
        }
        else if (score > (int)highScores[8])
        {
            names[8] = nickName;
        }
        else if (score > (int)highScores[9])
        {
            names[9] = nickName;
        }
    }

    protected void resetHighScores()
    {
        high.top1 = 0;
        high.top2 = 0;
        high.top3 = 0;
        high.top4 = 0;
        high.top5 = 0;
        high.top6 = 0;
        high.top7 = 0;
        high.top8 = 0;
        high.top9 = 0;
        high.top10 = 0;

        high.str1 = "NULL";
        high.str2 = "NULL";
        high.str3 = "NULL";
        high.str4 = "NULL";
        high.str5 = "NULL";
        high.str6 = "NULL";
        high.str7 = "NULL";
        high.str8 = "NULL";
        high.str9 = "NULL";
        high.str10 = "NULL";
    }

    private void updateHighScore()
    {
        highScoreText.text = "HIGH SCORE\n" + high.top1;
    }

    public void accept()
    {
        if (inputName.text.Length > 3)
        {
            nickName = inputName.text;
            inputDisable.SetActive(false);
            buttonOK.SetActive(false);
            nullField = false;
            //SceneManager.LoadScene("MainMenu");
        }
        else
        {
            Debug.LogError("Nombre muy corto");
        }
    }
}
