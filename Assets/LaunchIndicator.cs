using UnityEngine;
using Unity.Cinemachine;


public class ArrowIndicator : MonoBehaviour
{
    [SerializeField] private CinemachineCamera freeLookCamera;

    private void Update()
    {
        transform.forward = freeLookCamera.transform.forward;
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
    }
}
