using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private Transform[] positions;
    [SerializeField] private Transform player;

    public void Teleport(int num)
    {
        player.transform.position = positions[num].position;
        Debug.Log(num);
    }

}
