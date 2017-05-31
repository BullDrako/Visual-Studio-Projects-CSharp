using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{

	int intentos = 5;
	int intentosGanar = 1;

	Gdk.Pixbuf ganador;

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
		label2.Text = Convert.ToString(intentos);

	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected void OnEntry1Changed(object sender, EventArgs e)
	{
		
	}

	protected void OnButtonOkClicked(object sender, EventArgs e)
	{
		//Crear aleatorio
		Random aleatorio = new Random();

		//Aleatorio del 1 al 10
		int aleatorio1 = aleatorio.Next(1, 10);

		//El aleatorio aparece en la segunda caja
		entry2.Text = aleatorio1.ToString();

		//si el numero de la primera caja es = al aleatorio mostar mensaje y foto
		if (entry1.Text == aleatorio1.ToString())
		{
			MessageDialog mes = new MessageDialog(this,
			DialogFlags.DestroyWithParent, MessageType.Warning,
										  ButtonsType.Ok, "has ganado y deberia salir foto");
			mes.Run();
			mes.Destroy();

			try
			{
				ganador = new Gdk.Pixbuf("ganador.jpg");
			}
			catch
			{
				
				MessageDialog m = new MessageDialog(this,
			DialogFlags.DestroyWithParent, MessageType.Warning,
										  ButtonsType.Ok, "no encontrada");
				m.Run();
				m.Destroy();

			}

			image1 = new Image(ganador);
			image1.Visible = true;
			Add(image1);

			ShowAll();

			label3.Text = "lo has hecho en " + intentosGanar.ToString() + " intentos";
			ButtonOk.Destroy();

		}//si el numero de la primera caja no es = al aleatorio
		else {//descontar intentos
			MessageDialog mes = new MessageDialog(this,
			DialogFlags.DestroyWithParent, MessageType.Warning,
										  ButtonsType.Ok, "has perdido");
			mes.Run();
			mes.Destroy();
			intentos--;
			label2.Text = Convert.ToString(intentos);
			intentosGanar++;
			//label7.Text = "lo has hecho en " + intentosGanar.ToString() + "intentos";

		}
		//si se acaban los intentos mostar mensaje
		if (intentos == 0)
		{

			ButtonOk.Destroy();
			MessageDialog mes = new MessageDialog(this,
			DialogFlags.DestroyWithParent, MessageType.Warning,
										  ButtonsType.Ok, "No te quedan intentos");
			mes.Run();
			mes.Destroy();

			label4.Text = "No te quedan intentos";
			label4.ToString();
		}

	}
}
