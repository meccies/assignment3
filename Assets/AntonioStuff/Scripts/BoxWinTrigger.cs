using UnityEngine;
using UnityEngine.SceneManagement; 

public class BoxWinTrigger : MonoBehaviour
{
    public string playerTag = "Player";

    
    public string winSceneName = "WinScreen";

    private bool hasWon = false;

    private void OnTriggerEnter(Collider other)
    {
        if (hasWon) return;

        if (other.CompareTag(playerTag))
        {
            hasWon = true;
            Debug.Log("You Win!");

            
            SceneManager.LoadScene(winSceneName);
        }
    }
}