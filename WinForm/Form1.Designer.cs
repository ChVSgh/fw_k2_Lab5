namespace WinForm
{

    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_t1_out = new System.Windows.Forms.TextBox();
            this.btn_t1 = new System.Windows.Forms.Button();
            this.tb_t1_in = new System.Windows.Forms.TextBox();
            this.label_t1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tb_t2_out = new System.Windows.Forms.TextBox();
            this.btn_t2 = new System.Windows.Forms.Button();
            this.tb_t2_in = new System.Windows.Forms.TextBox();
            this.label_t2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tb_t3_out = new System.Windows.Forms.TextBox();
            this.btn_t3 = new System.Windows.Forms.Button();
            this.tb_t3_in = new System.Windows.Forms.TextBox();
            this.label_t3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 590);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox6);
            this.tabPage1.Controls.Add(this.pictureBox5);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.tb_t1_out);
            this.tabPage1.Controls.Add(this.btn_t1);
            this.tabPage1.Controls.Add(this.tb_t1_in);
            this.tabPage1.Controls.Add(this.label_t1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(11);
            this.tabPage1.Size = new System.Drawing.Size(888, 561);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(96, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(103, 113);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(8, 233);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(191, 320);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(205, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(663, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tb_t1_out
            // 
            this.tb_t1_out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_t1_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_t1_out.Location = new System.Drawing.Point(205, 223);
            this.tb_t1_out.Multiline = true;
            this.tb_t1_out.Name = "tb_t1_out";
            this.tb_t1_out.ReadOnly = true;
            this.tb_t1_out.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_t1_out.Size = new System.Drawing.Size(663, 330);
            this.tb_t1_out.TabIndex = 3;
            this.tb_t1_out.Text = "Результат";
            // 
            // btn_t1
            // 
            this.btn_t1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_t1.Location = new System.Drawing.Point(24, 171);
            this.btn_t1.Name = "btn_t1";
            this.btn_t1.Size = new System.Drawing.Size(844, 46);
            this.btn_t1.TabIndex = 2;
            this.btn_t1.Text = "Выполнить";
            this.btn_t1.UseVisualStyleBackColor = true;
            // 
            // tb_t1_in
            // 
            this.tb_t1_in.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_t1_in.Location = new System.Drawing.Point(24, 143);
            this.tb_t1_in.Name = "tb_t1_in";
            this.tb_t1_in.Size = new System.Drawing.Size(844, 22);
            this.tb_t1_in.TabIndex = 1;
            // 
            // label_t1
            // 
            this.label_t1.AutoSize = true;
            this.label_t1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_t1.Location = new System.Drawing.Point(21, 115);
            this.label_t1.Name = "label_t1";
            this.label_t1.Size = new System.Drawing.Size(178, 25);
            this.label_t1.TabIndex = 0;
            this.label_t1.Text = "Введите выражение:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.tb_t2_out);
            this.tabPage2.Controls.Add(this.btn_t2);
            this.tabPage2.Controls.Add(this.tb_t2_in);
            this.tabPage2.Controls.Add(this.label_t2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(11);
            this.tabPage2.Size = new System.Drawing.Size(888, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(854, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // tb_t2_out
            // 
            this.tb_t2_out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_t2_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_t2_out.Location = new System.Drawing.Point(18, 350);
            this.tb_t2_out.Multiline = true;
            this.tb_t2_out.Name = "tb_t2_out";
            this.tb_t2_out.ReadOnly = true;
            this.tb_t2_out.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_t2_out.Size = new System.Drawing.Size(850, 193);
            this.tb_t2_out.TabIndex = 3;
            this.tb_t2_out.Text = "Результат";
            // 
            // btn_t2
            // 
            this.btn_t2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_t2.Location = new System.Drawing.Point(18, 312);
            this.btn_t2.Name = "btn_t2";
            this.btn_t2.Size = new System.Drawing.Size(850, 32);
            this.btn_t2.TabIndex = 2;
            this.btn_t2.Text = "Выполнить";
            this.btn_t2.UseVisualStyleBackColor = true;
            // 
            // tb_t2_in
            // 
            this.tb_t2_in.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_t2_in.Location = new System.Drawing.Point(18, 187);
            this.tb_t2_in.Multiline = true;
            this.tb_t2_in.Name = "tb_t2_in";
            this.tb_t2_in.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_t2_in.Size = new System.Drawing.Size(850, 117);
            this.tb_t2_in.TabIndex = 1;
            // 
            // label_t2
            // 
            this.label_t2.AutoSize = true;
            this.label_t2.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_t2.Location = new System.Drawing.Point(15, 163);
            this.label_t2.Name = "label_t2";
            this.label_t2.Size = new System.Drawing.Size(743, 25);
            this.label_t2.TabIndex = 0;
            this.label_t2.Text = "Введите 2..50 слов (a-z, 1..8), между словами пробел(ы), после последнего слова т" +
    "очка.";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox4);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.tb_t3_out);
            this.tabPage3.Controls.Add(this.btn_t3);
            this.tabPage3.Controls.Add(this.tb_t3_in);
            this.tabPage3.Controls.Add(this.label_t3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(11);
            this.tabPage3.Size = new System.Drawing.Size(888, 561);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Задание 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(16, 315);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(858, 238);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(858, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // tb_t3_out
            // 
            this.tb_t3_out.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_t3_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_t3_out.Location = new System.Drawing.Point(16, 282);
            this.tb_t3_out.Name = "tb_t3_out";
            this.tb_t3_out.ReadOnly = true;
            this.tb_t3_out.Size = new System.Drawing.Size(858, 27);
            this.tb_t3_out.TabIndex = 3;
            this.tb_t3_out.Text = "Результат";
            // 
            // btn_t3
            // 
            this.btn_t3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_t3.Location = new System.Drawing.Point(14, 235);
            this.btn_t3.Name = "btn_t3";
            this.btn_t3.Size = new System.Drawing.Size(860, 41);
            this.btn_t3.TabIndex = 2;
            this.btn_t3.Text = "Посчитать";
            this.btn_t3.UseVisualStyleBackColor = true;
            // 
            // tb_t3_in
            // 
            this.tb_t3_in.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_t3_in.Location = new System.Drawing.Point(14, 133);
            this.tb_t3_in.Multiline = true;
            this.tb_t3_in.Name = "tb_t3_in";
            this.tb_t3_in.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_t3_in.Size = new System.Drawing.Size(860, 96);
            this.tb_t3_in.TabIndex = 1;
            // 
            // label_t3
            // 
            this.label_t3.AutoSize = true;
            this.label_t3.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_t3.Location = new System.Drawing.Point(11, 109);
            this.label_t3.Name = "label_t3";
            this.label_t3.Size = new System.Drawing.Size(194, 25);
            this.label_t3.TabIndex = 0;
            this.label_t3.Text = "Введите предложение:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 590);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(912, 637);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛР5, вариант 6";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label_t1;
        private System.Windows.Forms.TextBox tb_t1_in;
        private System.Windows.Forms.Button btn_t1;
        private System.Windows.Forms.TextBox tb_t1_out;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label_t2;
        private System.Windows.Forms.TextBox tb_t2_in;
        private System.Windows.Forms.Button btn_t2;
        private System.Windows.Forms.TextBox tb_t2_out;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label_t3;
        private System.Windows.Forms.TextBox tb_t3_in;
        private System.Windows.Forms.Button btn_t3;
        private System.Windows.Forms.TextBox tb_t3_out;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}