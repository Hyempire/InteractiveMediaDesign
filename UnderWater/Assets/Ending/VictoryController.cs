using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<CanvasGroup>().alpha = 0;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<Canvas>().isActiveAndEnabled)
        {
            if (gameObject.GetComponent<CanvasGroup>().alpha < 100)
            {
                gameObject.GetComponent<CanvasGroup>().alpha += Time.deltaTime;
            }
        }
    }
}
