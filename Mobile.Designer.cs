namespace Mobile_shop_management_system
{
    partial class Mobile
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            idtb = new TextBox();
            pricetb = new TextBox();
            label4 = new Label();
            stocktb = new TextBox();
            label5 = new Label();
            modeltb = new TextBox();
            label6 = new Label();
            brandtb = new TextBox();
            label7 = new Label();
            label8 = new Label();
            ramcb = new ComboBox();
            romcb = new ComboBox();
            label9 = new Label();
            cameratb = new TextBox();
            label10 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            addbtn = new Button();
            updatebtn = new Button();
            deletebtn = new Button();
            clearbtn = new Button();
            mobileGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mobileGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(213, 14);
            label1.Name = "label1";
            label1.Size = new Size(740, 62);
            label1.TabIndex = 0;
            label1.Text = "Mobile shop Management System";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1093, 12);
            label2.Name = "label2";
            label2.Size = new Size(57, 64);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(45, 121);
            label3.Name = "label3";
            label3.Size = new Size(44, 41);
            label3.TabIndex = 2;
            label3.Text = "Id";
            label3.Click += label3_Click;
            // 
            // idtb
            // 
            idtb.Location = new Point(106, 136);
            idtb.Margin = new Padding(3, 4, 3, 4);
            idtb.Name = "idtb";
            idtb.Size = new Size(133, 27);
            idtb.TabIndex = 3;
            idtb.TextChanged += textBox1_TextChanged;
            // 
            // pricetb
            // 
            pricetb.Location = new Point(834, 141);
            pricetb.Margin = new Padding(3, 4, 3, 4);
            pricetb.Name = "pricetb";
            pricetb.Size = new Size(119, 27);
            pricetb.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(975, 129);
            label4.Name = "label4";
            label4.Size = new Size(90, 41);
            label4.TabIndex = 4;
            label4.Text = "Stock";
            // 
            // stocktb
            // 
            stocktb.Location = new Point(1057, 136);
            stocktb.Margin = new Padding(3, 4, 3, 4);
            stocktb.Name = "stocktb";
            stocktb.Size = new Size(84, 27);
            stocktb.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(753, 129);
            label5.Name = "label5";
            label5.Size = new Size(82, 41);
            label5.TabIndex = 6;
            label5.Text = "Price";
            // 
            // modeltb
            // 
            modeltb.Location = new Point(613, 136);
            modeltb.Margin = new Padding(3, 4, 3, 4);
            modeltb.Name = "modeltb";
            modeltb.Size = new Size(119, 27);
            modeltb.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(511, 127);
            label6.Name = "label6";
            label6.Size = new Size(104, 41);
            label6.TabIndex = 8;
            label6.Text = "Model";
            // 
            // brandtb
            // 
            brandtb.Location = new Point(358, 136);
            brandtb.Margin = new Padding(3, 4, 3, 4);
            brandtb.Name = "brandtb";
            brandtb.Size = new Size(133, 27);
            brandtb.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(264, 124);
            label7.Name = "label7";
            label7.Size = new Size(95, 41);
            label7.TabIndex = 10;
            label7.Text = "Brand";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(45, 189);
            label8.Name = "label8";
            label8.Size = new Size(161, 41);
            label8.TabIndex = 12;
            label8.Text = "RAM In GB";
            // 
            // ramcb
            // 
            ramcb.FormattingEnabled = true;
            ramcb.Items.AddRange(new object[] { "1", "2", "4", "6", "8", "16" });
            ramcb.Location = new Point(209, 201);
            ramcb.Margin = new Padding(3, 4, 3, 4);
            ramcb.Name = "ramcb";
            ramcb.Size = new Size(124, 28);
            ramcb.TabIndex = 13;
            // 
            // romcb
            // 
            romcb.FormattingEnabled = true;
            romcb.Items.AddRange(new object[] { "8", "16", "32", "64", "128", "256" });
            romcb.Location = new Point(568, 204);
            romcb.Margin = new Padding(3, 4, 3, 4);
            romcb.Name = "romcb";
            romcb.Size = new Size(124, 28);
            romcb.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(397, 192);
            label9.Name = "label9";
            label9.Size = new Size(165, 41);
            label9.TabIndex = 14;
            label9.Text = "ROM In GB";
            label9.Click += label9_Click;
            // 
            // cameratb
            // 
            cameratb.Location = new Point(869, 204);
            cameratb.Margin = new Padding(3, 4, 3, 4);
            cameratb.Name = "cameratb";
            cameratb.Size = new Size(79, 27);
            cameratb.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(753, 192);
            label10.Name = "label10";
            label10.Size = new Size(119, 41);
            label10.TabIndex = 16;
            label10.Text = "Camera";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label11);
            panel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(-4, 329);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 51);
            panel1.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(411, 0);
            label11.Name = "label11";
            label11.Size = new Size(216, 46);
            label11.TabIndex = 19;
            label11.Text = "Mobile Stock";
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.Violet;
            addbtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            addbtn.ForeColor = Color.Black;
            addbtn.Location = new Point(89, 260);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(129, 49);
            addbtn.TabIndex = 19;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.Violet;
            updatebtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            updatebtn.ForeColor = Color.Black;
            updatebtn.Location = new Point(340, 260);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(129, 49);
            updatebtn.TabIndex = 20;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.Violet;
            deletebtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            deletebtn.ForeColor = Color.Black;
            deletebtn.Location = new Point(583, 260);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(129, 49);
            deletebtn.TabIndex = 21;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // clearbtn
            // 
            clearbtn.BackColor = Color.Violet;
            clearbtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            clearbtn.ForeColor = Color.Black;
            clearbtn.Location = new Point(805, 260);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(129, 49);
            clearbtn.TabIndex = 22;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = false;
            clearbtn.Click += clearbtn_Click;
            // 
            // mobileGV
            // 
            mobileGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mobileGV.Location = new Point(-1, 378);
            mobileGV.Name = "mobileGV";
            mobileGV.RowHeadersWidth = 51;
            mobileGV.RowTemplate.Height = 29;
            mobileGV.Size = new Size(1161, 335);
            mobileGV.TabIndex = 23;
            mobileGV.CellContentClick += mobileGV_CellContentClick;
            // 
            // Mobile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 713);
            Controls.Add(mobileGV);
            Controls.Add(clearbtn);
            Controls.Add(deletebtn);
            Controls.Add(updatebtn);
            Controls.Add(addbtn);
            Controls.Add(panel1);
            Controls.Add(cameratb);
            Controls.Add(label10);
            Controls.Add(romcb);
            Controls.Add(label9);
            Controls.Add(ramcb);
            Controls.Add(label8);
            Controls.Add(brandtb);
            Controls.Add(label7);
            Controls.Add(modeltb);
            Controls.Add(label6);
            Controls.Add(stocktb);
            Controls.Add(label5);
            Controls.Add(pricetb);
            Controls.Add(label4);
            Controls.Add(idtb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Mobile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mobile";
            Load += Mobile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mobileGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox idtb;
        private TextBox pricetb;
        private Label label4;
        private TextBox stocktb;
        private Label label5;
        private TextBox modeltb;
        private Label label6;
        private TextBox brandtb;
        private Label label7;
        private Label label8;
        private ComboBox ramcb;
        private ComboBox romcb;
        private Label label9;
        private TextBox cameratb;
        private Label label10;
        private Panel panel1;
        private Label label11;
        private Button addbtn;
        private Button updatebtn;
        private Button deletebtn;
        private Button clearbtn;
        private DataGridView mobileGV;
    }
}