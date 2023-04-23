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

namespace Lab2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            //tên file
            txtName.Text = ofd.SafeFileName.ToString();

            //kích thước
            FileInfo fi = new FileInfo(ofd.FileName);
            txtSize.Text = fi.Length.ToString();

            //đường dẫn url
            txtUrl.Text = fs.Name.ToString();
            //số dòng

            if (fi.Length == 0) txtLines.Text = "0"; //fi.Length==0 -> kiểm tra có dữ liệu bên trong hay không
            else
            {
                int CountL = 0;
                foreach (char i in sr.ReadToEnd())
                {
                    if (i == '\n') CountL++;
                }
                CountL++;//cộng cho dòng cuối cùng.
                txtLines.Text = CountL.ToString();
            }
            fs.Close();
            //số từ
            FileStream fsCountW = new FileStream(ofd.FileName, FileMode.OpenOrCreate); //Hàm ReadToEnd() ở trên đã đưa con trỏ tới cuối file -> khởi tạo lại để đưa con trỏ về vị trí đầu file
            StreamReader srCountW = new StreamReader(fsCountW);
            if (fi.Length == 0)
            {
                txtWord.Text = "0";
            }    
            else
            {
                int countW = 1; //cho từ đầu tiên
                string strlines = srCountW.ReadToEnd();
                for (int i = 0; i < strlines.Length - 1; i++)
                    if ((strlines[i] == ' ' && strlines[i + 1] != ' ') || (strlines[i] == '\n' && strlines[i + 1] != '\n')) countW++;
                txtWord.Text = countW.ToString();
            }
            fsCountW.Close();
            //số ký tự
            FileStream fsCountCh = new FileStream(ofd.FileName, FileMode.OpenOrCreate); //Hàm ReadToEnd() ở trên đã đưa con trỏ tới cuối file -> khởi tạo lại để đưa con trỏ về vị trí đầu file
            StreamReader srCountCh = new StreamReader(fsCountCh);
            if (fi.Length == 0)
            {
                txtChar.Text = "0";
            }
            else
            {
                int countCh = 0;
                string strlines;
                do
                {
                    strlines = srCountCh.ReadLine();
                    if (strlines != null)
                        countCh += strlines.Length;
                } while (strlines != null);
                txtChar.Text = countCh.ToString();
            }
            fsCountCh.Close();
        }
    }
}
