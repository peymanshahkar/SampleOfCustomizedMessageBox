using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBoxSh;

namespace TestMessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CMessageBox.Show("test", "test");
            CMessageBox.Show("تست شماره یک: ؟ تست", "تست");
            CMessageBox.Show("تست شماره دو: ؟ تست", "تست",MessageBoxButtons.OK);
            CMessageBox.Show("تست شماره سه: ؟ تست", "تست", MessageBoxButtons.OKCancel);
            CMessageBox.Show("تست شماره ۴: ؟ تست", "تست", MessageBoxButtons.RetryCancel);
            CMessageBox.Show("تست شماره ۵: ؟ تست", "تست", MessageBoxButtons.YesNo);
            CMessageBox.Show("تست شماره 6: ؟ تست", "تست", MessageBoxButtons.YesNoCancel);



            CMessageBox.Show("تست شماره دو: ؟ تست", "تست", MessageBoxButtons.OK,MessageBoxSh.MessageBoxIcon.Error);
            CMessageBox.Show("تست شماره سه: ؟ تست", "تست", MessageBoxButtons.OKCancel,MessageBoxSh.MessageBoxIcon.Information);
            CMessageBox.Show("تست شماره ۴: ؟ تست", "تست", MessageBoxButtons.RetryCancel,MessageBoxSh.MessageBoxIcon.Question);
            CMessageBox.Show("تست شماره ۵: ؟ تست", "تست", MessageBoxButtons.YesNo,MessageBoxSh.MessageBoxIcon.Warning);



        }
    }
}
