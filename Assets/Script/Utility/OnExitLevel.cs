using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnExitLevel : MonoBehaviour
{
    public string sceneName;
    public bool isNextScene = true;
    public bool lockRoom = false;
    public string objNeed;
    public Dialogue dialogue;
    [SerializeField]
    public SceneInfo sceneInfo;
    public int chance;

    public void EnterScene()
    {
        sceneInfo.isNextScene = isNextScene;
        if (SceneManager.GetActiveScene().name == "Corridor")
        {
            sceneInfo.lastPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
            switch (objNeed)
            {
                case "Soap":
                    if (InventoryItem_Soap.collected)
                    {
                        lockRoom = true;
                    }
                    break;
                case "ToiletPaper":
                    if (InventoryItem_ToiletPaper.collected)
                    {
                        lockRoom = true;
                    }
                    break;
                case "Key":
                    if (InventoryItem_Key.collected)
                    {
                        lockRoom = true;
                    }
                    break;
                case "Plunger":
                    if (InventoryItem_Plunger.collected)
                    {
                        lockRoom = true;
                    }
                    break;

            }
        }
        else if (SceneManager.GetActiveScene().name == "DreamChamber")
        {
            lockRoom = false;
        }
        else if (SceneManager.GetActiveScene().name == "Entrance")
        {

            if (InventoryItem_Key.collected)
            {
                lockRoom = true;
            }
            else
            {
                chance = Random.Range(0,10);
                if (chance <= 8)
                {
                    Debug.Log(chance + "Security Room");
                    sceneInfo.lastScene = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene("SecurityRoom");
                    return;
                }
                else
                {
                    Debug.Log(chance + "Security Guard");
                    FindObjectOfType<GameManager>().EndCaught();
                    return;
                }

            }
        

        }

        if (lockRoom == true)
        {
            Debug.Log("Already collected item from " + sceneName);
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        else
        {
            Debug.Log("Entering " + sceneName);
            sceneInfo.lastScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(sceneName);

        }
    }
}
