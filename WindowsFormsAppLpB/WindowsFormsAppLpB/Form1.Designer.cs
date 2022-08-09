namespace WindowsFormsAppLpB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.newPC = new System.Windows.Forms.Button();
            this.newHome = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.know = new System.Windows.Forms.Label();
            this.ex = new System.Windows.Forms.Label();
            this.mMorale = new System.Windows.Forms.Label();
            this.mMoney = new System.Windows.Forms.Label();
            this.mHP = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GameName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.moneyText = new System.Windows.Forms.Label();
            this.mon = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.t6 = new System.Windows.Forms.RadioButton();
            this.t5 = new System.Windows.Forms.RadioButton();
            this.t4 = new System.Windows.Forms.RadioButton();
            this.t3 = new System.Windows.Forms.RadioButton();
            this.t2 = new System.Windows.Forms.RadioButton();
            this.t1 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.v3 = new System.Windows.Forms.RadioButton();
            this.v2 = new System.Windows.Forms.RadioButton();
            this.v1 = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.PC = new System.Windows.Forms.PictureBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.Home = new System.Windows.Forms.PictureBox();
            this.notification = new System.Windows.Forms.GroupBox();
            this.OK = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PC)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.notification.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Peru;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 338);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Peru;
            this.groupBox4.Location = new System.Drawing.Point(6, 59);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(284, 217);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Курсы";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button3.Location = new System.Drawing.Point(6, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "Векторная графика (800$)";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button2.Location = new System.Drawing.Point(6, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "ООП в C# (1000$)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Location = new System.Drawing.Point(7, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Курс по геймдеву (1200$)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newPC
            // 
            this.newPC.BackColor = System.Drawing.Color.AntiqueWhite;
            this.newPC.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPC.ForeColor = System.Drawing.Color.Peru;
            this.newPC.Location = new System.Drawing.Point(336, 506);
            this.newPC.Name = "newPC";
            this.newPC.Size = new System.Drawing.Size(272, 137);
            this.newPC.TabIndex = 4;
            this.newPC.Text = "Улучшить пк (1000$)";
            this.newPC.UseVisualStyleBackColor = false;
            this.newPC.Click += new System.EventHandler(this.newPC_Click);
            // 
            // newHome
            // 
            this.newHome.BackColor = System.Drawing.Color.AntiqueWhite;
            this.newHome.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newHome.ForeColor = System.Drawing.Color.Peru;
            this.newHome.Location = new System.Drawing.Point(605, 506);
            this.newHome.Name = "newHome";
            this.newHome.Size = new System.Drawing.Size(274, 137);
            this.newHome.TabIndex = 3;
            this.newHome.Text = "Переехать (100000$)";
            this.newHome.UseVisualStyleBackColor = false;
            this.newHome.Click += new System.EventHandler(this.newHome_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.know);
            this.groupBox3.Controls.Add(this.ex);
            this.groupBox3.Controls.Add(this.mMorale);
            this.groupBox3.Controls.Add(this.mMoney);
            this.groupBox3.Controls.Add(this.mHP);
            this.groupBox3.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Peru;
            this.groupBox3.Location = new System.Drawing.Point(885, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 215);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Characteristics";
            // 
            // know
            // 
            this.know.AutoSize = true;
            this.know.Location = new System.Drawing.Point(6, 169);
            this.know.Name = "know";
            this.know.Size = new System.Drawing.Size(75, 34);
            this.know.TabIndex = 4;
            this.know.Text = "Skills";
            // 
            // ex
            // 
            this.ex.AutoSize = true;
            this.ex.Location = new System.Drawing.Point(6, 135);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(78, 34);
            this.ex.TabIndex = 3;
            this.ex.Text = "label3";
            // 
            // mMorale
            // 
            this.mMorale.AutoSize = true;
            this.mMorale.Location = new System.Drawing.Point(6, 101);
            this.mMorale.Name = "mMorale";
            this.mMorale.Size = new System.Drawing.Size(78, 34);
            this.mMorale.TabIndex = 2;
            this.mMorale.Text = "label3";
            this.mMorale.Click += new System.EventHandler(this.mMorale_Click);
            // 
            // mMoney
            // 
            this.mMoney.AutoSize = true;
            this.mMoney.Location = new System.Drawing.Point(6, 67);
            this.mMoney.Name = "mMoney";
            this.mMoney.Size = new System.Drawing.Size(78, 34);
            this.mMoney.TabIndex = 1;
            this.mMoney.Text = "label2";
            // 
            // mHP
            // 
            this.mHP.AutoSize = true;
            this.mHP.Location = new System.Drawing.Point(6, 33);
            this.mHP.Name = "mHP";
            this.mHP.Size = new System.Drawing.Size(78, 34);
            this.mHP.TabIndex = 0;
            this.mHP.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.GameName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.moneyText);
            this.groupBox2.Controls.Add(this.mon);
            this.groupBox2.Controls.Add(this.create);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Peru;
            this.groupBox2.Location = new System.Drawing.Point(336, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 488);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Создать игру";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Название";
            // 
            // GameName
            // 
            this.GameName.Location = new System.Drawing.Point(111, 292);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(165, 40);
            this.GameName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сколько выделите денег ?";
            // 
            // moneyText
            // 
            this.moneyText.AutoSize = true;
            this.moneyText.BackColor = System.Drawing.Color.AntiqueWhite;
            this.moneyText.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyText.ForeColor = System.Drawing.Color.Peru;
            this.moneyText.Location = new System.Drawing.Point(6, 434);
            this.moneyText.Name = "moneyText";
            this.moneyText.Size = new System.Drawing.Size(97, 45);
            this.moneyText.TabIndex = 5;
            this.moneyText.Text = "label2";
            // 
            // mon
            // 
            this.mon.Location = new System.Drawing.Point(17, 239);
            this.mon.Name = "mon";
            this.mon.Size = new System.Drawing.Size(255, 40);
            this.mon.TabIndex = 4;
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.AntiqueWhite;
            this.create.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create.Location = new System.Drawing.Point(6, 344);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(531, 87);
            this.create.TabIndex = 3;
            this.create.Text = "СОЗДАТЬ ИГРУ";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.t6);
            this.groupBox6.Controls.Add(this.t5);
            this.groupBox6.Controls.Add(this.t4);
            this.groupBox6.Controls.Add(this.t3);
            this.groupBox6.Controls.Add(this.t2);
            this.groupBox6.Controls.Add(this.t1);
            this.groupBox6.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Peru;
            this.groupBox6.Location = new System.Drawing.Point(282, 33);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(255, 299);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Тематика";
            // 
            // t6
            // 
            this.t6.AutoSize = true;
            this.t6.Location = new System.Drawing.Point(16, 249);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(123, 37);
            this.t6.TabIndex = 5;
            this.t6.TabStop = true;
            this.t6.Text = "Эволюция";
            this.t6.UseVisualStyleBackColor = true;
            // 
            // t5
            // 
            this.t5.AutoSize = true;
            this.t5.Location = new System.Drawing.Point(16, 206);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(138, 37);
            this.t5.TabIndex = 4;
            this.t5.TabStop = true;
            this.t5.Text = "Выживание";
            this.t5.UseVisualStyleBackColor = true;
            // 
            // t4
            // 
            this.t4.AutoSize = true;
            this.t4.Location = new System.Drawing.Point(16, 163);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(128, 37);
            this.t4.TabIndex = 3;
            this.t4.TabStop = true;
            this.t4.Text = "Свободная";
            this.t4.UseVisualStyleBackColor = true;
            // 
            // t3
            // 
            this.t3.AutoSize = true;
            this.t3.Location = new System.Drawing.Point(16, 120);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(189, 37);
            this.t3.TabIndex = 2;
            this.t3.TabStop = true;
            this.t3.Text = "Постапокалипсис";
            this.t3.UseVisualStyleBackColor = true;
            // 
            // t2
            // 
            this.t2.AutoSize = true;
            this.t2.Location = new System.Drawing.Point(16, 77);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(161, 37);
            this.t2.TabIndex = 1;
            this.t2.TabStop = true;
            this.t2.Text = "Строительство";
            this.t2.UseVisualStyleBackColor = true;
            // 
            // t1
            // 
            this.t1.AutoSize = true;
            this.t1.Location = new System.Drawing.Point(16, 34);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(87, 37);
            this.t1.TabIndex = 0;
            this.t1.TabStop = true;
            this.t1.Text = "Война";
            this.t1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.v3);
            this.groupBox5.Controls.Add(this.v2);
            this.groupBox5.Controls.Add(this.v1);
            this.groupBox5.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Peru;
            this.groupBox5.Location = new System.Drawing.Point(17, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(255, 170);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Жанр";
            // 
            // v3
            // 
            this.v3.AutoSize = true;
            this.v3.Location = new System.Drawing.Point(16, 120);
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(127, 37);
            this.v3.TabIndex = 2;
            this.v3.TabStop = true;
            this.v3.Text = "Симулятор";
            this.v3.UseVisualStyleBackColor = true;
            // 
            // v2
            // 
            this.v2.AutoSize = true;
            this.v2.Location = new System.Drawing.Point(16, 77);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(131, 37);
            this.v2.TabIndex = 1;
            this.v2.TabStop = true;
            this.v2.Text = "Песочница";
            this.v2.UseVisualStyleBackColor = true;
            // 
            // v1
            // 
            this.v1.AutoSize = true;
            this.v1.Location = new System.Drawing.Point(16, 34);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(78, 37);
            this.v1.TabIndex = 0;
            this.v1.TabStop = true;
            this.v1.Text = "Экшн";
            this.v1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBox1);
            this.groupBox7.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.Peru;
            this.groupBox7.Location = new System.Drawing.Point(0, 356);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(330, 287);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Вы";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsAppLpB.Properties.Resources.proger;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(6, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 252);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.PC);
            this.groupBox8.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.Peru;
            this.groupBox8.Location = new System.Drawing.Point(1164, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(339, 215);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Ваш ПК";
            // 
            // PC
            // 
            this.PC.BackgroundImage = global::WindowsFormsAppLpB.Properties.Resources.pc1;
            this.PC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PC.Location = new System.Drawing.Point(6, 31);
            this.PC.Name = "PC";
            this.PC.Size = new System.Drawing.Size(327, 172);
            this.PC.TabIndex = 8;
            this.PC.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.Home);
            this.groupBox9.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.Peru;
            this.groupBox9.Location = new System.Drawing.Point(885, 233);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(618, 410);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Дом";
            // 
            // Home
            // 
            this.Home.BackgroundImage = global::WindowsFormsAppLpB.Properties.Resources.home1;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Home.Location = new System.Drawing.Point(6, 39);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(606, 365);
            this.Home.TabIndex = 7;
            this.Home.TabStop = false;
            // 
            // notification
            // 
            this.notification.BackColor = System.Drawing.Color.Tan;
            this.notification.Controls.Add(this.OK);
            this.notification.Controls.Add(this.textBox1);
            this.notification.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification.ForeColor = System.Drawing.Color.SaddleBrown;
            this.notification.Location = new System.Drawing.Point(130, 12);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(1236, 588);
            this.notification.TabIndex = 9;
            this.notification.TabStop = false;
            this.notification.Text = "Уведомление";
            this.notification.Enter += new System.EventHandler(this.notification_Enter);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Tan;
            this.OK.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK.Location = new System.Drawing.Point(434, 434);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(402, 111);
            this.OK.TabIndex = 3;
            this.OK.Text = "Понятно";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Tan;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox1.Location = new System.Drawing.Point(30, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1168, 325);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1515, 746);
            this.Controls.Add(this.notification);
            this.Controls.Add(this.newPC);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.newHome);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PC)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.notification.ResumeLayout(false);
            this.notification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label mMorale;
        private System.Windows.Forms.Label mMoney;
        private System.Windows.Forms.Label mHP;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label know;
        private System.Windows.Forms.Label ex;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton t6;
        private System.Windows.Forms.RadioButton t5;
        private System.Windows.Forms.RadioButton t4;
        private System.Windows.Forms.RadioButton t3;
        private System.Windows.Forms.RadioButton t2;
        private System.Windows.Forms.RadioButton t1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton v3;
        private System.Windows.Forms.RadioButton v2;
        private System.Windows.Forms.RadioButton v1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mon;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button newHome;
        private System.Windows.Forms.Label moneyText;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GameName;
        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.PictureBox PC;
        private System.Windows.Forms.Button newPC;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox notification;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox textBox1;
    }
}

