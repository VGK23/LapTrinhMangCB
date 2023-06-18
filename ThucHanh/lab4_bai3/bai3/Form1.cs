using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WebBrowser webBrowser;
        private void Initial_Webrowser() // tao 1 ham khai bao 1 Web Browser moi va them no vao bang dieu huong
        {
            //Khai bao 1 Web Browser moi
            webBrowser = new WebBrowser();
            //Xac dinh chieu dai va chieu cao mac dinh cua web browser
            webBrowser.Width = 768;
            webBrowser.Height = 388;
            //Them web browser vao bang dieu huong
            pnWeb.Controls.Add(webBrowser);
        }
        private void GoToWeb_Click(object sender, EventArgs e)
        {
            pnWeb.Controls.Clear();
            Initial_Webrowser(); //tao 1 web browser moi va them vao bang dieu huong
            string url = tbUrl.Text; //gan duong dan url vao bien string co ten "url"
            webBrowser.Navigate(url); //su dung tinh nang Navigate cua Control WebBrowser de dieu huong toi web browser qua duong dan url
        }

        private void DLHtml_Click(object sender, EventArgs e)
        {
            try
            {
                HtmlWeb web = new HtmlWeb(); //khoi tao mot bien web kieu HtmlWeb
                HtmlAgilityPack.HtmlDocument htmlDCM = web.Load(tbUrl.Text); //load trang web thông qua đường dẫn url và đưa nội dung html vào document(htmlDCM)
                string htmlDownloaded = htmlDCM.DocumentNode.InnerHtml; //truy xuất nội dung html vừa tải vào biến htmlDownloaded
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "HTML Files|*.html";
                sfd.ShowDialog();
                FileStream fs = new FileStream(sfd.FileName,FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(htmlDownloaded);
                sw.Close();
                fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!!:" + ex.Message);
            }
            finally
            {
                MessageBox.Show("Successfull!");
            }
            
        }

        private void DLResource_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument htmlDCM = web.Load(tbUrl.Text);
            string htmlDownloaded = htmlDCM.DocumentNode.InnerHtml; 
        }
    }
}
