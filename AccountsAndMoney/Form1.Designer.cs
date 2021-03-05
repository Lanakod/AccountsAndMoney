namespace AccountsAndMoney
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_createAccount = new System.Windows.Forms.TextBox();
            this.textBox_Put = new System.Windows.Forms.TextBox();
            this.button_CreateAccount = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Current = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.comboBox_Send = new System.Windows.Forms.ComboBox();
            this.textBox_Send = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_WD = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox_createAccount
            // 
            this.textBox_createAccount.Location = new System.Drawing.Point(106, 12);
            this.textBox_createAccount.Name = "textBox_createAccount";
            this.textBox_createAccount.Size = new System.Drawing.Size(121, 20);
            this.textBox_createAccount.TabIndex = 1;
            // 
            // textBox_Put
            // 
            this.textBox_Put.Location = new System.Drawing.Point(94, 25);
            this.textBox_Put.Name = "textBox_Put";
            this.textBox_Put.Size = new System.Drawing.Size(121, 20);
            this.textBox_Put.TabIndex = 2;
            // 
            // button_CreateAccount
            // 
            this.button_CreateAccount.Location = new System.Drawing.Point(233, 12);
            this.button_CreateAccount.Name = "button_CreateAccount";
            this.button_CreateAccount.Size = new System.Drawing.Size(75, 20);
            this.button_CreateAccount.TabIndex = 3;
            this.button_CreateAccount.Text = "Создать";
            this.button_CreateAccount.UseVisualStyleBackColor = true;
            this.button_CreateAccount.Click += new System.EventHandler(this.button_CreateAccount_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 4;
            this.button2.Text = "Пополнить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_Current);
            this.panel1.Controls.Add(this.button_Send);
            this.panel1.Controls.Add(this.comboBox_Send);
            this.panel1.Controls.Add(this.textBox_Send);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox_WD);
            this.panel1.Controls.Add(this.textBox_Put);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 105);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Текущая сумма";
            // 
            // textBox_Current
            // 
            this.textBox_Current.Location = new System.Drawing.Point(94, 0);
            this.textBox_Current.MaxLength = 9;
            this.textBox_Current.Name = "textBox_Current";
            this.textBox_Current.ReadOnly = true;
            this.textBox_Current.Size = new System.Drawing.Size(121, 20);
            this.textBox_Current.TabIndex = 9;
            this.textBox_Current.TabStop = false;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(348, 76);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 20);
            this.button_Send.TabIndex = 8;
            this.button_Send.Text = "Перевести";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // comboBox_Send
            // 
            this.comboBox_Send.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Send.FormattingEnabled = true;
            this.comboBox_Send.Location = new System.Drawing.Point(221, 76);
            this.comboBox_Send.Name = "comboBox_Send";
            this.comboBox_Send.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Send.TabIndex = 6;
            // 
            // textBox_Send
            // 
            this.textBox_Send.Location = new System.Drawing.Point(94, 77);
            this.textBox_Send.Name = "textBox_Send";
            this.textBox_Send.Size = new System.Drawing.Size(121, 20);
            this.textBox_Send.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 6;
            this.button1.Text = "Снять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_WD
            // 
            this.textBox_WD.Location = new System.Drawing.Point(94, 51);
            this.textBox_WD.Name = "textBox_WD";
            this.textBox_WD.Size = new System.Drawing.Size(121, 20);
            this.textBox_WD.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 156);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_CreateAccount);
            this.Controls.Add(this.textBox_createAccount);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Создание счетов";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_createAccount;
        private System.Windows.Forms.TextBox textBox_Put;
        private System.Windows.Forms.Button button_CreateAccount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_WD;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.ComboBox comboBox_Send;
        private System.Windows.Forms.TextBox textBox_Send;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Current;
        private System.Windows.Forms.Label label1;
    }
}

