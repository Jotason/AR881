using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARInteractionManager : MonoBehaviour
{
    [SerializeField] private Camera _ARcamera;
    private ARRaycastManager _arRaycastManager;
    private List<ARRaycastHit> _hits = new List<ARRaycastHit>();

    private GameObject _arPointer;
    private GameObject _item3Dmodel;

    private bool _isInitialPosition;

    public GameObject _Item3DModel
    {
        set
        {
            GameManager.instance.DebugConsoleMessage("Se asigna el modelo 3D");
            _item3Dmodel = value;
            _item3Dmodel.transform.position = _arPointer.transform.position;
            //_item3Dmodel.transform.rotation = _arPointer.transform.rotation;    
            _isInitialPosition = true;
        }
        get { return _item3Dmodel; }
    }
    void Start()
    {
        _arPointer = transform.GetChild(0).gameObject;
        _arRaycastManager = GameObject.FindObjectOfType<ARRaycastManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_isInitialPosition)
        {
            Vector2 _middlePointScreen = new Vector2(Screen.width / 2, Screen.height/2);
            _arRaycastManager.Raycast(_middlePointScreen, _hits, TrackableType.Planes);

            if (_hits.Count > 0) {
                transform.position = _hits[0].pose.position;
                transform.rotation = _hits[0].pose.rotation;
                _arPointer.SetActive(true);
                //_isInitialPosition = false;
            }
        }
    }

    public void SetItemPosition() {
        if (_Item3DModel != null)
        {
            _item3Dmodel.transform.parent = null; 
            _arPointer.SetActive(false);
            _item3Dmodel = null; 
        }
    }


    
}
