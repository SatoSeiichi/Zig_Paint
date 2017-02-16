using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using DigitalRuby.AnimatedLineRenderer;

public class ZigScriptDraw : MonoBehaviour {
	public AnimatedLineRenderer AnimatedLine;
	float x = 0;
	float y = 0;

	bool tachiFlag = false;

	// Use this for initialization
	void Start () {
		GetComponent<ZigReciever> ().SetUp (OnReciveZigData);
	}
	
	// Update is called once per frame
	void Update () {

		if (AnimatedLine == null)
		{
			return;
		}
		else if (tachiFlag) {
			float x = 0;
			x = (Screen.width / 2) * (this.x + 1);

			float y = 0;
			y = (Screen.height / 2) * (this.y - 1) * -1;
			Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(x, y, AnimatedLine.transform.position.z));

			AnimatedLine.Enqueue(pos);
		}


	}

	void OnReciveZigData(string data){
		JSONNode zigData = JSONNode.Parse (data);

		JSONArray array = zigData["sensordata"]["touch"].AsArray;

		for (int i = 0; i < array.Count; i++) {

			x = array [i] ["x"].AsFloat;
			y = array [i] ["y"].AsFloat;
		}

		if (array.Count > 0) {
			tachiFlag = true;
		} else {
			tachiFlag = false;
		}

	}
}
