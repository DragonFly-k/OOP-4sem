namespace L2
{
    partial class Form2
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
            this.FIO = new System.Windows.Forms.TextBox();
            this.BALANCE = new System.Windows.Forms.TextBox();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checksearch = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.TYPE = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регулярное выражение:";
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(287, 21);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(121, 22);
            this.FIO.TabIndex = 1;
            this.FIO.Visible = false;
            this.FIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FIO_KeyPress);
            // 
            // BALANCE
            // 
            this.BALANCE.Location = new System.Drawing.Point(287, 50);
            this.BALANCE.Name = "BALANCE";
            this.BALANCE.Size = new System.Drawing.Size(121, 22);
            this.BALANCE.TabIndex = 2;
            this.BALANCE.Visible = false;
            this.BALANCE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BALANCE_KeyPress);
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(12, 46);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(162, 22);
            this.textsearch.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Баланс";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Тип вклада";
            this.label4.Visible = false;
            // 
            // checksearch
            // 
            this.checksearch.AutoSize = true;
            this.checksearch.Location = new System.Drawing.Point(12, 83);
            this.checksearch.Name = "checksearch";
            this.checksearch.Size = new System.Drawing.Size(162, 20);
            this.checksearch.TabIndex = 7;
            this.checksearch.Text = "Расширенный Поиск";
            this.checksearch.UseVisualStyleBackColor = true;
            this.checksearch.CheckedChanged += new System.EventHandler(this.checksearch_CheckedChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(15, 112);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "ПОИСК";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // TYPE
            // 
            this.TYPE.FormattingEnabled = true;
            this.TYPE.Items.AddRange(new object[] {
            "Открытй",
            "Закрытый"});
            this.TYPE.Location = new System.Drawing.Point(287, 81);
            this.TYPE.Name = "TYPE";
            this.TYPE.Size = new System.Drawing.Size(121, 24);
            this.TYPE.TabIndex = 9;
            this.TYPE.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 141);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(396, 84);
            this.listBox1.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(426, 244);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TYPE);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.checksearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.BALANCE);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.TextBox BALANCE;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checksearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox TYPE;
        private System.Windows.Forms.ListBox listBox1;
    }
}