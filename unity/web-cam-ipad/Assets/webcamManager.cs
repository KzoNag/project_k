using UnityEngine;
using System.Collections;

public class webcamManager : MonoBehaviour {

	[SerializeField]
	private webcam   webcamPrefab = null;
	private webcam[] webcams = null;

	// Use this for initialization
	void Start () {
	
		if(webcamPrefab == null){ return; }

		WebCamDevice[] devices = WebCamTexture.devices;

		if(devices != null && devices.Length > 0)
		{
			webcams = new webcam[devices.Length];
			for(int i=1; i< devices.Length; ++i)
			{
				webcams[i] = Instantiate( webcamPrefab ) as webcam;
				webcams[i].DevCamIdx = i;
				webcams[i].Alpha = 0.5f;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
