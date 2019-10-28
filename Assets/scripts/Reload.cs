using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
    public Camera mycam;
    public static float camheight;

    // Start is called before the first frame update
    void Start()
    {
        mycam = this.GetComponent<Camera>();
        camheight = 5f;
        Pathmaker.floorlist = new List<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            Debug.Log("reload");
            Pathmaker.globalFloorCount = 0;
        }

        mycam.transform.position = new Vector3(Pathmaker.camPos.x, camheight, Pathmaker.camPos.z);
    }
}
