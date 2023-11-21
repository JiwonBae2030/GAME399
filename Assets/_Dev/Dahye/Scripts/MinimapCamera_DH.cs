using UnityEngine;

public class MinimapCamera_DH : MonoBehaviour
{
    [SerializeField] private Transform Player;

    void Update()
    {
        Vector3 desPos = Player.transform.position;
        desPos.y = this.transform.position.y;

        this.transform.position = desPos;
    }
}
