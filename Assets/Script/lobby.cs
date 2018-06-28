using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceFlight.Lobby
{

	public class Lobby : MonoBehaviour
	{
		[SerializeField]
		private MainView m_MainView =null;
		public MainView ThisMainView{get{return m_MainView;}}

		public enum PageEnum
		{
			Home,
			GemStore,
			CharacterMode,
			Setting,
			Achievement,
			Game,
			GameOver,

		}

		public void SwitchView(PageEnum page)
		{
			switch(page)
			{
				case PageEnum.Home:
				
				
				break;

			}

		}
	}

}