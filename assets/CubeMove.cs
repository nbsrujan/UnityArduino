using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class CubeMove : MonoBehaviour {
	public float speed;

	private float amountToMove;

	SerialPort sp = new SerialPort("COM8",9600);
	// Use this for initialization
	void Start () {
		sp.Open();
		sp.ReadTimeout = 1;
	}
	
	// Update is called once per frame
	void Update () {
		amountToMove = speed * Time.deltaTime;

		if (sp.IsOpen) {
			try{
				moveObject(sp.ReadByte());
				print("SP_readbit"+sp.ReadByte()); 
			}
			catch(System.Exception)
			{
				 //throw;
			}
		}
	}
	void moveObject(int Direction){
	if (Direction == 1) {
			transform.Translate(Vector3.forward * amountToMove,Space.World);
		}
	if (Direction == 2) {
			transform.Translate(Vector3.back * amountToMove,Space.World);

		}
	
	}
}
