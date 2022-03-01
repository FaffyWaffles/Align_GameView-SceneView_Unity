using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class AlignCam : MonoBehaviour
{
    public Camera gameCam;
    public bool updateView = false;
    private void LateUpdate()
    {
        if (updateView)
        {
            SceneView sceneCam = SceneView.lastActiveSceneView;
            gameCam.transform.position = sceneCam.camera.transform.position;
            gameCam.transform.rotation = sceneCam.camera.transform.rotation;
        }
    }
}
