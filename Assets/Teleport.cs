using System;
using Chiligames.MetaAvatarsPun;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

public class TeleportPlayer1 : MonoBehaviour
{
    [Tooltip("The name of the scene to teleport the player to.")]
    public string sceneName;

    private Vector3 respawnPoint;
    void Start()
    {
        respawnPoint = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
            //respawnPoint = transform.position;
            SceneManager.LoadScene(sceneName);
        }
    }
}