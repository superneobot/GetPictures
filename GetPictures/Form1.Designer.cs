
namespace GetPictures
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statuspanel = new System.Windows.Forms.StatusStrip();
            this.progress = new System.Windows.Forms.ToolStripProgressBar();
            this.pr = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.downloadB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listlinks = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.getB = new System.Windows.Forms.Button();
            this.picname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LV = new System.Windows.Forms.ListView();
            this.ImgList = new System.Windows.Forms.ImageList(this.components);
            this.clearb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statuspanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statuspanel
            // 
            this.statuspanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progress,
            this.pr});
            this.statuspanel.Location = new System.Drawing.Point(0, 430);
            this.statuspanel.Name = "statuspanel";
            this.statuspanel.Size = new System.Drawing.Size(800, 22);
            this.statuspanel.TabIndex = 0;
            this.statuspanel.Text = "statusStrip1";
            // 
            // progress
            // 
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(100, 16);
            this.progress.Step = 1;
            // 
            // pr
            // 
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(26, 17);
            this.pr.Text = "Idle";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(153, 430);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.downloadB);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 400);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 23);
            this.panel3.TabIndex = 2;
            // 
            // downloadB
            // 
            this.downloadB.Dock = System.Windows.Forms.DockStyle.Top;
            this.downloadB.Location = new System.Drawing.Point(0, 0);
            this.downloadB.Name = "downloadB";
            this.downloadB.Size = new System.Drawing.Size(145, 23);
            this.downloadB.TabIndex = 0;
            this.downloadB.Text = "Скачать";
            this.downloadB.UseVisualStyleBackColor = true;
            this.downloadB.Click += new System.EventHandler(this.downloadB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listlinks);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 306);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список файлов";
            // 
            // listlinks
            // 
            this.listlinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listlinks.FormattingEnabled = true;
            this.listlinks.Location = new System.Drawing.Point(3, 16);
            this.listlinks.Name = "listlinks";
            this.listlinks.Size = new System.Drawing.Size(139, 287);
            this.listlinks.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearb);
            this.groupBox1.Controls.Add(this.getB);
            this.groupBox1.Controls.Add(this.picname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск картинок";
            // 
            // getB
            // 
            this.getB.Location = new System.Drawing.Point(64, 58);
            this.getB.Name = "getB";
            this.getB.Size = new System.Drawing.Size(75, 23);
            this.getB.TabIndex = 2;
            this.getB.Text = "Получить";
            this.getB.UseVisualStyleBackColor = true;
            this.getB.Click += new System.EventHandler(this.getB_Click);
            // 
            // picname
            // 
            this.picname.Location = new System.Drawing.Point(6, 32);
            this.picname.Name = "picname";
            this.picname.Size = new System.Drawing.Size(133, 20);
            this.picname.TabIndex = 1;
            this.picname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Критерий поиска";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.LV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(153, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 430);
            this.panel2.TabIndex = 3;
            // 
            // LV
            // 
            this.LV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV.GridLines = true;
            this.LV.HideSelection = false;
            this.LV.LargeImageList = this.ImgList;
            this.LV.Location = new System.Drawing.Point(0, 0);
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(645, 428);
            this.LV.TabIndex = 0;
            this.LV.UseCompatibleStateImageBehavior = false;
            this.LV.Click += new System.EventHandler(this.LV_Click);
            // 
            // ImgList
            // 
            this.ImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ImgList.ImageSize = new System.Drawing.Size(120, 67);
            this.ImgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // clearb
            // 
            this.clearb.Location = new System.Drawing.Point(10, 58);
            this.clearb.Name = "clearb";
            this.clearb.Size = new System.Drawing.Size(48, 23);
            this.clearb.TabIndex = 3;
            this.clearb.Text = "Clear";
            this.clearb.UseVisualStyleBackColor = true;
            this.clearb.Click += new System.EventHandler(this.clearb_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "test view window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statuspanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetPictures";
            this.statuspanel.ResumeLayout(false);
            this.statuspanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statuspanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox picname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listlinks;
        private System.Windows.Forms.Button getB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button downloadB;
        private System.Windows.Forms.ListView LV;
        private System.Windows.Forms.ImageList ImgList;
        private System.Windows.Forms.ToolStripProgressBar progress;
        private System.Windows.Forms.ToolStripStatusLabel pr;
        private System.Windows.Forms.Button clearb;
        private System.Windows.Forms.Button button1;
    }
}

