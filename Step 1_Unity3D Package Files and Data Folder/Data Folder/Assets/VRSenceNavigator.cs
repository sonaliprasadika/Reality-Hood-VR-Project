using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class VRSceneNavigator : MonoBehaviour
{
    private void OnEnable()
    {
        GetComponent<XRGrabInteractable>().onSelectEntered.AddListener(PlayGame);
        GetComponent<XRGrabInteractable>().onSelectExited.AddListener(Back);
    }

    private void OnDisable()
    {
        GetComponent<XRGrabInteractable>().onSelectEntered.RemoveListener(PlayGame);
        GetComponent<XRGrabInteractable>().onSelectExited.RemoveListener(Back);
    }

    private void PlayGame(XRBaseInteractor interactor)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void Back(XRBaseInteractor interactor)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}