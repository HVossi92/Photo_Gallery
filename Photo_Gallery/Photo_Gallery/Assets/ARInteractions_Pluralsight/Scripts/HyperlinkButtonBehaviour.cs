using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperlinkButtonBehaviour : MonoBehaviour {

  private string link;
	// Use this for initialization
	public void SetLink (string url){
    link = url;
  }

  public void OpenLink(){
    //open in browser on click
    if(link != null){
      Application.OpenURL(link);
    }
  }
}
