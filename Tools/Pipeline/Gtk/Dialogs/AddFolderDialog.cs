﻿using System;
using Gtk;

namespace MonoGame.Tools.Pipeline
{
    public partial class AddFolderDialog : Dialog
    {
        public CopyAction responce;

        public AddFolderDialog(Window parrent, string folderloc) : base(Mono.Unix.Catalog.GetString ("Add Folder Action"), parrent, DialogFlags.Modal)
        {
            Build();

            label1.Text = label1.Text.Replace("%folder", folderloc);
            label1.Markup = label1.Text;
        }

        protected void OnResponse(object sender, EventArgs e)
        {
            Destroy ();
        }

        protected void OnButtonOkClicked(object sender, EventArgs e)
        {
            responce = (radiobutton1.Active) ? CopyAction.Copy : CopyAction.Link;
            Respond(ResponseType.Ok);
        }
    }
}

