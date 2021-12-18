using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARTrackedImageManager))]
public class ImageTrack : MonoBehaviour
{

    [SerializeField]
    private GameObject[] placeablePrefabs;

    private Dictionary<string, GameObject> spawnedPrefabs = new Dictionary<string, GameObject>();
    private ARTrackedImageManager trackedImageManager;

    private void Awake()
    {
        trackedImageManager = FindObjectOfType<ARTrackedImageManager>();

        foreach (GameObject prefab in placeablePrefabs)
        {
            GameObject newPrefab = Instantiate(prefab, Vector3.zero, Quaternion.identity);
            newPrefab.name = prefab.name;
            spawnedPrefabs.Add(prefab.name, newPrefab);
        }
    }

    private void OnEnable()
    {
        trackedImageManager.trackedImagesChanged += ImageChanged;
    }

    private void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= ImageChanged;
    }

    private void ImageChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (ARTrackedImage trackedImage in eventArgs.added)
        {
            GameObject parent = trackedImage.transform.GetChild(0).gameObject;
            if(trackedImage.trackingState != TrackingState.None)
            {
                parent.SetActive(true);

                switch (trackedImage.referenceImage.name)
                {
                    case "AND":
                        parent.transform.GetChild(0).gameObject.SetActive(true);
                        break;
                    case "OR":
                        parent.transform.GetChild(1).gameObject.SetActive(true);
                        break;
                    case "NAND":
                        parent.transform.GetChild(2).gameObject.SetActive(true);
                        break;
                    case "NOR":
                        parent.transform.GetChild(3).gameObject.SetActive(true);
                        break;
                    case "XOR":
                        parent.transform.GetChild(4).gameObject.SetActive(true);
                        break;
                    case "XNOR":
                        parent.transform.GetChild(5).gameObject.SetActive(true);
                        break;
                    case "NAND4":
                        parent.transform.GetChild(6).gameObject.SetActive(true);
                        break;
                    case "AND4":
                        parent.transform.GetChild(7).gameObject.SetActive(true);
                        break;
                    case "ASOSIATIF_A":
                        parent.transform.GetChild(8).gameObject.SetActive(true);
                        break;
                    case "ASOSIATIF_B":
                        parent.transform.GetChild(9).gameObject.SetActive(true);
                        break;
                    case "IDEMPOTEN_A":
                        parent.transform.GetChild(10).gameObject.SetActive(true);
                        break;
                    case "IDEMPOTEN_B":
                        parent.transform.GetChild(11).gameObject.SetActive(true);
                        break;
                }
            }
            else
            {
                parent.SetActive(false);
            }
        }

        foreach (ARTrackedImage trackedImage in eventArgs.updated)
        {
            UpdateImage(trackedImage);
        }

        foreach (ARTrackedImage trackedImage in eventArgs.removed)
        {
            spawnedPrefabs[trackedImage.name].SetActive(false);
        }

    }

    private void UpdateImage(ARTrackedImage trackedImage)
    {
        string name = trackedImage.referenceImage.name;
        Vector3 position = trackedImage.transform.position;

        GameObject prefab = spawnedPrefabs[name];
        prefab.transform.position = position;
        prefab.SetActive(true);

        foreach (GameObject go in spawnedPrefabs.Values)
        {
            if (go.name != name)
            {
                go.SetActive(false);
            }
        }
    }

}
