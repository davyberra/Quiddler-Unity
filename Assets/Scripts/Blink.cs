using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkingButton : MonoBehaviour
{
    Image image;
    Button button;

    void Start()
    {
        image = GetComponent<Image>();
        button = GetComponent<Button>();
        StartBlinking();
    }

    void Blink()
    {
        return;
    }

    void StartBlinking()
    {
        StopAllCoroutines();
        StartCoroutine("Blink");
    }

    void StopBlinking()
    {
        StopAllCoroutines();
    }
}
