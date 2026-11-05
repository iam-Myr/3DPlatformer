using UnityEngine;

public class ResetTrigger : MonoBehaviour
{
    [SerializeField] private Transform PointStart;
    [SerializeField] private Transform Player;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player fell!");

        Player.position = PointStart.position;
    }
}
