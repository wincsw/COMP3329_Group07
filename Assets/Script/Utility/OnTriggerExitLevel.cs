using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerExitLevel : MonoBehaviour
{
    public string sceneName;
    public bool isNextScene = true;
    [SerializeField]
    public SceneInfo sceneInfo;
    public bool lockRoom = false;
    public bool needToiletPaper;
    public Dialogue dialogue;
    public PrinterVar printerVar;

    public void OnTriggerEnter2D(Collider2D player)
    {
        sceneInfo.isNextScene = isNextScene;
        if (SceneManager.GetActiveScene().name == "Corridor")
        {
            if (needToiletPaper && InventoryItem_ToiletPaper.collected)
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                return;
            }
            sceneInfo.lastPosition.x = GameObject.FindGameObjectWithTag("Player").transform.position.x;
            sceneInfo.lastPosition.y = GameObject.FindGameObjectWithTag("Player").transform.position.y;
        }
        if (SceneManager.GetActiveScene().name == "3DPrinterArea")
        {
            printerVar.ResetPrint();
        }
        if (SceneManager.GetActiveScene().name == "Entrance")
        {
            sceneInfo.lastPosition.y = -30.01865f - (-0.5668268f - GameObject.FindGameObjectWithTag("Player").transform.position.y)/3.1004322f*6.47636f;
        }
        
        Debug.Log("Entering " + sceneName);
        sceneInfo.lastScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }
}