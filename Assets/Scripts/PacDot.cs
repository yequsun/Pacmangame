using UnityEngine;
using System.Collections;

public class PacDot : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "Pacman")
        {
            if (GameController.GC.dotsNumber == 1) {
                Application.LoadLevel(Application.loadedLevel);
            }
            Destroy(gameObject);
			GameController.GC.score += 1;
			GameController.GC.dotsNumber -= 1;
        }
    }
}
