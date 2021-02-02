using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInstantiate : MonoBehaviour
{
    public GameObject characterPrefab;
    public GameObject UICanvasCamera;
    public GameObject playerInstantiate;
    // Start is called before the first frame update
     void Awake()
    {

        
    }
    void Start()
    {
        Instantiate();
    }
    public void Instantiate()
    {
        playerInstantiate = Instantiate(characterPrefab, new Vector3(0, 0, 0), Quaternion.identity);

        for (int i = 0; i < characterPrefab.transform.childCount; i++)
        {
            UICanvasCamera.GetComponent<Canvas>().worldCamera = playerInstantiate.transform.GetChild(i).gameObject.GetComponent<Camera>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
