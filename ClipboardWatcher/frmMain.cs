using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ClipboardWatcher
{
    public partial class frmMain : Form
    {


        public frmMain()
        {
            InitializeComponent();
            
        }


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == ClipboardHelper.WM_CLIPBOARDUPDATE)
            {
                var unicode = ClipboardHelper.GetUnicodeText();
                uint processId = 0;
                string owner = "";

                IntPtr ownerHwnd = ClipboardHelper.GetClipboardOwner();
                if (ownerHwnd != IntPtr.Zero)
                {
                    ClipboardHelper.GetWindowThreadProcessId(ownerHwnd, out processId);
                    Process proc = Process.GetProcessById((int)processId);

                    owner = string.Format("{0} ({1})", proc.MainModule.ModuleName, (int)processId);
                }

                if (unicode != null)
                    dgvClipboard.Rows.Add(owner, "Unicode", unicode);

                var ascii = ClipboardHelper.GetASCIIText();

                if (ascii != null)
                    dgvClipboard.Rows.Add(owner, "ASCII", ascii);
            }
            base.WndProc(ref m);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClipboardHelper.RemoveClipboardFormatListener(Handle);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ClipboardHelper.AddClipboardFormatListener(Handle);

            dgvClipboard.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvClipboard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}
