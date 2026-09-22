using UnityEngine;

public class WinPositionCheck : MonoBehaviour
{
    public Transform target;
    public Transform goal;
    public float winDistance = 2;

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
    }
}
// Note to self: attach this script to Player GameObject