using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateNextSceneSecRoom : MonoBehaviour
{
    public GameObject EndingCanvas;
    public GameObject EndingControl;
    public GameObject EndingDialogueManager;
    public GameObject bg;
    // Start is called before the first frame update
    void Start()
    {
        EndingCanvas.SetActive(true);
        EndingControl.SetActive(true);
        EndingDialogueManager.SetActive(true);
        bg.SetActive(true);
    }

}
