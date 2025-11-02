using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MessageBoxSh
{
    public enum MessageBoxIcon
    {
        Information = 1,
        Question = 2,
        Error = 3,
        Warning = 4

    }
    public partial class CMessageBox : Form
    {

        //public CMessageBox()
        //{

        //}
        public static DialogResult Show(string message, string title)
        {
            var cmessage = new CMessageBox(message, title);
            return cmessage.ShowDialog();
        }
        public static DialogResult Show(string message, string title, MessageBoxButtons buttons)
        {
            var cmessage = new CMessageBox(message, title,buttons);
            return cmessage.ShowDialog();
        }
        public static DialogResult Show(string message, string title, MessageBoxButtons buttons, MessageBoxSh.MessageBoxIcon messageBoxIcon)
        {
            var cmessage = new CMessageBox(message, title, buttons,messageBoxIcon);
            return cmessage.ShowDialog();
        }
       
        public CMessageBox(string message, string title)
        {
            InitializeComponent();

            this.Text = title;
            LblMesages.Text = message;
            btnCancel.Visible = false;
            closeResult = DialogResult.No;
            acceptResult = DialogResult.Yes;
            this.Icon = Properties.Resources.question;
            this.CancelButton = btnNo;
            //this.ShowDialog();
        }
        public CMessageBox(string message, string title, MessageBoxButtons buttons)
        {
            InitializeComponent();

            this.Text = title;
            LblMesages.Text = message;
            this.Icon = Properties.Resources.question;
            ButtonHandle(buttons);

           // this.ShowDialog();
        }
        private void ButtonHandle(MessageBoxButtons buttons)
        {
            if (buttons == MessageBoxButtons.OK)
            {
                btnNo.Visible = false;
                btnCancel.Visible = false;
                this.CancelButton = null;
                closeResult = DialogResult.Yes;
                acceptResult = DialogResult.Yes;
                btnYes.Text = "تایید";
            }
            else if (buttons == MessageBoxButtons.OKCancel)
            {
                btnYes.Text = "تایید";
                btnNo.Visible = false;

                closeResult = DialogResult.Cancel;
                acceptResult = DialogResult.OK;
            }
            else if (buttons == MessageBoxButtons.RetryCancel)
            {
                btnYes.Text = "تلاش مجدد";
                btnYes.TextAlign = ContentAlignment.MiddleRight;
                btnNo.Visible = false;

                closeResult = DialogResult.Cancel;
                acceptResult = DialogResult.Retry;
            }
            else if (buttons == MessageBoxButtons.YesNo)
            {
                btnCancel.Visible = false;
                closeResult = DialogResult.No;
                acceptResult = DialogResult.Yes;
                this.CancelButton = btnNo;
            }
            else if (buttons == MessageBoxButtons.YesNoCancel)
            {
                closeResult = DialogResult.Cancel;
                acceptResult = DialogResult.Yes;
            }
            else
            {
                closeResult = DialogResult.Cancel;
                acceptResult = DialogResult.Yes;
            }

        }
        public CMessageBox(string message, string title, MessageBoxButtons buttons,MessageBoxSh.MessageBoxIcon Icon)
        {
            InitializeComponent();

            this.Text = title;
            LblMesages.Text = message;

            ButtonHandle(buttons);

            if (Icon == MessageBoxIcon.Information)
            {
                this.Icon = Properties.Resources.Information;
                
            } else if (Icon == MessageBoxIcon.Question)
            {
                this.Icon = Properties.Resources.question;
            } else if (Icon == MessageBoxIcon.Error)
            {
                this.Icon = Properties.Resources.Error;
            } else if (Icon ==MessageBoxIcon.Warning)
            {
                this.Icon = Properties.Resources.warning;
            }
            SIcon = Icon;
            this.ShowIcon = true;

            //this.ShowDialog();
        }

        private DialogResult closeResult;
        private DialogResult acceptResult;
        private MessageBoxSh.MessageBoxIcon SIcon= MessageBoxIcon.Question;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = closeResult;
            this.Close();
            
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = closeResult;
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = acceptResult;
            this.Close();
        }

        private void CMessageBox_Load(object sender, EventArgs e)
        {

            if (SIcon == MessageBoxIcon.Question)
            {
                System.Media.SystemSounds.Question.Play();
            }
            else if (SIcon == MessageBoxIcon.Information)
            {
                System.Media.SystemSounds.Exclamation.Play();
            }
            else if (SIcon == MessageBoxIcon.Error)
            {
                System.Media.SystemSounds.Beep.Play();
            }
            else if (SIcon == MessageBoxIcon.Warning)
            {
                System.Media.SystemSounds.Hand.Play();
            }

           
        }
    }
}
