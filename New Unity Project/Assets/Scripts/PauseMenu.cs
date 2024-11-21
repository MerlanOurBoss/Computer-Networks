using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    public static bool Paused = false;
    public GameObject pauseMenuUI;
    public Button pauseButton;
    public Text pbtext;

    //Пауза

    // Start is called before the first frame update
    void Start()
    {
        pauseMenuUI.SetActive(false);
        pauseButton.onClick.AddListener(Button_Click);

        pbtext.text = "PAUSE[Esc]";


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (!Paused)
            {
                Pause();              
            }
            else
            {
                Resume();
            }
        }
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
        pbtext.text = "PAUSE[Esc]";
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
        pbtext.text = "RESUME[Esc]";
    }

    void Button_Click()
    {
        if (!Paused)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }
}
