using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public List<Vector3> positions;
    public List<Vector3> rotace;
    public List<float> minDistances; 

    Transform _XForm_Camera;
    Transform _XForm_Parent;
    Vector3 _LocalRotation;
    public Transform _Point;
    float minDistance;

    public float MouseSensitivity = 4f;
    public float ScrollSensitivity = 2f;
    public float OrbitSpeed = 10f;
    public float ScrollSpeed = 6f;

    public bool CameraDisabled = false;

    void Start()
    {
        _XForm_Camera = transform;
        _XForm_Parent = transform.parent;
        AnimateCam(5);
    }
    void LateUpdate()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
            {
                _LocalRotation.x += Input.GetAxis("Mouse X") * MouseSensitivity;
                _LocalRotation.y += Input.GetAxis("Mouse Y") * MouseSensitivity * -1;

                _LocalRotation.y = Mathf.Clamp(_LocalRotation.y, -90f, 90f);
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") != 0f)
        {
            float scrollAmount = Input.GetAxis("Mouse ScrollWheel") * ScrollSensitivity;

            scrollAmount *= Vector3.Distance(_XForm_Parent.position, _Point.position) * -0.3f;

            _Point.localPosition = new Vector3(_Point.localPosition.x, _Point.localPosition.y, Mathf.Clamp(_Point.localPosition.z * -1 + scrollAmount, minDistance, 100f) * -1);
        }
        Quaternion QT = Quaternion.Euler(_LocalRotation.y, _LocalRotation.x, 0);

        _XForm_Parent.rotation = Quaternion.Lerp(_XForm_Parent.rotation, QT, Time.deltaTime * OrbitSpeed);

        if (_XForm_Camera.localPosition.z != _Point.localPosition.z)
        {
            if (_Point.position.y <= 0f)
            {
                _Point.localPosition = Vector3.Lerp(_Point.localPosition, Vector3.zero, 0.05f);
            }
            //_XForm_Camera.localPosition = new Vector3(0f, 0f, Mathf.Lerp(_XForm_Camera.localPosition.z, _Point * -1f, Time.deltaTime * ScrollSpeed));
            _XForm_Camera.localPosition = Vector3.Lerp(_XForm_Camera.localPosition, _Point.localPosition, Time.deltaTime * ScrollSpeed);
        }
    }
    public void AnimateCam(int index)
    {
        _XForm_Parent.position = positions[index];
        minDistance = minDistances[index];
        _LocalRotation = rotace[index];
        _Point.localPosition = new Vector3(_Point.localPosition.x, _Point.localPosition.y, minDistance * -1);
    }
}
