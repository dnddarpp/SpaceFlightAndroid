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
		private BaseView mCurrentView = null;
		[SerializeField]
		private GemStoreView m_GemStoreView = null;
		[SerializeField]
		private CharacterMode m_CharacterModeView = null;
		[SerializeField]
		private Achievement m_AchievementView = null;
		[SerializeField]
		private Game m_GameView = null;
		[SerializeField]
		private GameOver m_GameOverView = null;

		public enum PageEnum
		{
			//Home,
			GemStore,
			CharacterMode,
			Setting,
			Achievement,
			Game,
			GameOver,
			None,

		}
		 void Awake() 
		{
			m_MainView.OnSwitchPage+= (a) => { SwitchView(a); };
		}
		public void SwitchView(PageEnum page, PageEnum bachPage = PageEnum.None, params object [] obs )
		{
			if(null != mCurrentView && mCurrentView.PageFlag == page)
				return;
			
			if(null != mCurrentView)
				mCurrentView.Hide();
			
			switch(page)
			{
			/*	case PageEnum.Home:
				m_MainView.Show();
				break;	*/

				case PageEnum.GemStore:
				m_GemStoreView.Show();
				break;

				case PageEnum.CharacterMode:
				m_CharacterModeView.Show();
				break;
				
				case PageEnum.Achievement:
				m_AchievementView.Show();
				break;
				
				case PageEnum.Game:
				m_GameView.Show();
				break;

				case PageEnum.GameOver:
				
				break;
			}
			
		}
	}

}