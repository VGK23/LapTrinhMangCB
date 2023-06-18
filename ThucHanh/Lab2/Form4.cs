using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lab2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        class FileTextStack<S>
        {
            private int topI;
            private readonly List<S> TextList;
            public FileTextStack()
            {
                TextList = new List<S>();
                topI = -1;
            }
            public int Count => TextList.Count; //đếm số phần tử thêm vào stack
            public bool IsEmpty => TextList.Count == 0;
            public void push(S text)
            {
                TextList.Add(text);
                topI++;
            }
            public S peek()
            {
                if (topI==-1) return default(S);
                return TextList[topI];
            }
            public S pop()
            {
                if (topI==-1) return default (S);
                S temp = TextList[topI];
                TextList.RemoveAt(topI);
                topI--;
                return temp;
            }
            public void clear()
            {
                TextList.Clear();
                topI = -1;
            }
        }    
        
        FileTextStack<string> expList = new FileTextStack<string>();
        string exp;
        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            do
            {
                exp = sr.ReadLine();
                if (exp != null)
                {
                    expList.push(exp);
                    rtbShow.Text = rtbShow.Text + exp + '\n';
                }
                } while (exp != null);
            fs.Close();
        }
        
        private void btnWriteResult_Click(object sender, EventArgs e)
        {
            string KetQua=null;
            while(!expList.IsEmpty)
            {
                string exp = expList.peek();
                int kqXuLi = XuLyBieuThuc(exp);
                KetQua += exp + " = " + kqXuLi.ToString() + "\n";
                expList.pop();
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK) // kiểm tra người dùng đã chọn tên file để lưu trữ hay chưa
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(KetQua);
                sw.Close();
                fs.Close();
            }
        }
        public int XuLyBieuThuc(string ex)
        {
                //Tạo mảng ký tự để phân tích các ký tự trong biểu thức
                char[] MangKyTu = ex.ToCharArray();
                //Tạo stack chứa các toán tử
                FileTextStack<char> NganToanTu = new FileTextStack<char>();
                //Tạo stack chứa các toán hạng
                FileTextStack<int> ToanHang = new FileTextStack<int>();

                //Tiến hành phân tích
                for (int i = 0; i < MangKyTu.Length; i++)
                {
                    if (MangKyTu[i] == ' ') continue; //bỏ qua các ký tự khoảng trống

                    if (MangKyTu[i] >= '0' && MangKyTu[i] <= '9') //Nếu là chữ số thì quét hết các chữ số, đổi thành kiểu int và đưa vào stack toán hạng
                    {
                    int toanHang = 0;
                    while (i < MangKyTu.Length && MangKyTu[i] >= '0' && MangKyTu[i] <= '9')
                    {
                        toanHang = toanHang * 10 + (int)(MangKyTu[i] - '0');
                        i++;
                    }
                    i--;
                    ToanHang.push(toanHang);
                    }

                    else if (MangKyTu[i] == '(') //Gặp dấu mở ngoặc thì bỏ vào stack toán tử
                        NganToanTu.push(MangKyTu[i]);
                    else if (MangKyTu[i] == ')') //Gặp dấu đóng ngoặc thì xử lí các biểu thức trong ngoặc
                    {
                        while (NganToanTu.peek() != '(') //kết thúc tính toán khi gặp dấu mở ngoặc -> tính được 1 ngoặc
                        {
                            ToanHang.push(TinhBieuThuc(ToanHang.pop(), ToanHang.pop(), NganToanTu.pop()));
                        }
                        NganToanTu.pop(); //bỏ dấu ngoặc sau khi đã xử lý xong
                    }
                    //khi gặp các toán tử tính toán thì tiến hành so sánh độ ưu tiên và tính toán cac biểu thức
                    else if (MangKyTu[i] == '+' || MangKyTu[i] == '-' || MangKyTu[i] == '*' || MangKyTu[i] == '/')
                    {
                        while (NganToanTu.Count > 0 && DoUuTien(MangKyTu[i], NganToanTu.peek()))
                            ToanHang.push(TinhBieuThuc(ToanHang.pop(), ToanHang.pop(), NganToanTu.pop()));
                        NganToanTu.push(MangKyTu[i]);
                    }
                }
             //Bên trên đã xong các bước phân tích và tính toán các biểu thức có độ ưu tiên, bên dươi tiến hành các phép toán còn lại.
             while (NganToanTu.Count > 0)
                    ToanHang.push(TinhBieuThuc(ToanHang.pop(), ToanHang.pop(), NganToanTu.pop()));
             return ToanHang.pop();
        }
        public int TinhBieuThuc(int x1, int x2, char dau) //tính toán biểu thức
        {
            switch (dau)
            {
                case '+': return x1 + x2;
                case '-': return x1 - x2;
                case '*': return x1 * x2;
                case '/':
                    {
                        if (x2 == 0)
                        {
                            MessageBox.Show("Không chia được cho 0!!");
                            return 0;
                        }
                        return x1 / x2;
                    }
            }
            return 0;
        }
        public bool DoUuTien(char dau1, char dau2) //Xem độ ưu tiên dấu trong phép toán
        {
            if (dau1 == '(' && dau2 == ')') //gặp cặp dấu đóng mở thì ưu tiên đầu tiên
                return false;
            if ((dau1 == '*' || dau1 == '/') && (dau2 == '+' || dau2 == '-')) 
                return false;
            return true;
        }
    }
}
