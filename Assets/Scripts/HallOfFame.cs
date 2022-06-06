using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HallOfFame : MonoBehaviour {

    //On-screen labels-------------------------------
    public Text scores;
    public Text nicks;
    //-----------------------------------------------

    //Relationship with serialized class-------------
    public HighScores high;
    //-----------------------------------------------

    //Path where the files are saved-----------------
    public const string pathData = "SaveGames";
    public const string nameFile = "HighScores";
    //-----------------------------------------------

    //List of Scores and Names-----------------------
    protected ArrayList highScores;
    protected ArrayList names;
    //-----------------------------------------------

    //Current----------------------------------------
    protected string currentNick = "";
    protected string currentTime = "";
    //-----------------------------------------------

    private void Start() {
        //resetPrefs();
        
        if (GameManager.saved) {
            UpdatePrefs();
            ShowPrefs();
        } else {
            ShowPrefs();
        }
    }

    protected void resetPrefs() {
        PlayerPrefs.SetString("1N", "NULL1");
        PlayerPrefs.SetString("1T", "00:00");
        PlayerPrefs.SetString("2N", "NULL2");
        PlayerPrefs.SetString("2T", "00:00");
        PlayerPrefs.SetString("3N", "NULL3");
        PlayerPrefs.SetString("3T", "00:00");
        PlayerPrefs.SetString("4N", "NULL4");
        PlayerPrefs.SetString("4T", "00:00");
        PlayerPrefs.SetString("5N", "NULL5");
        PlayerPrefs.SetString("5T", "00:00");
        PlayerPrefs.SetString("6N", "NULL6");
        PlayerPrefs.SetString("6T", "00:00");
        PlayerPrefs.SetString("7N", "NULL7");
        PlayerPrefs.SetString("7T", "00:00");
        PlayerPrefs.SetString("8N", "NULL8");
        PlayerPrefs.SetString("8T", "00:00");
        PlayerPrefs.SetString("9N", "NULL9");
        PlayerPrefs.SetString("9T", "00:00");
        PlayerPrefs.SetString("10N", "NULL10");
        PlayerPrefs.SetString("10T", "00:00");

        Debug.LogError("Reseteó");
    }

    protected void ShowPrefs() {
        nicks.text = "";
        scores.text = "";

        nicks.text  += "" + PlayerPrefs.GetString("1N")  + "\n";
        scores.text += "" + PlayerPrefs.GetString("1T")  + "\n";
        nicks.text  += "" + PlayerPrefs.GetString("2N")  + "\n";
        scores.text += "" + PlayerPrefs.GetString("2T")  + "\n";
        nicks.text  += "" + PlayerPrefs.GetString("3N")  + "\n";
        scores.text += "" + PlayerPrefs.GetString("3T")  + "\n";
        nicks.text  += "" + PlayerPrefs.GetString("4N")  + "\n";
        scores.text += "" + PlayerPrefs.GetString("4T")  + "\n";
        nicks.text  += "" + PlayerPrefs.GetString("5N")  + "\n";
        scores.text += "" + PlayerPrefs.GetString("5T")  + "\n";
        nicks.text  += "" + PlayerPrefs.GetString("6N")  + "\n";
        scores.text += "" + PlayerPrefs.GetString("6T")  + "\n";
        nicks.text  += "" + PlayerPrefs.GetString("7N")  + "\n";
        scores.text += "" + PlayerPrefs.GetString("7T")  + "\n";
        nicks.text  += "" + PlayerPrefs.GetString("8N")  + "\n";
        scores.text += "" + PlayerPrefs.GetString("8T")  + "\n";
        nicks.text  += "" + PlayerPrefs.GetString("9N")  + "\n";
        scores.text += "" + PlayerPrefs.GetString("9T")  + "\n";
        nicks.text  += "" + PlayerPrefs.GetString("10N") + "\n";
        scores.text += "" + PlayerPrefs.GetString("10T") + "\n";
    }

    private void UpdatePrefs() {
        //Debug.LogError("Ya jugó");
        currentNick = PlayerPrefs.GetString("currentNick");
        currentTime = PlayerPrefs.GetString("currentTime");

        Debug.LogError(currentNick + " " + currentTime);

        /*
         *    0 = both the numbers are equal
         *    1 = second number is smaller || first number is bigger
         *   -1 = first number is smaller  || second number is bigger 
         *
         * El que tenga mayor tiempo restante es mas rapido
         */

        //Comparador pa ver donde lo guarda
        // I compare my time with the first
        if (1 == currentTime.CompareTo(PlayerPrefs.GetString("1T"))) {

            Debug.LogError("Mayor al mejor tiempo - Soy Primero");

            PlayerPrefs.SetString("10N", PlayerPrefs.GetString("9N"));
            PlayerPrefs.SetString("10T", PlayerPrefs.GetString("9T"));
            PlayerPrefs.SetString("9N", PlayerPrefs.GetString("8N"));
            PlayerPrefs.SetString("9T", PlayerPrefs.GetString("8T"));
            PlayerPrefs.SetString("8N", PlayerPrefs.GetString("7N"));
            PlayerPrefs.SetString("8T", PlayerPrefs.GetString("7T"));
            PlayerPrefs.SetString("7N", PlayerPrefs.GetString("6N"));
            PlayerPrefs.SetString("7T", PlayerPrefs.GetString("6T"));
            PlayerPrefs.SetString("6N", PlayerPrefs.GetString("5N"));
            PlayerPrefs.SetString("6T", PlayerPrefs.GetString("5T"));
            PlayerPrefs.SetString("5N", PlayerPrefs.GetString("4N"));
            PlayerPrefs.SetString("5T", PlayerPrefs.GetString("4T"));
            PlayerPrefs.SetString("4N", PlayerPrefs.GetString("3N"));
            PlayerPrefs.SetString("4T", PlayerPrefs.GetString("3T"));
            PlayerPrefs.SetString("3N", PlayerPrefs.GetString("2N"));
            PlayerPrefs.SetString("3T", PlayerPrefs.GetString("2T"));
            PlayerPrefs.SetString("2N", PlayerPrefs.GetString("1N"));
            PlayerPrefs.SetString("2T", PlayerPrefs.GetString("1T"));
            PlayerPrefs.SetString("1N", currentNick);
            PlayerPrefs.SetString("1T", currentTime);


        } else if (0 == currentTime.CompareTo(PlayerPrefs.GetString("1T"))) {

            Debug.LogError("Igual al mejor tiempo - Soy Segundo");

            PlayerPrefs.SetString("10N", PlayerPrefs.GetString("9N"));
            PlayerPrefs.SetString("10T", PlayerPrefs.GetString("9T"));
            PlayerPrefs.SetString("9N", PlayerPrefs.GetString("8N"));
            PlayerPrefs.SetString("9T", PlayerPrefs.GetString("8T"));
            PlayerPrefs.SetString("8N", PlayerPrefs.GetString("7N"));
            PlayerPrefs.SetString("8T", PlayerPrefs.GetString("7T"));
            PlayerPrefs.SetString("7N", PlayerPrefs.GetString("6N"));
            PlayerPrefs.SetString("7T", PlayerPrefs.GetString("6T"));
            PlayerPrefs.SetString("6N", PlayerPrefs.GetString("5N"));
            PlayerPrefs.SetString("6T", PlayerPrefs.GetString("5T"));
            PlayerPrefs.SetString("5N", PlayerPrefs.GetString("4N"));
            PlayerPrefs.SetString("5T", PlayerPrefs.GetString("4T"));
            PlayerPrefs.SetString("4N", PlayerPrefs.GetString("3N"));
            PlayerPrefs.SetString("4T", PlayerPrefs.GetString("3T"));
            PlayerPrefs.SetString("3N", PlayerPrefs.GetString("2N"));
            PlayerPrefs.SetString("3T", PlayerPrefs.GetString("2T"));
            PlayerPrefs.SetString("2N", currentNick);
            PlayerPrefs.SetString("2T", currentTime);
        } else {
            // I compare my time with the second
            if (1 == currentTime.CompareTo(PlayerPrefs.GetString("2T"))) {

                Debug.LogError("Mayor al 2 mejor tiempo - Soy Segundo");

                PlayerPrefs.SetString("10N", PlayerPrefs.GetString("9N"));
                PlayerPrefs.SetString("10T", PlayerPrefs.GetString("9T"));
                PlayerPrefs.SetString("9N", PlayerPrefs.GetString("8N"));
                PlayerPrefs.SetString("9T", PlayerPrefs.GetString("8T"));
                PlayerPrefs.SetString("8N", PlayerPrefs.GetString("7N"));
                PlayerPrefs.SetString("8T", PlayerPrefs.GetString("7T"));
                PlayerPrefs.SetString("7N", PlayerPrefs.GetString("6N"));
                PlayerPrefs.SetString("7T", PlayerPrefs.GetString("6T"));
                PlayerPrefs.SetString("6N", PlayerPrefs.GetString("5N"));
                PlayerPrefs.SetString("6T", PlayerPrefs.GetString("5T"));
                PlayerPrefs.SetString("5N", PlayerPrefs.GetString("4N"));
                PlayerPrefs.SetString("5T", PlayerPrefs.GetString("4T"));
                PlayerPrefs.SetString("4N", PlayerPrefs.GetString("3N"));
                PlayerPrefs.SetString("4T", PlayerPrefs.GetString("3T"));
                PlayerPrefs.SetString("3N", PlayerPrefs.GetString("2N"));
                PlayerPrefs.SetString("3T", PlayerPrefs.GetString("2T"));
                PlayerPrefs.SetString("2N", currentNick);
                PlayerPrefs.SetString("2T", currentTime);
            } else if (0 == currentTime.CompareTo(PlayerPrefs.GetString("2T"))) {

                Debug.LogError("Igual al 2 mejor tiempo - Soy Tercero");

                PlayerPrefs.SetString("10N", PlayerPrefs.GetString("9N"));
                PlayerPrefs.SetString("10T", PlayerPrefs.GetString("9T"));
                PlayerPrefs.SetString("9N", PlayerPrefs.GetString("8N"));
                PlayerPrefs.SetString("9T", PlayerPrefs.GetString("8T"));
                PlayerPrefs.SetString("8N", PlayerPrefs.GetString("7N"));
                PlayerPrefs.SetString("8T", PlayerPrefs.GetString("7T"));
                PlayerPrefs.SetString("7N", PlayerPrefs.GetString("6N"));
                PlayerPrefs.SetString("7T", PlayerPrefs.GetString("6T"));
                PlayerPrefs.SetString("6N", PlayerPrefs.GetString("5N"));
                PlayerPrefs.SetString("6T", PlayerPrefs.GetString("5T"));
                PlayerPrefs.SetString("5N", PlayerPrefs.GetString("4N"));
                PlayerPrefs.SetString("5T", PlayerPrefs.GetString("4T"));
                PlayerPrefs.SetString("4N", PlayerPrefs.GetString("3N"));
                PlayerPrefs.SetString("4T", PlayerPrefs.GetString("3T"));
                PlayerPrefs.SetString("3N", currentNick);
                PlayerPrefs.SetString("3T", currentTime);
            } else {
                // I compare my time with the third
                if (1 == currentTime.CompareTo(PlayerPrefs.GetString("3T"))) {

                    Debug.LogError("Mayor al 3 mejor tiempo - Soy Tercero");

                    PlayerPrefs.SetString("10N", PlayerPrefs.GetString("9N"));
                    PlayerPrefs.SetString("10T", PlayerPrefs.GetString("9T"));
                    PlayerPrefs.SetString("9N", PlayerPrefs.GetString("8N"));
                    PlayerPrefs.SetString("9T", PlayerPrefs.GetString("8T"));
                    PlayerPrefs.SetString("8N", PlayerPrefs.GetString("7N"));
                    PlayerPrefs.SetString("8T", PlayerPrefs.GetString("7T"));
                    PlayerPrefs.SetString("7N", PlayerPrefs.GetString("6N"));
                    PlayerPrefs.SetString("7T", PlayerPrefs.GetString("6T"));
                    PlayerPrefs.SetString("6N", PlayerPrefs.GetString("5N"));
                    PlayerPrefs.SetString("6T", PlayerPrefs.GetString("5T"));
                    PlayerPrefs.SetString("5N", PlayerPrefs.GetString("4N"));
                    PlayerPrefs.SetString("5T", PlayerPrefs.GetString("4T"));
                    PlayerPrefs.SetString("4N", PlayerPrefs.GetString("3N"));
                    PlayerPrefs.SetString("4T", PlayerPrefs.GetString("3T"));
                    PlayerPrefs.SetString("3N", currentNick);
                    PlayerPrefs.SetString("3T", currentTime);
                } else if (0 == currentTime.CompareTo(PlayerPrefs.GetString("3T"))) {

                    Debug.LogError("Igual al 3 mejor tiempo - Soy Cuarto");

                    PlayerPrefs.SetString("10N", PlayerPrefs.GetString("9N"));
                    PlayerPrefs.SetString("10T", PlayerPrefs.GetString("9T"));
                    PlayerPrefs.SetString("9N", PlayerPrefs.GetString("8N"));
                    PlayerPrefs.SetString("9T", PlayerPrefs.GetString("8T"));
                    PlayerPrefs.SetString("8N", PlayerPrefs.GetString("7N"));
                    PlayerPrefs.SetString("8T", PlayerPrefs.GetString("7T"));
                    PlayerPrefs.SetString("7N", PlayerPrefs.GetString("6N"));
                    PlayerPrefs.SetString("7T", PlayerPrefs.GetString("6T"));
                    PlayerPrefs.SetString("6N", PlayerPrefs.GetString("5N"));
                    PlayerPrefs.SetString("6T", PlayerPrefs.GetString("5T"));
                    PlayerPrefs.SetString("5N", PlayerPrefs.GetString("4N"));
                    PlayerPrefs.SetString("5T", PlayerPrefs.GetString("4T"));
                    PlayerPrefs.SetString("4N", currentNick);
                    PlayerPrefs.SetString("4T", currentTime);
                } else {
                    // I compare my time with the fourth
                    if (1 == currentTime.CompareTo(PlayerPrefs.GetString("4T"))) {

                        Debug.LogError("Mayor al 4 mejor tiempo - Soy Cuarto");

                        PlayerPrefs.SetString("10N", PlayerPrefs.GetString("9N"));
                        PlayerPrefs.SetString("10T", PlayerPrefs.GetString("9T"));
                        PlayerPrefs.SetString("9N", PlayerPrefs.GetString("8N"));
                        PlayerPrefs.SetString("9T", PlayerPrefs.GetString("8T"));
                        PlayerPrefs.SetString("8N", PlayerPrefs.GetString("7N"));
                        PlayerPrefs.SetString("8T", PlayerPrefs.GetString("7T"));
                        PlayerPrefs.SetString("7N", PlayerPrefs.GetString("6N"));
                        PlayerPrefs.SetString("7T", PlayerPrefs.GetString("6T"));
                        PlayerPrefs.SetString("6N", PlayerPrefs.GetString("5N"));
                        PlayerPrefs.SetString("6T", PlayerPrefs.GetString("5T"));
                        PlayerPrefs.SetString("5N", PlayerPrefs.GetString("4N"));
                        PlayerPrefs.SetString("5T", PlayerPrefs.GetString("4T"));
                        PlayerPrefs.SetString("4N", currentNick);
                        PlayerPrefs.SetString("4T", currentTime);
                    } else if (0 == currentTime.CompareTo(PlayerPrefs.GetString("4T"))) {

                        Debug.LogError("Igual al 4 mejor tiempo - Soy Quinto");

                        PlayerPrefs.SetString("10N", PlayerPrefs.GetString("9N"));
                        PlayerPrefs.SetString("10T", PlayerPrefs.GetString("9T"));
                        PlayerPrefs.SetString("9N", PlayerPrefs.GetString("8N"));
                        PlayerPrefs.SetString("9T", PlayerPrefs.GetString("8T"));
                        PlayerPrefs.SetString("8N", PlayerPrefs.GetString("7N"));
                        PlayerPrefs.SetString("8T", PlayerPrefs.GetString("7T"));
                        PlayerPrefs.SetString("7N", PlayerPrefs.GetString("6N"));
                        PlayerPrefs.SetString("7T", PlayerPrefs.GetString("6T"));
                        PlayerPrefs.SetString("6N", PlayerPrefs.GetString("5N"));
                        PlayerPrefs.SetString("6T", PlayerPrefs.GetString("5T"));
                        PlayerPrefs.SetString("5N", currentNick);
                        PlayerPrefs.SetString("5T", currentTime);
                    } else {
                        // I compare my time with the Fifth
                        if (1 == currentTime.CompareTo(PlayerPrefs.GetString("5T"))) {

                            Debug.LogError("Mayor al 5 mejor tiempo - Soy Quinto");

                            PlayerPrefs.SetString("10N", PlayerPrefs.GetString("9N"));
                            PlayerPrefs.SetString("10T", PlayerPrefs.GetString("9T"));
                            PlayerPrefs.SetString("9N", PlayerPrefs.GetString("8N"));
                            PlayerPrefs.SetString("9T", PlayerPrefs.GetString("8T"));
                            PlayerPrefs.SetString("8N", PlayerPrefs.GetString("7N"));
                            PlayerPrefs.SetString("8T", PlayerPrefs.GetString("7T"));
                            PlayerPrefs.SetString("7N", PlayerPrefs.GetString("6N"));
                            PlayerPrefs.SetString("7T", PlayerPrefs.GetString("6T"));
                            PlayerPrefs.SetString("6N", PlayerPrefs.GetString("5N"));
                            PlayerPrefs.SetString("6T", PlayerPrefs.GetString("5T"));
                            PlayerPrefs.SetString("5N", currentNick);
                            PlayerPrefs.SetString("5T", currentTime);
                        } else if (0 == currentTime.CompareTo(PlayerPrefs.GetString("5T"))) {

                            Debug.LogError("Igual al 5 mejor tiempo - Soy Sexto");

                            PlayerPrefs.SetString("10N", PlayerPrefs.GetString("9N"));
                            PlayerPrefs.SetString("10T", PlayerPrefs.GetString("9T"));
                            PlayerPrefs.SetString("9N", PlayerPrefs.GetString("8N"));
                            PlayerPrefs.SetString("9T", PlayerPrefs.GetString("8T"));
                            PlayerPrefs.SetString("8N", PlayerPrefs.GetString("7N"));
                            PlayerPrefs.SetString("8T", PlayerPrefs.GetString("7T"));
                            PlayerPrefs.SetString("7N", PlayerPrefs.GetString("6N"));
                            PlayerPrefs.SetString("7T", PlayerPrefs.GetString("6T"));
                            PlayerPrefs.SetString("6N", currentNick);
                            PlayerPrefs.SetString("6T", currentTime);
                        } else {
                            // I compare my time with the Sixth
                            if (1 == currentTime.CompareTo(PlayerPrefs.GetString("6T"))) {

                                Debug.LogError("Mayor al 6 mejor tiempo - Soy Sexto");

                                PlayerPrefs.SetString("10N", PlayerPrefs.GetString("9N"));
                                PlayerPrefs.SetString("10T", PlayerPrefs.GetString("9T"));
                                PlayerPrefs.SetString("9N", PlayerPrefs.GetString("8N"));
                                PlayerPrefs.SetString("9T", PlayerPrefs.GetString("8T"));
                                PlayerPrefs.SetString("8N", PlayerPrefs.GetString("7N"));
                                PlayerPrefs.SetString("8T", PlayerPrefs.GetString("7T"));
                                PlayerPrefs.SetString("7N", PlayerPrefs.GetString("6N"));
                                PlayerPrefs.SetString("7T", PlayerPrefs.GetString("6T"));
                                PlayerPrefs.SetString("6N", currentNick);
                                PlayerPrefs.SetString("6T", currentTime);
                            } else if (0 == currentTime.CompareTo(PlayerPrefs.GetString("6T"))) {

                                Debug.LogError("Igual al 6 mejor tiempo - Soy Septimo");

                                PlayerPrefs.SetString("10N", PlayerPrefs.GetString("9N"));
                                PlayerPrefs.SetString("10T", PlayerPrefs.GetString("9T"));
                                PlayerPrefs.SetString("9N", PlayerPrefs.GetString("8N"));
                                PlayerPrefs.SetString("9T", PlayerPrefs.GetString("8T"));
                                PlayerPrefs.SetString("8N", PlayerPrefs.GetString("7N"));
                                PlayerPrefs.SetString("8T", PlayerPrefs.GetString("7T"));
                                PlayerPrefs.SetString("7N", currentNick);
                                PlayerPrefs.SetString("7T", currentTime);
                            } else {
                                // I compare my time with the Seventh
                                if (1 == currentTime.CompareTo(PlayerPrefs.GetString("7T"))) {

                                    Debug.LogError("Mayor al 7 mejor tiempo - Soy Septimo");

                                    PlayerPrefs.SetString("10N", PlayerPrefs.GetString("9N"));
                                    PlayerPrefs.SetString("10T", PlayerPrefs.GetString("9T"));
                                    PlayerPrefs.SetString("9N", PlayerPrefs.GetString("8N"));
                                    PlayerPrefs.SetString("9T", PlayerPrefs.GetString("8T"));
                                    PlayerPrefs.SetString("8N", PlayerPrefs.GetString("7N"));
                                    PlayerPrefs.SetString("8T", PlayerPrefs.GetString("7T"));
                                    PlayerPrefs.SetString("7N", currentNick);
                                    PlayerPrefs.SetString("7T", currentTime);
                                } else if (0 == currentTime.CompareTo(PlayerPrefs.GetString("7T"))) {

                                    Debug.LogError("Igual al 7 mejor tiempo - Soy Octavo");

                                    PlayerPrefs.SetString("10N", PlayerPrefs.GetString("9N"));
                                    PlayerPrefs.SetString("10T", PlayerPrefs.GetString("9T"));
                                    PlayerPrefs.SetString("9N", PlayerPrefs.GetString("8N"));
                                    PlayerPrefs.SetString("9T", PlayerPrefs.GetString("8T"));
                                    PlayerPrefs.SetString("8N", currentNick);
                                    PlayerPrefs.SetString("8T", currentTime);
                                } else {
                                    // I compare my time with the Eighth
                                    if (1 == currentTime.CompareTo(PlayerPrefs.GetString("8T"))) {

                                        Debug.LogError("Mayor al 8 mejor tiempo - Soy Octavo");

                                        PlayerPrefs.SetString("10N", PlayerPrefs.GetString("9N"));
                                        PlayerPrefs.SetString("10T", PlayerPrefs.GetString("9T"));
                                        PlayerPrefs.SetString("9N", PlayerPrefs.GetString("8N"));
                                        PlayerPrefs.SetString("9T", PlayerPrefs.GetString("8T"));
                                        PlayerPrefs.SetString("8N", currentNick);
                                        PlayerPrefs.SetString("8T", currentTime);
                                    } else if (0 == currentTime.CompareTo(PlayerPrefs.GetString("8T"))) {

                                        Debug.LogError("Igual al 8 mejor tiempo - Soy Noveno");

                                        PlayerPrefs.SetString("10N", PlayerPrefs.GetString("9N"));
                                        PlayerPrefs.SetString("10T", PlayerPrefs.GetString("9T"));
                                        PlayerPrefs.SetString("9N", currentNick);
                                        PlayerPrefs.SetString("9T", currentTime);
                                    } else {
                                        // I compare my time with the Nineth
                                        if (1 == currentTime.CompareTo(PlayerPrefs.GetString("9T"))) {

                                            Debug.LogError("Mayor al 9 mejor tiempo - Soy Noveno");

                                            PlayerPrefs.SetString("10N", PlayerPrefs.GetString("9N"));
                                            PlayerPrefs.SetString("10T", PlayerPrefs.GetString("9T"));
                                            PlayerPrefs.SetString("9N", currentNick);
                                            PlayerPrefs.SetString("9T", currentTime);
                                        } else if (0 == currentTime.CompareTo(PlayerPrefs.GetString("9T"))) {

                                            Debug.LogError("Igual al 9 mejor tiempo - Soy Decimo");

                                            PlayerPrefs.SetString("10N", currentNick);
                                            PlayerPrefs.SetString("10T", currentTime);
                                        } else {
                                            // I compare my time with the Tenth
                                            if (1 == currentTime.CompareTo(PlayerPrefs.GetString("10T"))) {

                                                Debug.LogError("Mayor al 10 mejor tiempo - Soy Decimo");

                                                PlayerPrefs.SetString("10N", currentNick);
                                                PlayerPrefs.SetString("10T", currentTime);
                                            } else if (0 == currentTime.CompareTo(PlayerPrefs.GetString("10T"))) {
                                                Debug.LogError("Igual al 10 mejor tiempo - No guarda");
                                            } else {
                                                Debug.LogError("Menor al 10 mejor tiempo - No guarda");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        Debug.LogError("Termina");
    }
}
