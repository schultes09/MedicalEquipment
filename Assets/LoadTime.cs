using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTime : MonoBehaviour
{
    [SerializeField] private float delayedBeforeLoading = 10f;

   // [SerializeField] private string sceneNameToLoad;

    private float timeElapsed;

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delayedBeforeLoading)
        {
            SceneManager.LoadScene("Medical Equipments");
        }
    }
}
