using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
	static string abcdario = "ABCÇDEFGHIJKLMNÑOPQRSTUVWXYZ";

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}


	private void botonesLetras_Click(object sender, EventArgs e)
	{
		//todos los botones se muestran el entry
		Button b = (Button)sender;

		String display = entry1.Text.ToString();
		entry1.DeleteText(0, entry1.Text.Length);
		entry1.InsertText(display + b.Label );
	}


	static string cifrar(string mensaje, int desplazamiento)
	{
		String cifrado = "";
		if (desplazamiento > 0 && desplazamiento < abcdario.Length)
		{
			//recorre caracter a caracter el mensaje a cifrar
			for (int i = 0; i < mensaje.Length; i++)
			{
				int posCaracter = posicionAbecedario(mensaje[i]);
				if (posCaracter != -1) //el caracter existe en la variable abcdario
				{
					int pos = posCaracter + desplazamiento;
					while (pos >= abcdario.Length)
					{
						pos = pos - abcdario.Length;
					}
					//concatena al mensaje cifrado
					cifrado += abcdario[pos];
				}
				else//si no existe el caracter no se cifra
				{
					cifrado += mensaje[i];
				}
			}

		}
		return cifrado;

	}


	static int posicionAbecedario(char caracter)
	{
		for (int i = 0; i < abcdario.Length; i++)
		{
			if (caracter == abcdario[i])
			{
				return i;
			}
		}
		return -1;
	}


	private void botonOk_Click(object sender, EventArgs e)
	{
		string cifrarTexto = cifrar(entry1.Text, 5);
		entry2.Text = cifrarTexto;
	}
}
