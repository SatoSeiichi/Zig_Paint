using UnityEngine;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

public class ZigReciever : MonoBehaviour {

	public delegate void OnReciveDataCallback(string data);

	UdpClient udp;
	public int portNo=50000;
	Thread thread;

	OnReciveDataCallback OnReceiveData;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnDestroy(){
		if(udp!=null){
			udp.Close ();
			thread.Abort ();
		}
	}

	void OnThreading(){
		while (true) {
			IPEndPoint remoteEP = null;
			byte[] data = udp.Receive (ref remoteEP);
			string text = Encoding.ASCII.GetString (data);
			if (OnReceiveData != null) {
				OnReceiveData (text);
			}
		}
	}

	public void SetUp(OnReciveDataCallback callback){
		OnReceiveData = callback;
		udp = new UdpClient (portNo);
		thread = new Thread (new ThreadStart(OnThreading));
		thread.Start ();
	}

}
