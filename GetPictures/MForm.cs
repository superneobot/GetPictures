using System.Windows.Forms;

namespace GetPictures
{
    public class MForm : Form
    {
        Panel p;
        public MForm()
        {
            p = new Panel();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            p.Height = 40;
            p.Dock = DockStyle.Top;
            p.Visible = false;
            this.Controls.Add(p);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MForm";
            this.ResumeLayout(false);

        }
    }
}
