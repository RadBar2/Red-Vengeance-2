using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public GameObject player1End;
    public GameObject player2End;

    public float restartOffset = 8;

    public void Player1Death()
    {
        player1End.SetActive(true);
        player1End.GetComponent<AudioSource>()?.Play();

        Invoke(nameof(Restart), restartOffset);
    }

    public void Player2Death()
    {
        player2End.SetActive(true);
        player2End.GetComponent<AudioSource>()?.Play();

        Invoke(nameof(Restart), restartOffset);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
