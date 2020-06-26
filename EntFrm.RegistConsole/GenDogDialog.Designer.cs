namespace EntFrm.RegistConsole
{
    partial class GenDogDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDogID = new System.Windows.Forms.TextBox();
            this.txtActCount = new System.Windows.Forms.TextBox();
            this.btnGenID = new System.Windows.Forms.Button();
            this.btnInitdog = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.dtActDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReadog = new System.Windows.Forms.Button();
            this.dpDogType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(49, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "授权数量：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(49, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "加密锁ID：";
            // 
            // txtDogID
            // 
            this.txtDogID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDogID.Location = new System.Drawing.Point(184, 33);
            this.txtDogID.Name = "txtDogID";
            this.txtDogID.ReadOnly = true;
            this.txtDogID.Size = new System.Drawing.Size(244, 30);
            this.txtDogID.TabIndex = 1;
            // 
            // txtActCount
            // 
            this.txtActCount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtActCount.Location = new System.Drawing.Point(184, 131);
            this.txtActCount.Name = "txtActCount";
            this.txtActCount.Size = new System.Drawing.Size(244, 30);
            this.txtActCount.TabIndex = 3;
            // 
            // btnGenID
            // 
            this.btnGenID.Location = new System.Drawing.Point(184, 265);
            this.btnGenID.Name = "btnGenID";
            this.btnGenID.Size = new System.Drawing.Size(379, 40);
            this.btnGenID.TabIndex = 5;
            this.btnGenID.Text = "写加密锁";
            this.btnGenID.UseVisualStyleBackColor = true;
            this.btnGenID.Click += new System.EventHandler(this.btnGenID_Click);
            // 
            // btnInitdog
            // 
            this.btnInitdog.Location = new System.Drawing.Point(53, 265);
            this.btnInitdog.Name = "btnInitdog";
            this.btnInitdog.Size = new System.Drawing.Size(118, 40);
            this.btnInitdog.TabIndex = 4;
            this.btnInitdog.Text = "初始加密锁";
            this.btnInitdog.UseVisualStyleBackColor = true;
            this.btnInitdog.Click += new System.EventHandler(this.btnInitdog_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(49, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "类别：";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Location = new System.Drawing.Point(181, 232);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(71, 15);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "lbStatus";
            // 
            // dtActDate
            // 
            this.dtActDate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtActDate.Location = new System.Drawing.Point(184, 180);
            this.dtActDate.Name = "dtActDate";
            this.dtActDate.Size = new System.Drawing.Size(244, 30);
            this.dtActDate.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(68, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "有效期：";
            // 
            // btnReadog
            // 
            this.btnReadog.Location = new System.Drawing.Point(445, 29);
            this.btnReadog.Name = "btnReadog";
            this.btnReadog.Size = new System.Drawing.Size(118, 39);
            this.btnReadog.TabIndex = 9;
            this.btnReadog.Text = "读加密锁";
            this.btnReadog.UseVisualStyleBackColor = true;
            this.btnReadog.Click += new System.EventHandler(this.btnReadog_Click);
            // 
            // dpDogType
            // 
            this.dpDogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dpDogType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpDogType.FormattingEnabled = true;
            this.dpDogType.Location = new System.Drawing.Point(184, 86);
            this.dpDogType.Name = "dpDogType";
            this.dpDogType.Size = new System.Drawing.Size(379, 28);
            this.dpDogType.TabIndex = 10;
            // 
            // GenDogDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 350);
            this.Controls.Add(this.dpDogType);
            this.Controls.Add(this.btnReadog);
            this.Controls.Add(this.dtActDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnInitdog);
            this.Controls.Add(this.btnGenID);
            this.Controls.Add(this.txtActCount);
            this.Controls.Add(this.txtDogID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenDogDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "写加密狗";
            this.Load += new System.EventHandler(this.GenDogDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDogID;
        private System.Windows.Forms.TextBox txtActCount;
        private System.Windows.Forms.Button btnGenID;
        private System.Windows.Forms.Button btnInitdog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.DateTimePicker dtActDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReadog;
        private System.Windows.Forms.ComboBox dpDogType;
    }
}