using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OffsetChanger : MonoBehaviour
{
    public XROrigin xrOrigin;
    private bool _isOffsetEnabled;

    public bool IsOffsetEnabled
    {
        get { return _isOffsetEnabled; }
        set
        {
            if (_isOffsetEnabled != value) 
            {
                _isOffsetEnabled = value;
                UpdateCameraOffset();
            }
        }
    }

    void UpdateCameraOffset()
    {
        if (xrOrigin != null)
        {
            xrOrigin.CameraYOffset = _isOffsetEnabled ? 1f : 0f; 
        }
    }
}
