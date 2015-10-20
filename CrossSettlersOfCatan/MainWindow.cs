using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnFloppyActionActivated (object sender, EventArgs e)
	{
		Gtk.FileChooserDialog fc = new Gtk.FileChooserDialog("Save File",this,FileChooserAction.Save,Gtk.Stock.Cancel,ResponseType.Cancel,Gtk.Stock.Open,ResponseType.Accept);
        Gtk.FileFilter filter = new Gtk.FileFilter();
        filter.AddPattern("Images|*.png;*.bmp;*.jpg");
        fc.AddFilter(filter);
		/*sfd.Filter = "Images|*.png;*.bmp;*.jpg";
		ImageFormat format = ImageFormat.Png;
		if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
		{
			fileManager.save(sfd.FileName.Substring(0, sfd.FileName.IndexOf('.')), map, manager, getHeight());
			backgroundMap.Image.Save(sfd.FileName, format);
		}*/
		if(fc.Run()==(int)ResponseType.Accept){

		}
	}

	protected void OnEightActionChanged (object o, ChangedArgs args)
	{
		fiveAction.Active=false;
	}

	protected void OnSevenActionChanged (object o, ChangedArgs args)
	{
		throw new System.NotImplementedException ();
	}

	protected void OnSixActionChanged (object o, ChangedArgs args)
	{
		throw new System.NotImplementedException ();
	}
	
	protected void OnFiveActionChanged (object o, ChangedArgs args)
	{
		throw new System.NotImplementedException ();
	}

	protected void OnFiveActionActivated (object sender, EventArgs e)
	{
		eightAction.Active=false;
	}

}
