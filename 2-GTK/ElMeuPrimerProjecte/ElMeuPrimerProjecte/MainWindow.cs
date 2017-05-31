using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void ClicantBoto1 (object sender, EventArgs e)
	{
		//throw new NotImplementedException ();
		MessageDialog md = new MessageDialog (this,
			                   DialogFlags.DestroyWithParent, MessageType.Warning,
			                   ButtonsType.Ok, "Hola món");
		md.Run ();
		md.Destroy ();
	}
}
