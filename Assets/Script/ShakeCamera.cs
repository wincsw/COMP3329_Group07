using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCamera : MonoBehaviour
{
    
    public GameObject kickAudio;
    public Interactable interactable;
    public BoxTrigger boxTrigger;

    void Update()
    {
        if (boxTrigger.shakeTimes <= 3) 
        {
            if (!kickAudio.GetComponent<AudioTrigger>().GetComponent<AudioSource>().isPlaying)
            interactable.inCoolDown = false;
        }
        
    }

    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector2 originalPos = transform.localPosition;
        float elapsed = 0.0f;
        kickAudio.GetComponent<AudioTrigger>().TriggerAudio();
        while (elapsed < duration)
        {
            float x = Random.Range(-1f,1f) * magnitude;
            float y = Random.Range(-1f,1f) * magnitude;

            transform.localPosition = new Vector2(x, y);
            elapsed += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = originalPos;
    }
}
