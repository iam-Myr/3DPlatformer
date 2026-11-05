using UnityEngine;

/// <summary>
/// Turns into Goal
/// </summary>
public class TestTrigger : MonoBehaviour
{
    [SerializeField] private Transform PointStart;
    [SerializeField] private Transform Player;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered by: " + other.name);
        Debug.Log("You win!!!");

        Player.position = PointStart.position;
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger exited by: " + other.name);
    }
}
