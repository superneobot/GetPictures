using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace GetPictures
{
    public partial class Form1 : Form

    {
        List<string> links;
        List<string> alinks;
        List<string> plinks;
        List<string> pic_size;
        int pic_index;
        string width_pic;
        string height_pic;
        const string appname = "GetPictures";
        string view_picture_url;

        BackgroundWorker worker = new BackgroundWorker();
        public Form1()
        {

            links = new List<string>();
            alinks = new List<string>();
            plinks = new List<string>();
            pic_size = new List<string>();

            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.WorkerReportsProgress = true;

            this.Text = appname;

            InitializeComponent();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                string item = Path.GetFileName(alinks[i].ToString());
                string path = Application.StartupPath + @"\" + $"{picname.Text}";
                DirectoryInfo dir = Directory.CreateDirectory(path);
                using (WebClient client = new WebClient())
                {
                    try
                    {
                        client.DownloadFile(new Uri(alinks[i].ToString()), Path.Combine(path, item));
                    }
                    catch (Exception)
                    {
                        i++;
                    }
                }
                int n = i * 100 / 30;
                String s = "Загружено " + n + "%";
                worker.ReportProgress(n, s);
            }
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progress.Value = e.ProgressPercentage;
            pr.Text = (String)e.UserState;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pr.Text = "Готово";
            progress.Value = 0;
        }

        private async void GetPicList(string text)
        {
            //
            var stext = text;
            if (stext.Contains(" ") == true)
            {
                stext = stext.Replace(" ", "+");
            }
            else
            {
                stext = text;
            }

            var url = $"https://yandex.ru/images/search?text={stext}";

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            try
            {
                var Result = htmlDoc.DocumentNode.Descendants("div")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Equals("page-layout__content-wrapper b-page__content")).ToList();

                var List = Result[0].Descendants("div")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Contains("serp-item__preview")).ToList();
                int i = 0;

                foreach (var item in List)
                {
                    var pic_preview = item.Descendants("img").FirstOrDefault().GetAttributeValue("src", "");
                    var pic = item.Descendants("a").FirstOrDefault().GetAttributeValue("href", "");

                    links.Add("https:" + pic_preview);
                    ImgList.Images.Add(LoadImage(links[i]));

                    var ulink = System.Uri.UnescapeDataString(pic);

                    alinks.Add(ulink.Replace($"/images/search?pos={i}&amp;img_url=", "")
                    .Replace($"&amp;text={stext}&amp;rpt=simage", ""));


                    pic_size.Add(item.InnerText.Replace("&nbsp;", "").Replace("HD", ""));

                    ListViewItem lvitem = new ListViewItem(new string[] { item.InnerText.Replace("&nbsp;", "").Replace("HD", "") });
                    lvitem.ImageIndex = i;
                    LV.Items.Add(lvitem);

                    listlinks.Items.Add(alinks[i]);
                    i++;
                    pr.Text = $"Получено " + i.ToString() + " картинок";


                    if (i == 30)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private Image LoadImage(string url)
        {
            System.Net.WebRequest request =
            System.Net.WebRequest.Create(url);
            System.Net.WebResponse response = request.GetResponse();
            System.IO.Stream responseStream =
            response.GetResponseStream();
            Bitmap bmp = new Bitmap(responseStream);
            responseStream.Dispose();
            return bmp;
        }

        private void getB_Click(object sender, EventArgs e)
        {
            if (picname.Text == "")
            {
                MessageBox.Show(this, "Введите критерий поиска!", appname, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                var text = picname.Text;
                GetPicList(text);
            }

        }

        private void downloadB_Click(object sender, EventArgs e)
        {
            if (listlinks.Items.Count <= 0)
            {
                MessageBox.Show(this, "Еще нечего качать!", appname, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                worker.RunWorkerAsync();
            }

        }

        public void ViewFullPicture(string p_url, int w, int h)
        {
            MForm view = new MForm();
            int sw = w;
            int sh = h;
            if (w > 3000)
            {
                sw = w / 4;
                sh = h / 4;
            }
            else
            {
                sw = w / 2;
                sh = h / 2;
            }
            view.Size = new Size(sw, sh);
            view.Text = $"{w} x {h} - Original size downscaled to {sw} x {sh}";
            view.FormBorderStyle = FormBorderStyle.FixedSingle;
            view.MaximizeBox = false;
            view.MinimizeBox = false;
            view.Show();
            Panel p = new Panel();
            p.BackColor = Color.FromArgb(60, 60, 84);
            p.Height = 35;
            p.Width = view.Width;
            p.Location = new Point(0, 0);

            p.Visible = true;
            Button b = new Button();
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.BackColor = Color.FromArgb(90, 90, 114);
            b.Size = new Size(85, 25);
            b.Location = new Point(5, 5);
            b.Text = "ЗАГРУЗИТЬ";
            b.Cursor = Cursors.Hand;
            b.Click += B_Click;

            Button bo = new Button();
            bo.FlatStyle = FlatStyle.Flat;
            bo.FlatAppearance.BorderSize = 0;
            bo.BackColor = Color.FromArgb(90, 90, 114);
            bo.Size = new Size(85, 25);
            bo.Location = new Point(95, 5);
            bo.Text = "ОТКРЫТЬ";
            bo.Cursor = Cursors.Hand;
            bo.Click += Bo_Click;

            PictureBox box = new PictureBox();
            view.Controls.Add(box);
            box.Dock = DockStyle.Fill;
            view_picture_url = p_url;
            try
            {
                box.Image = new Bitmap(LoadImage(p_url));
            }
            catch
            {
                b.Enabled = false;
                view.Width = 400;
                view.Height = 400;
                view.Text = "Ошибка загрузки изображения. Попробуйте открыть в браузере!";
                box.Image = Properties.Resources.error;
            }

            box.SizeMode = PictureBoxSizeMode.StretchImage;
            box.Click += delegate { view.Close(); };

            view.Controls.Add(p);
            box.Controls.Add(p);
            p.Controls.Add(b);
            p.Controls.Add(bo);

           // b.Click += delegate { MessageBox.Show(view, "Test", "Text"); };
           


        }

        private void OpenFile(string url)
        {
            System.Diagnostics.Process.Start(url);
        }

        private void Bo_Click(object sender, EventArgs e)
        {
            OpenFile(view_picture_url);
        }

        private void LoadFile(string url)
        {
            var str = url.Substring(url.LastIndexOf('.')); ;
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = $"Image files|*{str}|All Files|*.*";
                dialog.FileName = Path.GetFileName(url);
                if (dialog.ShowDialog(this) == DialogResult.OK)
                    

                using (WebClient cl = new WebClient())
                {
                    cl.DownloadFile(url, dialog.FileName);
                }
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            LoadFile(view_picture_url);
        }

        private void LV_Click(object sender, EventArgs e)
        {
            var slovo = picname.Text;
            if (slovo.Contains(" ") == true)
            {
                slovo = slovo.Replace(" ", "+");
            }
            else
            {
                slovo = picname.Text;
            }
            if (LV.SelectedIndices.Count >= 0)
                pic_index = LV.Items.IndexOf(LV.SelectedItems[0]);
            string pic_url = alinks[pic_index].ToString();
            var undecodedlink = alinks[pic_index].ToString();
            var decodelink = System.Uri.UnescapeDataString(undecodedlink);
            decodelink = decodelink.Replace($"&amp;text={slovo}&amp;rpt=simage", "");

            var uri = new Uri(decodelink);
            var result = $"{uri.Scheme}://{uri.Host}{uri.AbsolutePath}";





            string[] s = pic_size[pic_index].Split('×');
            width_pic = s[0];
            height_pic = s[1];
            int w = Convert.ToInt32(width_pic);
            int h = Convert.ToInt32(height_pic);
            ViewFullPicture(result, w, h);
        }

        private void clearb_Click(object sender, EventArgs e)
        {
            listlinks.Items.Clear();
            links.Clear();
            alinks.Clear();
            plinks.Clear();
            pic_size.Clear();
            pic_index = 0;
            LV.Clear();
            pr.Text = "Idle";
            picname.Text = "";
            ImgList.Images.Clear();

            MessageBox.Show(this, "Все очищено!", appname, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var url = "https://catherineasquithgallery.com/uploads/posts/2021-02/1612928484_8-p-fon-krasnii-barkhat-13.jpg";
            int w = 1920;
            int h = 1200;
            ViewFullPicture(url, w, h);
        }
    }
}
