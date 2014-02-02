using UnityEngine;
using System.Collections;

public class webcam : MonoBehaviour {

	[SerializeField]
	private MeshRenderer meshRenderer = null;

	private WebCamTexture webCamTex = null;
	private Vector2 texSize = new Vector2(360, 480);

	public int DevCamIdx{ get; set; }
	public float Alpha{ get; set; }

	// Use this for initialization
	void Start () 
	{
		DevCamIdx = 1;

		WebCamDevice[] devices = WebCamTexture.devices; 
		if( devices != null && devices.Length > DevCamIdx)
		{
			Debug.Log ("device name => " + devices[DevCamIdx].name);
			webCamTex = new WebCamTexture( devices[DevCamIdx].name, (int)texSize.x, (int)texSize.y, 10 );
			meshRenderer.material.mainTexture = webCamTex;
			meshRenderer.material.color = new Color( 1,1,1,Alpha );
			webCamTex.Play();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
