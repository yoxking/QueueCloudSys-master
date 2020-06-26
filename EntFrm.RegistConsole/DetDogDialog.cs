using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EntFrm.RegistConsole
{
    public partial class DetDogDialog : Form
    {
        private string entDogId;

        public string EntDogId { get => entDogId; set => entDogId = value; }

        public DetDogDialog()
        {
            InitializeComponent();
        }

        private void DetDogDialog_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(EntDogId))
            {
                this.Close();
            }
            else
            {
                List<RegisterInfo> infoList = IMyPublicUtils.Load_InfoList();

                if (infoList != null)
                {
                    RegisterInfo info = infoList.Find(x => x.EncDogId.Equals(entDogId));
                    if (info != null)
                    {
                        txtDogID.Text = info.EncDogId;
                        txtDogType.Text = info.DogType;
                        txtOrganizName.Text = info.OrganizName;
                        txtContact.Text = info.Contact;
                        txtTelphone.Text = info.Telphone;
                        txtActiveCount.Text = info.ActiveCount.ToString();
                        txtUpdateDate.Text = info.UpdateDate.ToString("yyyy-MM-dd");
                        txtActiveDate.Text = info.ActiveDate.ToString("yyyy-MM-dd");
                        txtActValCode.Text = info.ActiveValCode;
                        txtComment.Text = info.Comment;
                    }
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
