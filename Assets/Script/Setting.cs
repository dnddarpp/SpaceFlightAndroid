using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace SpaceFlight.Lobby
{
	public class Setting :BaseView
	{
		public Action <Lobby.PageEnum> OnSwitchPage;
		public void close()
		{
			OnSwitchPage(Lobby.PageEnum.Home);
		}

		public void mute()
		{
				
		}
	//	void SoundValue(SountType type, )
	}


}

