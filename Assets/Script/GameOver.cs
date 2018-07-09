using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace SpaceFlight.Lobby
{
	public class GameOver : BaseView 
	{
		public Action <Lobby.PageEnum> OnSwitchPage;
		
		public void GoSetting()
		{
			OnSwitchPage(Lobby.PageEnum.Setting);
		}
	
		public void GoShare()
		{
			//套API
		}
		public void GoRank()
		{
			//套API
		}
		public void GoEvaluate()
		{
			//一個網址
		}
		public void GoAchivement()
		{
			OnSwitchPage(Lobby.PageEnum.Achievement);
		}

		public void Goretry()
		{
			OnSwitchPage(Lobby.PageEnum.Game);
		}

		public void GoResume()
		{
			//開廣告，讀資料
		}
		public void GoGemStore()
		{
			OnSwitchPage(Lobby.PageEnum.GemStore);
		}

	}	

}

