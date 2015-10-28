using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class xo : MonoBehaviour 
{

	private player play;
	public int i = 0;


	public Text text_1,text_2,text_3,text_4,text_5,text_6,text_7,text_8,text_9,text10;
	public Button Button1,Button2,Button3,Button4,Button5,Button6,Button7,Button8,Button9; 

	public GameObject eowin;
	public GameObject xxwin;
	public GameObject ddarw;


	void Start ()
	{
		//player = true;
		play = GetComponent<player>();
		play.playerr = true;


	}
	

	void Update () 
	{
		xwin();
		owin();
		xoo();
//		oowin();

	}
	public void click1()
	{
		if(play.playerr)
		{
			text_1.text = "x";
			play.playerr = false;
			i += 1;

		}
		else
		{
			text_1.text = "o";
			play.playerr = true;
			i += 1;
		}
		Button1.enabled = false;

	}
	public void click2()
	{
		if(play.playerr)
		{
			text_2.text = "x";
			play.playerr = false;
			i += 1;
			
		}
		else
		{
			text_2.text = "o";
			play.playerr = true;
			i += 1;
		}
		Button2.enabled = false;
		
	}
	public void click3()
	{
		if(play.playerr)
		{
			text_3.text = "x";
			play.playerr = false;
			i += 1;
			
		}
		else
		{
			text_3.text = "o";
			play.playerr = true;
			i += 1;
		}
		Button3.enabled = false;
		
	}
	public void click4()
	{
		if(play.playerr)
		{
			text_4.text = "x";
			play.playerr = false;
			i += 1;
		}
		else
		{
			text_4.text = "o";
			play.playerr = true;
			i += 1;
		}
		Button4.enabled = false;
		
	}
	public void click5()
	{
		if(play.playerr)
		{
			text_5.text = "x";
			play.playerr = false;
			i += 1;
			
		}
		else
		{
			text_5.text = "o";
			play.playerr = true;
			i += 1;
		}
		Button5.enabled = false;
		
	}
	public void click6()
	{
		if(play.playerr)
		{
			text_6.text = "x";
			play.playerr = false;
			i += 1;
			
		}
		else
		{
			text_6.text = "o";
			play.playerr = true;
			i += 1;
		}
		Button6.enabled = false;
		
	}
	public void click7()
	{
		if(play.playerr)
		{
			text_7.text = "x";
			play.playerr = false;
			i += 1;
			
		}
		else
		{
			text_7.text = "o";
			play.playerr = true;
			i += 1;
		}
		Button7.enabled = false;
		
	}
	public void click8()
	{
		if(play.playerr)
		{
			text_8.text = "x";
			play.playerr = false;
			i += 1;
			
		}
		else
		{
			text_8.text = "o";
			play.playerr = true;
			i += 1;
		}
		Button8.enabled = false;
		
	}
	public void click9()
	{
		if(play.playerr)
		{
			text_9.text = "x";
			play.playerr = false;
			i += 1;
			
		}
		else
		{
			text_9.text = "o";
			play.playerr = true;
			i += 1;
		}
		Button9.enabled = false;
		
	}
	public void xwin()
	{
		if(text_1.text == "x"& text_2.text == "x"&text_3.text=="x")
		{
			xxwin.SetActive(true);
			Invoke("Sc",2);
		}
		if(text_4.text == "x"& text_5.text == "x"&text_6.text=="x")
		{
			xxwin.SetActive(true);
			Invoke("Sc",2);
		}
		if(text_7.text == "x"& text_8.text == "x"&text_9.text=="x")
		{
			xxwin.SetActive(true);
			Invoke("Sc",2);
		}
		if(text_1.text == "x"& text_4.text == "x"&text_7.text=="x")
		{
			xxwin.SetActive(true);
			Invoke("Sc",2);
		}
		if(text_2.text == "x"& text_5.text == "x"&text_8.text=="x")
		{
			xxwin.SetActive(true);
			Invoke("Sc",2);
		}
		if(text_3.text == "x"& text_6.text == "x"&text_9.text=="x")
		{
			xxwin.SetActive(true);
			Invoke("Sc",2);
		}
		if(text_1.text == "x"& text_5.text == "x"&text_9.text=="x")
		{
			xxwin.SetActive(true);
			Invoke("Sc",2);
		}
		if(text_3.text == "x"& text_5.text == "x"&text_7.text=="x")
		{
			xxwin.SetActive(true);
			Invoke("Sc",2);
		}

	}
	public void owin()
	{
		if(text_1.text == "o"& text_2.text == "o"&text_3.text=="o")
		{
			eowin.SetActive(true);
			Invoke("Sc",2);
		}
		if(text_4.text == "o"& text_5.text == "o"&text_6.text=="o")
		{
			eowin.SetActive(true);
			Invoke("Sc",2);
		}
		if(text_7.text == "o"& text_8.text == "o"&text_9.text=="o")
		{
			eowin.SetActive(true);
			Invoke("Sc",2);
		}
		if(text_1.text == "o"& text_4.text == "o"&text_7.text=="o")
		{
			eowin.SetActive(true);
			Invoke("Sc",2);
		}
		if(text_2.text == "o"& text_5.text == "o"&text_8.text=="o")
		{
			eowin.SetActive(true);
			Invoke("Sc",2);
		}
		if(text_3.text == "o"& text_6.text == "o"&text_9.text=="o")
		{
			eowin.SetActive(true);
			Invoke("Sc",2);
		}
		if(text_1.text == "o"& text_5.text == "o"&text_9.text=="o")
		{
			eowin.SetActive(true);
			Invoke("Sc",2);
		}
		if(text_3.text == "o"& text_5.text == "o"&text_7.text=="o")
		{
			eowin.SetActive(true);
			Invoke("Sc",2);
		}
	}
//	public void oowin()
//	{
//		if(text_1.text == "x"& text_2.text == "x"&text_3.text=="o")
//		{
//			eowin.SetActive(true);
//		}
//		if(text_4.text == "o"& text_5.text == "o"&text_6.text=="o")
//		{
//			eowin.SetActive(true);
//		}
//		if(text_7.text == "o"& text_8.text == "o"&text_9.text=="o")
//		{
//			eowin.SetActive(true);;
//		}
//		if(text_1.text == "o"& text_4.text == "o"&text_7.text=="o")
//		{
//			eowin.SetActive(true);
//		}
//		if(text_2.text == "o"& text_5.text == "o"&text_8.text=="o")
//		{
//			eowin.SetActive(true);
//		}
//		if(text_3.text == "o"& text_6.text == "o"&text_9.text=="o")
//		{
//			eowin.SetActive(true);
//		}
//		if(text_1.text == "o"& text_5.text == "o"&text_9.text=="o")
//		{
//			eowin.SetActive(true);
//		}
//		if(text_3.text == "o"& text_5.text == "o"&text_7.text=="o")
//		{
//			eowin.SetActive(true);
//		}
//	}
	public void xoo()
	{
		if(i==9)
		{
			ddarw.SetActive(true);
			Invoke("Sc",2);
		}
	}
	protected virtual void Sc()
	{
		
		Application.LoadLevel("XO");
	}

	

}
