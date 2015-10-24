using UnityEngine;
using System.Collections;

public class FbTwtShareRate : MonoBehaviour {


	
	public void FbShareBtnListener(){
		//facebook app id 
		string AppID = "1499460667014878";
		//app's link on google play sotre
		string Link = "https://play.google.com/store/apps/details?id=com.gmail.jsarifurr2011.interval&hl=en";
		// The picture's URL and the picture must be at least 200px by 200px.
		string Picture = "https://lh4.ggpht.com/uRv-V3-RI4qWBVID0KO_t6XXVf-GFHoInlFJa45GS-wAZUKOHN-2pNMulUergd3guQsd=h310-rw";
		
		// The name of your app or game.
		string Name = "Ball to Wall";
		
		// The caption of your game or app.
		string Caption = "My new Score in Ball2Wall Game is 99. Can u beat it?";
		
		// The description of your game or app.
		string Description = "Enjoy this free game! Challenge yourself and your friends.";

		Application.OpenURL("https://www.facebook.com/dialog/feed?"+
		                    "app_id="+AppID+
		                    "&link="+Link+
		                    "&picture="+Picture+
		                    "&name="+SpaceHere(Name)+
		                    "&caption="+SpaceHere(Caption)+
		                    "&description="+SpaceHere(Description)+
		                    "&redirect_uri=https://facebook.com/");
	}
	string SpaceHere (string val) {
		// %20 is only used for space
		return val.Replace(" ", "%20");
				
	}

	public void TwtShareBtnListener(){
		const string Address = "http://twitter.com/intent/tweet";

		Application.OpenURL(Address +
		                    "?text=" + WWW.EscapeURL("Hurraahh! My Score in the #this game is  90 on Android https://play.google.com/store/apps/details?id=com.gmail.jsarifurr2011.interval&hl=en") +
			"&amp;url=" + WWW.EscapeURL("\t") +
			"&amp;related=" + WWW.EscapeURL("\t") +
			"&amp;lang=" + WWW.EscapeURL("en"));

	}

	//rate your app
	public void rateBtnListener(){
		// you would enter your full package name, which can be found in your manifest file or in the Developer Console, at the top of the page, next to your game's name. It will generally have a format like "com.gameName" or "com.companyName.gameName".
		//Application.OpenURL("market://details?id=com.RnRVertigo/");
		//This will simply open the Google Play link in a web page, and if they haven't set a default to handle Google Play requests, prompt the user if they'd like to use the browser or the Google Play app. You may have use for this, but I generally avoid it because it potentially adds another step to the user's process, and I always shoot for simplicity.
		Application.OpenURL("http://play.google.com/store/apps/details?id=com.RnRVertigo");
	}
}
