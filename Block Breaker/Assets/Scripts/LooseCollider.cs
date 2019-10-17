using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LooseCollider : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D myCollider)
    {
        print("GameOver");
        print(myCollider.gameObject.name);

        SceneManager.LoadScene("GameOver");
    }
}
