using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
public class BoxWinTrigger : MonoBehaviour
{
    public string playerTag = "Player";
    private bool hasWon = false;

    private void OnTriggerEnter(Collider other)
    {
        if (hasWon) return;

        if (other.CompareTag(playerTag))
        {
            hasWon = true;
            Debug.Log("You Win!");
        }
    }
}