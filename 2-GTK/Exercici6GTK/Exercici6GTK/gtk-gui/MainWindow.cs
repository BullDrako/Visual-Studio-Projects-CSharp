
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.Label label1;

	private global::Gtk.Entry entry4;

	private global::Gtk.Button button30;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		this.Resizable = false;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre en xifres Arabs");
		this.vbox1.Add(this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.entry4 = new global::Gtk.Entry();
		this.entry4.CanFocus = true;
		this.entry4.Name = "entry4";
		this.entry4.IsEditable = true;
		this.entry4.InvisibleChar = '●';
		this.vbox1.Add(this.entry4);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.entry4]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.button30 = new global::Gtk.Button();
		this.button30.CanFocus = true;
		this.button30.Name = "button30";
		this.button30.UseUnderline = true;
		this.button30.Label = global::Mono.Unix.Catalog.GetString("Clica!");
		this.vbox1.Add(this.button30);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.button30]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 305;
		this.DefaultHeight = 269;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.button30.Clicked += new global::System.EventHandler(this.ButtonOk_Clicked);
	}
}
