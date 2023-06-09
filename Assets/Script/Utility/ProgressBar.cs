using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgressBar : MonoBehaviour
{
    public Slider slider;

    public const float MINUTES = 3.5f;
    public const float SPEED = 1f / (MINUTES * 60);

    public static float fillSpeed = SPEED;
    private float targetProgress = 0;

    public static float value = 0;
    public SceneInfo sceneInfo;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        slider.value = ProgressBar.value;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "DreamChamber" && sceneInfo.lastScene == "Start")
        {
            Debug.Log("Restarted game and in progress bar");
            ResetValue();
        }
        IncrementProgress(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < targetProgress)
        {
            // slider.value += fillSpeed * Time.deltaTime;
            ProgressBar.value += fillSpeed * Time.deltaTime;
            slider.value = ProgressBar.value;
        }
        if (slider.value == 1)
        {
            ResetValue();
            FindObjectOfType<GameManager>().EndPeed();
        }
    }

    public void IncrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;

    }

    public void ClearValue()
    {
        ProgressBar.value = 0;
        slider.value = 0;
        ProgressBar.fillSpeed = 0;
        FindObjectOfType<GameManager>().hasPeed = true;
    }

    public void ResetValue()
    {
        ProgressBar.value = 0;
        slider.value = 0;
        ProgressBar.fillSpeed = SPEED;
        FindObjectOfType<GameManager>().hasPeed = false;
        Time.timeScale = 1;
    }
}