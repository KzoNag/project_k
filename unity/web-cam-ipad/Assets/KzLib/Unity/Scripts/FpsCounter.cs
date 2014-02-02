using UnityEngine;
using System.Collections;

public class FpsCounter : MonoBehaviour {

	private KzD.FPS m_fps = new KzD.FPS( () => { return Time.deltaTime; } );

	private int m_time_tmp = 0;
	private float m_fps_val = 0;

	// Use this for initialization
	void Start () 
	{
		Debug.Log ("FPS Setting => " + Application.targetFrameRate.ToString());
	}
	
	// Update is called once per frame
	void Update () 
	{
		int int_time = (int)Time.time;
		if( int_time != m_time_tmp )
		{
			m_time_tmp = int_time;
			m_fps_val = m_fps.Fps;
		}
	}

	void OnGUI()
	{
		GUI.Box( new Rect( 20, 20, 320, 160 ), "FPS : " + m_fps_val.ToString() );
	}
}
