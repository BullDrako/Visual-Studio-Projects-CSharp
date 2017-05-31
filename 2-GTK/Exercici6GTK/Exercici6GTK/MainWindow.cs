using System;
using Gtk;
using Pango;

public partial class MainWindow : Gtk.Window
{
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();

		//Tipo de letra
		Pango.FontDescription fontdesc = Pango.FontDescription.FromString("Stencil 15");
		label1.ModifyFont(fontdesc);
		label1.ModifyFont(fontdesc);

		//Color ventana
		ModifyBg(StateType.Normal, new Gdk.Color(255, 0, 0));



		ShowAll();


	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}


	protected void ButtonOk_Clicked(object sender, EventArgs e)
	{
		int convertir = Convert.ToInt32(entry4.Text);
		String funcionRomano = convertirARomanos(convertir);

		MessageDialog mes = new MessageDialog(this,
		                        DialogFlags.DestroyWithParent, MessageType.Other,
		                        ButtonsType.OkCancel, "El valor es " + funcionRomano.ToString() );
		mes.Run();
		mes.Destroy();


	}

	public static String convertirARomanos(int numero)
	{
		int mill, cent, decenas, unidades;
		String romano = "";

		mill = numero / 1000;
		cent = numero / 100 % 10;
		decenas = numero / 10 % 10;
		unidades = numero % 10;

		// mil
		for (int i = 1; i <= mill; i++)
		{
			romano = romano + "M";
		}

		//cien
		if (cent == 9)
		{
			romano = romano + "C";
		}
		else if (cent >= 5)
		{
			romano = romano + "D";
			for (int i = 6; i <= cent; i++)
			{
				romano = romano + "C";
			}
		}
		else if (cent == 4)
		{
			romano = romano + "C";
		}
		else
		{
			for (int i = 1; i <= cent; i++)
			{
				romano = romano + "C";
			}
		}

		if (decenas == 9)
		{
			romano = romano + "X";
		}
		else if (decenas >= 5)
		{
			romano = romano + "L";
			for (int i = 6; i <= decenas; i++)
			{
				romano = romano + "X";
			}
		}
		else if (decenas == 4)
		{
			romano = romano + "X";
		}
		else
		{
			for (int i = 1; i <= decenas; i++)
			{
				romano = romano + "X";
			}
		}

		//unidades
		if (unidades == 9)
		{
			romano = romano + "IX";
		}
		else if (unidades >= 5)
		{
			romano = romano + "V";
			for (int i = 6; i <= unidades; i++)
			{
				romano = romano + "I";
			}
		}
		else if (unidades == 4)
		{
			romano = romano + "IV";
		}
		else
		{
			for (int i = 1; i <= unidades; i++)
			{
				romano = romano + "I";
			}
		}
		return romano;


	}

}
