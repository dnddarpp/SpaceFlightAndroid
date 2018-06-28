using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceFlight.Lobby
{
	public class BaseView :　MonoBehaviour
	{
		public Lobby.PageEnum PageFlag;
		[SerializeField]
		private Canvas m_Canvas = null;
		
		public virtual void Show()
		{
			m_Canvas.enabled = true;
		}
		public virtual void Hide()
		{
			m_Canvas.enabled = false;
		}
	}
}