using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour {

    public Transform player;
    public hotdogpoints score;

    private void OnMouseDown()
    {

        if( Vector3.Distance(transform.position, player.position ) < 4 && score.score >= 500)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
