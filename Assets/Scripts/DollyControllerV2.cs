using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class DollyControllerV2 : MonoBehaviour
{
    [SerializeField] private CinemachineDollyCart dollyCart;
    [SerializeField] private CinemachineVirtualCamera virtualCamera;
    [SerializeField] private CinemachineSmoothPath dollyPath;
    [SerializeField] private float blendDuration = 1f;
    [SerializeField] private Button button;
    [SerializeField] private GameObject[] objectsToShow;

    private CinemachineBrain cinemachineBrain;
    private bool isPlaying = false;

    private void Start()
    {
        cinemachineBrain = Camera.main.GetComponent<CinemachineBrain>();
        button.onClick.AddListener(ButtonOnClick);
        SetObjectsActive(false);
        dollyCart.gameObject.SetActive(false);
    }

    private void SetObjectsActive(bool isActive)
    {
        foreach (GameObject obj in objectsToShow)
        {
            obj.SetActive(isActive);
        }
    }

    private void ButtonOnClick()
    {
        isPlaying = true;
        StartCoroutine(PlayDollyPath());
    }

    private IEnumerator PlayDollyPath()
    {
        dollyCart.gameObject.SetActive(true);
        virtualCamera.transform.position = dollyCart.m_Path.EvaluatePosition(0);
        virtualCamera.Follow = dollyCart.transform;

        float dollyPos = dollyCart.m_Position;
        float pathLength = dollyPath.PathLength;
        float currentTime = Time.time;

        while (isPlaying)
        {
            float t = (Time.time - currentTime) / blendDuration;
            t = Mathf.Clamp01(t);

            cinemachineBrain.m_DefaultBlend.m_Time = blendDuration;

            if (!dollyCart.m_Path.Looped && dollyCart.m_Position >= pathLength)
            {
                isPlaying = false;
                SetObjectsActive(true);
            }

            dollyPos = Mathf.Clamp(dollyPos + (Time.deltaTime * dollyCart.m_Speed), 0, pathLength);
            dollyCart.m_Position = dollyPos;

            yield return null;
        }
    }
}
