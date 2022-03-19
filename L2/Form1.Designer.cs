namespace L2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.opendate = new System.Windows.Forms.DateTimePicker();
            this.sms = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.birthdate = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.passport = new System.Windows.Forms.TextBox();
            this.файлtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.поНомеруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поГодуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поТипуВкладаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripLabel();
            this.поиск = new System.Windows.Forms.ToolStripLabel();
            this.сортировка = new System.Windows.Forms.ToolStripLabel();
            this.очистить = new System.Windows.Forms.ToolStripLabel();
            this.удалить = new System.Windows.Forms.ToolStripLabel();
            this.вперед = new System.Windows.Forms.ToolStripLabel();
            this.назад = new System.Windows.Forms.ToolStripLabel();
            this.clone = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.balance)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(518, 41);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(247, 22);
            this.num.TabIndex = 1;
            this.num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип вклада";
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Закрытый",
            "Открытый"});
            this.type.Location = new System.Drawing.Point(518, 72);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(247, 24);
            this.type.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Баланс";
            // 
            // balance
            // 
            this.balance.LargeChange = 250;
            this.balance.Location = new System.Drawing.Point(518, 108);
            this.balance.Maximum = 1000000;
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(249, 56);
            this.balance.TabIndex = 5;
            this.balance.Scroll += new System.EventHandler(this.balance_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата открытия";
            // 
            // opendate
            // 
            this.opendate.Location = new System.Drawing.Point(518, 161);
            this.opendate.Name = "opendate";
            this.opendate.Size = new System.Drawing.Size(249, 22);
            this.opendate.TabIndex = 7;
            // 
            // sms
            // 
            this.sms.AutoSize = true;
            this.sms.Location = new System.Drawing.Point(443, 196);
            this.sms.Name = "sms";
            this.sms.Size = new System.Drawing.Size(184, 20);
            this.sms.TabIndex = 8;
            this.sms.Text = "Получать уведомления";
            this.sms.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "SMS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Имя";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(93, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(261, 22);
            this.name.TabIndex = 11;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // birthdate
            // 
            this.birthdate.Location = new System.Drawing.Point(162, 101);
            this.birthdate.Name = "birthdate";
            this.birthdate.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Дата рождения";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(395, 250);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 42);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(17, 320);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(748, 116);
            this.listBox1.TabIndex = 15;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(518, 251);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(109, 41);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(652, 250);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(113, 41);
            this.buttonLoad.TabIndex = 17;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Паспортные данные";
            // 
            // passport
            // 
            this.passport.Location = new System.Drawing.Point(196, 66);
            this.passport.Name = "passport";
            this.passport.Size = new System.Drawing.Size(158, 22);
            this.passport.TabIndex = 20;
            // 
            // файлtoolStripMenuItem
            // 
            this.файлtoolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.файлtoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.файлtoolStripMenuItem.Name = "файлtoolStripMenuItem";
            this.файлtoolStripMenuItem.Size = new System.Drawing.Size(58, 26);
            this.файлtoolStripMenuItem.Text = "файл";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.поискToolStripMenuItem.Text = "поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНомеруToolStripMenuItem,
            this.поГодуToolStripMenuItem,
            this.поТипуВкладаToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(173, 26);
            this.toolStripMenuItem4.Text = "сортировка";
            // 
            // поНомеруToolStripMenuItem
            // 
            this.поНомеруToolStripMenuItem.Name = "поНомеруToolStripMenuItem";
            this.поНомеруToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.поНомеруToolStripMenuItem.Text = "По номеру";
            this.поНомеруToolStripMenuItem.Click += new System.EventHandler(this.поНомеруToolStripMenuItem_Click);
            // 
            // поГодуToolStripMenuItem
            // 
            this.поГодуToolStripMenuItem.Name = "поГодуToolStripMenuItem";
            this.поГодуToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.поГодуToolStripMenuItem.Text = "По году открытия";
            this.поГодуToolStripMenuItem.Click += new System.EventHandler(this.поГодуОткрытияToolStripMenuItem_Click);
            // 
            // поТипуВкладаToolStripMenuItem
            // 
            this.поТипуВкладаToolStripMenuItem.Name = "поТипуВкладаToolStripMenuItem";
            this.поТипуВкладаToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.поТипуВкладаToolStripMenuItem.Text = "По типу вклада";
            this.поТипуВкладаToolStripMenuItem.Click += new System.EventHandler(this.типВкладаToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(173, 26);
            this.toolStripMenuItem5.Text = "выход";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem2.Text = "о программе";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.файлtoolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 30);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(32, 26);
            this.openToolStripMenuItem.Text = "V";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripButton1,
            this.поиск,
            this.сортировка,
            this.очистить,
            this.удалить,
            this.вперед,
            this.назад,
            this.clone,
            this.toolStripLabel3,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 442);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(777, 31);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(18, 28);
            this.toolStripLabel2.Text = "Х";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(0, 28);
            // 
            // поиск
            // 
            this.поиск.Name = "поиск";
            this.поиск.Size = new System.Drawing.Size(50, 28);
            this.поиск.Text = "поиск";
            this.поиск.Click += new System.EventHandler(this.поиск_Click);
            // 
            // сортировка
            // 
            this.сортировка.Name = "сортировка";
            this.сортировка.Size = new System.Drawing.Size(90, 28);
            this.сортировка.Text = "сортировка";
            this.сортировка.Click += new System.EventHandler(this.сортировка_Click);
            // 
            // очистить
            // 
            this.очистить.Name = "очистить";
            this.очистить.Size = new System.Drawing.Size(71, 28);
            this.очистить.Text = "очистить";
            this.очистить.Click += new System.EventHandler(this.очистить_Click);
            // 
            // удалить
            // 
            this.удалить.Name = "удалить";
            this.удалить.Size = new System.Drawing.Size(0, 28);
            // 
            // вперед
            // 
            this.вперед.Name = "вперед";
            this.вперед.Size = new System.Drawing.Size(0, 28);
            // 
            // назад
            // 
            this.назад.Name = "назад";
            this.назад.Size = new System.Drawing.Size(0, 28);
            // 
            // clone
            // 
            this.clone.Name = "clone";
            this.clone.Size = new System.Drawing.Size(45, 28);
            this.clone.Text = "clone";
            this.clone.Click += new System.EventHandler(this.clone_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(111, 28);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(49, 28);
            this.toolStripLabel3.Text = "назад";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 473);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.passport);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sms);
            this.Controls.Add(this.opendate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Банк";
            ((System.ComponentModel.ISupportInitialize)(this.balance)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar balance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker opendate;
        private System.Windows.Forms.CheckBox sms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.MonthCalendar birthdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox passport;
        private System.Windows.Forms.ToolStripMenuItem файлtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem поНомеруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поГодуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поТипуВкладаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripButton1;
        private System.Windows.Forms.ToolStripLabel поиск;
        private System.Windows.Forms.ToolStripLabel сортировка;
        private System.Windows.Forms.ToolStripLabel очистить;
        private System.Windows.Forms.ToolStripLabel удалить;
        private System.Windows.Forms.ToolStripLabel вперед;
        private System.Windows.Forms.ToolStripLabel назад;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel clone;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
    }
}

