namespace Example3_19
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnChancel = new System.Windows.Forms.Button();
            this.cmbTicketType = new System.Windows.Forms.ComboBox();
            this.grpDiscount = new System.Windows.Forms.GroupBox();
            this.rdbNine = new System.Windows.Forms.RadioButton();
            this.rdbEight = new System.Windows.Forms.RadioButton();
            this.rdbSixFive = new System.Windows.Forms.RadioButton();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTotalTicket = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.grpDiscount.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "购票类型:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "票价";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "应付款";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "实付款";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "找零";
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(196, 270);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 23);
            this.btnPayment.TabIndex = 6;
            this.btnPayment.Text = "购买";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnChancel
            // 
            this.btnChancel.Location = new System.Drawing.Point(392, 270);
            this.btnChancel.Name = "btnChancel";
            this.btnChancel.Size = new System.Drawing.Size(75, 23);
            this.btnChancel.TabIndex = 7;
            this.btnChancel.Text = "退出";
            this.btnChancel.UseVisualStyleBackColor = true;
            this.btnChancel.Click += new System.EventHandler(this.btnChancel_Click);
            // 
            // cmbTicketType
            // 
            this.cmbTicketType.FormattingEnabled = true;
            this.cmbTicketType.Items.AddRange(new object[] {
            "成人票",
            "儿童票",
            "折扣票"});
            this.cmbTicketType.Location = new System.Drawing.Point(150, 27);
            this.cmbTicketType.Name = "cmbTicketType";
            this.cmbTicketType.Size = new System.Drawing.Size(121, 20);
            this.cmbTicketType.TabIndex = 8;
            this.cmbTicketType.SelectedIndexChanged += new System.EventHandler(this.cmbTicketType_SelectedIndexChanged);
            // 
            // grpDiscount
            // 
            this.grpDiscount.Controls.Add(this.rdbSixFive);
            this.grpDiscount.Controls.Add(this.rdbEight);
            this.grpDiscount.Controls.Add(this.rdbNine);
            this.grpDiscount.Location = new System.Drawing.Point(96, 75);
            this.grpDiscount.Name = "grpDiscount";
            this.grpDiscount.Size = new System.Drawing.Size(115, 137);
            this.grpDiscount.TabIndex = 9;
            this.grpDiscount.TabStop = false;
            this.grpDiscount.Text = "折扣方式";
            // 
            // rdbNine
            // 
            this.rdbNine.AutoSize = true;
            this.rdbNine.Location = new System.Drawing.Point(7, 21);
            this.rdbNine.Name = "rdbNine";
            this.rdbNine.Size = new System.Drawing.Size(41, 16);
            this.rdbNine.TabIndex = 0;
            this.rdbNine.TabStop = true;
            this.rdbNine.Text = "9折";
            this.rdbNine.UseVisualStyleBackColor = true;
            this.rdbNine.CheckedChanged += new System.EventHandler(this.rdbNine_CheckedChanged);
            // 
            // rdbEight
            // 
            this.rdbEight.AutoSize = true;
            this.rdbEight.Location = new System.Drawing.Point(7, 66);
            this.rdbEight.Name = "rdbEight";
            this.rdbEight.Size = new System.Drawing.Size(41, 16);
            this.rdbEight.TabIndex = 1;
            this.rdbEight.TabStop = true;
            this.rdbEight.Text = "8折";
            this.rdbEight.UseVisualStyleBackColor = true;
            this.rdbEight.CheckedChanged += new System.EventHandler(this.rdbEight_CheckedChanged);
            // 
            // rdbSixFive
            // 
            this.rdbSixFive.AutoSize = true;
            this.rdbSixFive.Location = new System.Drawing.Point(7, 115);
            this.rdbSixFive.Name = "rdbSixFive";
            this.rdbSixFive.Size = new System.Drawing.Size(53, 16);
            this.rdbSixFive.TabIndex = 2;
            this.rdbSixFive.TabStop = true;
            this.rdbSixFive.Text = "6.5折";
            this.rdbSixFive.UseVisualStyleBackColor = true;
            this.rdbSixFive.CheckedChanged += new System.EventHandler(this.rdbSixFive_CheckedChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(447, 27);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 21);
            this.txtPrice.TabIndex = 10;
            // 
            // txtTotalTicket
            // 
            this.txtTotalTicket.Location = new System.Drawing.Point(447, 75);
            this.txtTotalTicket.Name = "txtTotalTicket";
            this.txtTotalTicket.Size = new System.Drawing.Size(100, 21);
            this.txtTotalTicket.TabIndex = 11;
            this.txtTotalTicket.TextChanged += new System.EventHandler(this.txtTotalTicket_TextChanged);
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(447, 223);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(100, 21);
            this.txtChange.TabIndex = 12;
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(447, 172);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(100, 21);
            this.txtPayment.TabIndex = 13;
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(447, 126);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ReadOnly = true;
            this.txtReceive.Size = new System.Drawing.Size(100, 21);
            this.txtReceive.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtTotalTicket);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.grpDiscount);
            this.Controls.Add(this.cmbTicketType);
            this.Controls.Add(this.btnChancel);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "门票销售";
            this.grpDiscount.ResumeLayout(false);
            this.grpDiscount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnChancel;
        private System.Windows.Forms.ComboBox cmbTicketType;
        private System.Windows.Forms.GroupBox grpDiscount;
        private System.Windows.Forms.RadioButton rdbSixFive;
        private System.Windows.Forms.RadioButton rdbEight;
        private System.Windows.Forms.RadioButton rdbNine;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTotalTicket;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.TextBox txtReceive;
    }
}

