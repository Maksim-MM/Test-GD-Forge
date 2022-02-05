using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;


public class ClickListenerBtn : MonoBehaviour
{
    [SerializeField]
    public GameObject particles;
    public Button btnClick;

    // Start is called before the first frame update
    void Start()
    {
        //particles.SetActive(false);
        btnClick.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //particles.SetActive(true)
        Debug.Log("Yooooo");
    }
    // Update is called once per frame

    void Update()
    {
        
    }
}
