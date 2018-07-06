using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;
using System;

namespace SpaceFlight.Lobby
{
	public class CharacterMode :BaseView
	
	{
		public Image characterlistbg,proplistbg;
		public GameObject characterlistcanvas;
		public GameObject proplistcanvas;

		public Action <Lobby.PageEnum> OnSwitchPage;
		void Start()
		{
			characterlistbg= GetComponent<Image>();
			proplistbg = GetComponent<Image>();
			characterlistcanvas.SetActive(true);
			proplistcanvas.SetActive(false);
		}
		public void GoAD()
		{
			if(Advertisement.IsReady("rewardedVideo"))
			{
				Advertisement.Show("rewardedVideo");
			}
		}
		public void characterlistOpen()
		{
			proplistcanvas.SetActive(false);
			characterlistcanvas.SetActive(true);
			proplistbg.color = new Color(193,52,52);
		
		}	
		public void proplistOpen()
		{
			characterlistbg.color = new Color(193,52,52);
			proplistcanvas.SetActive(true);
			characterlistcanvas.SetActive(false);
		}
		public void close()
		{
			OnSwitchPage(Lobby.PageEnum.Home);
		}
		public void goGemstore()
		{
			OnSwitchPage(Lobby.PageEnum.GemStore);
		}


	}


}
