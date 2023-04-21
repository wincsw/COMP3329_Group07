using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider slider;


    public static float fillSpeed = 0.005f;
    private float targetProgress = 0;

    public static float value = 0;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        slider.value = ProgressBar.value;
    }

    // Start is called before the first frame update
    void Start()
    {
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
        ProgressBar.fillSpeed = 0.01f;
        FindObjectOfType<GameManager>().hasPeed = false;
    }
}