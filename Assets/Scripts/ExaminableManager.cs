using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExaminableManager : MonoBehaviour
{
    [SerializeField] private Transform _examineTarget;

    private Vector3 _cachedPosition;
    private Vector3 _cachedScale;
    private Quaternion _cachedRotation;

    private Examinable _currentExaminedObject;

    private bool _isExamining;

    [SerializeField] private float _rotationSpeed = 1f;
    [SerializeField] private GameObject _particleEffect;

    private void Update()
    {
        if (_isExamining == true)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Moved)
                {
                    _currentExaminedObject.transform.Rotate(touch.deltaPosition.x * _rotationSpeed, touch.deltaPosition.y * _rotationSpeed, 0);
                }
            }
        }
    }
    public void PerformExamine(Examinable examinable)
    {
        _particleEffect.SetActive(true);
        _currentExaminedObject = examinable;

        //Cache the examinable transform data so we can reset it
        _cachedPosition = _currentExaminedObject.transform.position;
        _cachedRotation = _currentExaminedObject.transform.rotation;
        _cachedScale = _currentExaminedObject.transform.localScale;

        //Move the examinable to the target position
        _currentExaminedObject.transform.position = _examineTarget.position;
        _currentExaminedObject.transform.parent = _examineTarget;

        //Offset the scale to fit the examinable in view
        Vector3 offsetScale = _cachedScale * examinable.examineScaleOffset;
        _currentExaminedObject.transform.localScale = offsetScale;

        _isExamining = true;
    }

    public void PerformUnexamine()
    {
        _particleEffect.SetActive(false);

        _currentExaminedObject.transform.position = _cachedPosition;
        _currentExaminedObject.transform.rotation = _cachedRotation;
        _currentExaminedObject.transform.localScale = _cachedScale;

        _currentExaminedObject.transform.parent = null;
        _currentExaminedObject = null;

        _isExamining = false;
    }

    
}
