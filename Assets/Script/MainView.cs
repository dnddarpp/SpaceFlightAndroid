using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


namespace SpaceFlight.Lobby
{
	public class MainView : BaseView
	{
		public Action <Lobby.PageEnum> OnSwitchPage;
		public void StartGame() //遊戲開始
		{
			OnSwitchPage(Lobby.PageEnum.Game);
		}	
		public void GoGemStore() //寶石買賣
		{
			OnSwitchPage(Lobby.PageEnum.GemStore);
		}
		public void GoCharacterMode() //角色模式
		{
			OnSwitchPage(Lobby.PageEnum.CharacterMode);
		}	
	
		public void GoMission() //成就
		{
			OnSwitchPage(Lobby.PageEnum.Achievement);
		}

		public void GoSetting() //設定
		{
			OnSwitchPage(Lobby.PageEnum.Setting);
		}
		public void GoEvaluate() //評分
		{
			//熊熊想到這個評分要連到上架商店的網址，啊我還沒上架怎麼連
		}
		public void GoShare()
		{
			//套個套件
		}
		public void GoRank()
		{
			
		}
	
	}
}

