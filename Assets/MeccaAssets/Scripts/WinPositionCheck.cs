using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPositionCheck : MonoBehaviour
{
    public Transform target;
    public Transform goal;
    public float winDistance = 2;
    public void LoadInbetweenMeccaAndAntonio( ) {
        SceneManager.LoadScene("InbetweenMeccaAndAntonio");
    }

    public bool hasWon = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (hasWon) return;
        float distance = Vector3.Distance(target.position, goal.position);

        if (distance <= winDistance)
        {
            hasWon = true;
            WinGame();
        }
    }

    void WinGame()
    {
        Debug.Log("You Won!");
        LoadInbetweenMeccaAndAntonio();
    }
}
// Note to self: attach this script to Player GameObject