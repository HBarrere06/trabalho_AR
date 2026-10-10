
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class QRCanvasVisibility : MonoBehaviour
{
    [SerializeField]
    private ARTrackedImageManager trackedImageManager;

    [SerializeField]
    private GameObject canvasAR;

    private void OnEnable()
    {
        trackedImageManager.trackablesChanged
            .AddListener(OnTrackablesChanged);
    }

    private void OnDisable()
    {
        trackedImageManager.trackablesChanged
            .RemoveListener(OnTrackablesChanged);
    }

    private void OnTrackablesChanged(
        ARTrackablesChangedEventArgs<ARTrackedImage> args)
    {
        foreach (var image in args.added)
            AtualizarCanvas(image);

        foreach (var image in args.updated)
            AtualizarCanvas(image);

        foreach (var image in args.removed)
            canvasAR.SetActive(false);
    }

    private void AtualizarCanvas(ARTrackedImage image)
    {
        bool detectado =
            image.trackingState == TrackingState.Tracking;

        canvasAR.SetActive(detectado);

        if (detectado)
        {
            canvasAR.transform.SetPositionAndRotation(
                image.transform.position,
                image.transform.rotation
            );
        }
    }
}
