using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    // Update is called once per frame
    void Update () {
        transform.position = player.transform.position + new Vector3(0, 1, -5);
        if (SceneManager.GetActiveScene().name == "Corridor")
        {
            if (player.transform.position.y <= -30.01871 )
            {
                transform.position = new Vector3(player.transform.position.x, -30.01871f + 1f, player.transform.position.z-5f);
            }
        }
    }
}
