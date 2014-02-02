//********************************************************************
//	FPS
//	@author: k_nagamine
//********************************************************************

using System.Collections;

namespace KzD
{
	public class FPS
	{
		private System.Func<float> DeltaTime = null;

		public FPS( System.Func<float> _deltaTime )
		{
			DeltaTime = _deltaTime;
		}

		public float Fps{ get { return ( DeltaTime != null ) ? 1f / DeltaTime() : 0f; } }
	}
}
