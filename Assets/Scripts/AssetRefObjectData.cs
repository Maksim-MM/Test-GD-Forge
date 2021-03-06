using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class AssetRefObjectData : MonoBehaviour
{
    [SerializeField] private AssetReference _fxAref;
    [SerializeField] private List<AssetReference> _references = new List<AssetReference>();

    [SerializeField] private List<GameObject> _conpletedObj = new List<GameObject>();
    private void Start()
    {
        _references.Add(_fxAref);

        StartCoroutine(LoadAndWaitUntilComplete());
    }

    private IEnumerator LoadAndWaitUntilComplete()
    {
        yield return AssetRefLoader.CreateAssetsAddToList(_references, _conpletedObj);
    }

}
