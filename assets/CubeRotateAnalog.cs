using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class CubeRotateAnalog : MonoBehaviour {
	SerialPort sp = new SerialPort("COM8",9600);
	// Use this for initialization
	void Start () {
		sp.Open();
		sp.ReadTimeout = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (sp.IsOpen) {
			try{
				rotateObject(sp.ReadLine());
				print("SP_readline"+sp.ReadLine()); 
			}
			catch(System.Exception)
			{
				//throw;
			}
		}
	}

	void rotateObject(string angle){
		float anglef = float.Parse (angle);
		anglef = anglef/2.8f;//2.8f is used as Arduino sends values from 0-1023
		transform.rotation = Quaternion.Euler(0,anglef,0); 
	}
}
