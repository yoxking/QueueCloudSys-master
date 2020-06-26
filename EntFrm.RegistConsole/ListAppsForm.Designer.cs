namespace EntFrm.RegistConsole
{
    partial class ListAppsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.gvDataList = new System.Windows.Forms.DataGridView();
            this.AppCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestEMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gvDataList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // gvDataList
            // 
            this.gvDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppCode,
            this.DogId,
            this.AppClassName,
            this.GuestName,
            this.GuestEMail,
            this.GuestPhone,
            this.RegistDate,
            this.activeDate,
            this.ActiveCount,
            this.ActiveCode,
            this.AppVersion});
            this.gvDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDataList.Location = new System.Drawing.Point(5, 5);
            this.gvDataList.Name = "gvDataList";
            this.gvDataList.RowTemplate.Height = 27;
            this.gvDataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDataList.Size = new System.Drawing.Size(790, 440);
            this.gvDataList.TabIndex = 2;
            // 
            // AppCode
            // 
            this.AppCode.DataPropertyName = "AppCode";
            this.AppCode.HeaderText = "编号";
            this.AppCode.Name = "AppCode";
            this.AppCode.ReadOnly = true;
            this.AppCode.Width = 80;
            // 
            // DogId
            // 
            this.DogId.DataPropertyName = "DogId";
            this.DogId.HeaderText = "加密狗号";
            this.DogId.Name = "DogId";
            // 
            // AppClassName
            // 
            this.AppClassName.DataPropertyName = "AppClassName";
            this.AppClassName.HeaderText = "类型";
            this.AppClassName.Name = "AppClassName";
            this.AppClassName.ReadOnly = true;
            // 
            // GuestName
            // 
            this.GuestName.DataPropertyName = "GuestName";
            this.GuestName.HeaderText = "客户名称";
            this.GuestName.Name = "GuestName";
            this.GuestName.ReadOnly = true;
            // 
            // GuestEMail
            // 
            this.GuestEMail.DataPropertyName = "GuestEMail";
            this.GuestEMail.HeaderText = "邮箱";
            this.GuestEMail.Name = "GuestEMail";
            this.GuestEMail.ReadOnly = true;
            // 
            // GuestPhone
            // 
            this.GuestPhone.DataPropertyName = "GuestPhone";
            this.GuestPhone.HeaderText = "电话";
            this.GuestPhone.Name = "GuestPhone";
            this.GuestPhone.ReadOnly = true;
            // 
            // RegistDate
            // 
            this.RegistDate.DataPropertyName = "RegistDate";
            this.RegistDate.HeaderText = "注册时间";
            this.RegistDate.Name = "RegistDate";
            this.RegistDate.ReadOnly = true;
            // 
            // activeDate
            // 
            this.activeDate.DataPropertyName = "ActiveDate";
            this.activeDate.HeaderText = "有效期";
            this.activeDate.Name = "activeDate";
            // 
            // ActiveCount
            // 
            this.ActiveCount.DataPropertyName = "ActiveCount";
            this.ActiveCount.HeaderText = "授权数";
            this.ActiveCount.Name = "ActiveCount";
            this.ActiveCount.ReadOnly = true;
            // 
            // ActiveCode
            // 
            this.ActiveCode.DataPropertyName = "ActiveCode";
            this.ActiveCode.HeaderText = "注册码";
            this.ActiveCode.Name = "ActiveCode";
            this.ActiveCode.ReadOnly = true;
            // 
            // AppVersion
            // 
            this.AppVersion.DataPropertyName = "AppVersion";
            this.AppVersion.HeaderText = "版本";
            this.AppVersion.Name = "AppVersion";
            this.AppVersion.ReadOnly = true;
            // 
            // ListAppsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ListAppsForm";
            this.Text = "授权列表";
            this.Load += new System.EventHandler(this.ListAppsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDataList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gvDataList;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestEMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppVersion;
    }
}