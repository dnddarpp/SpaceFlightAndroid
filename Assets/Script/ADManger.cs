using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class ADManger : MonoBehaviour {

	public void GoRewardAD()
	{
		 if(Advertisement.IsReady("rewardedVideo"))
		 {
			 Advertisement.Show("rewardedVideo");
		 }

	}
}
