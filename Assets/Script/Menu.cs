using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    public Button upButton;
    public Button downButton;

    public GameObject arrows;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!GameIsPaused)
            {
                Pause();
            }
        }
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            arrows.transform.position = new Vector3Int(0, 0, 0);
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            arrows.transform.position = new Vector3Int(0, -1, 0);
        }
    }


    public void Resume()
    {
        Debug.Log("Resume");
        pauseMenuUI.SetActive(false);
        if (!FindObjectOfType<DialogueManager>().isActive)
        {
            FindObjectOfType<PlayerMovement>().enabled = true;
        }
        FindObjectOfType<DialogueManager>().enabled = true;
        Time.timeScale = 1;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        FindObjectOfType<PlayerMovement>().enabled = false;
        FindObjectOfType<DialogueManager>().enabled = false;
        Time.timeScale = 0;
        GameIsPaused = true;

    }
}
