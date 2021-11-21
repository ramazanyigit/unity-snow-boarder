using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float restartDelay = 1f;
    [SerializeField] ParticleSystem finishEffect;
    [SerializeField] AudioClip finishSFX;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            finishEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(finishSFX);
            Invoke("RestartLevel", restartDelay);
        }
    }

    private void RestartLevel() {
        SceneManager.LoadScene(0);
    }
}
