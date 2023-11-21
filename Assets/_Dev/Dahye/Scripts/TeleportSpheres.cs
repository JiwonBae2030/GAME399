using UnityEngine;

public class TeleportSpheres : MonoBehaviour
{
    public enum SceneSphereType
    {
        TechnoPark,
        Incheon,
        WonInJae,
    }



    [SerializeField]
    private GameObject[] Scenes;




    private GameObject camera;
    private Vector3 cameraPos;
    private float moveSpeed = 5f;
    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("Main Camera");
        if (camera == null)
        {
            Debug.LogError("Main Camera tag is not found in the scene.");
        }
    }

    void Update()
    {
        Forward();
    }

    void Forward()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Make sure the camera is assigned before trying to use it
            if (camera != null)
            {
                // Move the camera forward by modifying its position
                cameraPos = camera.transform.position;
                cameraPos += camera.transform.forward * moveSpeed * Time.deltaTime; // Move forward relative to the camera's orientation
                camera.transform.position = cameraPos;
            }
        }
    }
}
