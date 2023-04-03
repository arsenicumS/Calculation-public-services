namespace Calculation_public_services
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
            this.buttonNext = new System.Windows.Forms.Button();
            this.groupBoxSet = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_people = new System.Windows.Forms.NumericUpDown();
            this.labelCold = new System.Windows.Forms.Label();
            this.labelHot = new System.Windows.Forms.Label();
            this.labelNight = new System.Windows.Forms.Label();
            this.labelDey = new System.Windows.Forms.Label();
            this.TextBoxElectric_night = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxElectric = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxHot = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxCold = new System.Windows.Forms.MaskedTextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.checkBoxElectric = new System.Windows.Forms.CheckBox();
            this.checkBoxHot = new System.Windows.Forms.CheckBox();
            this.checkBoxCold = new System.Windows.Forms.CheckBox();
            this.groupBoxGet = new System.Windows.Forms.GroupBox();
            this.TextBoxRezult = new System.Windows.Forms.RichTextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_period = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_people)).BeginInit();
            this.groupBoxGet.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(669, 387);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(119, 37);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Tag = "Button_Next";
            this.buttonNext.Text = "Следующий расчетный период";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Visible = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // groupBoxSet
            // 
            this.groupBoxSet.Controls.Add(this.label1);
            this.groupBoxSet.Controls.Add(this.numeric_people);
            this.groupBoxSet.Controls.Add(this.labelCold);
            this.groupBoxSet.Controls.Add(this.labelHot);
            this.groupBoxSet.Controls.Add(this.labelNight);
            this.groupBoxSet.Controls.Add(this.labelDey);
            this.groupBoxSet.Controls.Add(this.TextBoxElectric_night);
            this.groupBoxSet.Controls.Add(this.TextBoxElectric);
            this.groupBoxSet.Controls.Add(this.TextBoxHot);
            this.groupBoxSet.Controls.Add(this.TextBoxCold);
            this.groupBoxSet.Controls.Add(this.labelInfo);
            this.groupBoxSet.Controls.Add(this.checkBoxElectric);
            this.groupBoxSet.Controls.Add(this.checkBoxHot);
            this.groupBoxSet.Controls.Add(this.checkBoxCold);
            this.groupBoxSet.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSet.Name = "groupBoxSet";
            this.groupBoxSet.Size = new System.Drawing.Size(776, 170);
            this.groupBoxSet.TabIndex = 3;
            this.groupBoxSet.TabStop = false;
            this.groupBoxSet.Tag = "GroupBox_Set";
            this.groupBoxSet.Text = "Передача Показаний";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Кол_во Проживающих";
            // 
            // numeric_people
            // 
            this.numeric_people.Location = new System.Drawing.Point(30, 41);
            this.numeric_people.Name = "numeric_people";
            this.numeric_people.Size = new System.Drawing.Size(52, 20);
            this.numeric_people.TabIndex = 18;
            this.numeric_people.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelCold
            // 
            this.labelCold.AutoSize = true;
            this.labelCold.Location = new System.Drawing.Point(157, 48);
            this.labelCold.Name = "labelCold";
            this.labelCold.Size = new System.Drawing.Size(87, 13);
            this.labelCold.TabIndex = 17;
            this.labelCold.Tag = "хвс";
            this.labelCold.Text = "Показания ХВС";
            this.labelCold.Visible = false;
            // 
            // labelHot
            // 
            this.labelHot.AutoSize = true;
            this.labelHot.Location = new System.Drawing.Point(353, 48);
            this.labelHot.Name = "labelHot";
            this.labelHot.Size = new System.Drawing.Size(86, 13);
            this.labelHot.TabIndex = 16;
            this.labelHot.Tag = "гвс";
            this.labelHot.Text = "Показания ГВС";
            this.labelHot.Visible = false;
            // 
            // labelNight
            // 
            this.labelNight.AutoSize = true;
            this.labelNight.Location = new System.Drawing.Point(722, 48);
            this.labelNight.Name = "labelNight";
            this.labelNight.Size = new System.Drawing.Size(32, 13);
            this.labelNight.TabIndex = 15;
            this.labelNight.Tag = "ночь";
            this.labelNight.Text = "Ночь";
            this.labelNight.Visible = false;
            // 
            // labelDey
            // 
            this.labelDey.AutoSize = true;
            this.labelDey.Location = new System.Drawing.Point(538, 48);
            this.labelDey.Name = "labelDey";
            this.labelDey.Size = new System.Drawing.Size(124, 13);
            this.labelDey.TabIndex = 14;
            this.labelDey.Tag = "день";
            this.labelDey.Text = "Показания Эл.Энергии";
            // 
            // TextBoxElectric_night
            // 
            this.TextBoxElectric_night.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextBoxElectric_night.Location = new System.Drawing.Point(657, 64);
            this.TextBoxElectric_night.Mask = "0000.00";
            this.TextBoxElectric_night.Name = "TextBoxElectric_night";
            this.TextBoxElectric_night.Size = new System.Drawing.Size(100, 20);
            this.TextBoxElectric_night.TabIndex = 13;
            this.TextBoxElectric_night.Tag = "TextBox_Electric";
            this.TextBoxElectric_night.Visible = false;
            // 
            // TextBoxElectric
            // 
            this.TextBoxElectric.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextBoxElectric.Location = new System.Drawing.Point(541, 64);
            this.TextBoxElectric.Mask = "0000.00";
            this.TextBoxElectric.Name = "TextBoxElectric";
            this.TextBoxElectric.Size = new System.Drawing.Size(100, 20);
            this.TextBoxElectric.TabIndex = 12;
            this.TextBoxElectric.Tag = "TextBox_Electric";
            // 
            // TextBoxHot
            // 
            this.TextBoxHot.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextBoxHot.Location = new System.Drawing.Point(356, 64);
            this.TextBoxHot.Mask = "0000.00";
            this.TextBoxHot.Name = "TextBoxHot";
            this.TextBoxHot.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHot.TabIndex = 11;
            this.TextBoxHot.Tag = "TextBox_Hot";
            this.TextBoxHot.Visible = false;
            // 
            // TextBoxCold
            // 
            this.TextBoxCold.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextBoxCold.Location = new System.Drawing.Point(160, 64);
            this.TextBoxCold.Mask = "0000.00";
            this.TextBoxCold.Name = "TextBoxCold";
            this.TextBoxCold.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCold.TabIndex = 3;
            this.TextBoxCold.Tag = "TextBox_Cold";
            this.TextBoxCold.Visible = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(6, 87);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(76, 13);
            this.labelInfo.TabIndex = 9;
            this.labelInfo.Tag = "Iabel_Info";
            this.labelInfo.Text = "Информация:";
            // 
            // checkBoxElectric
            // 
            this.checkBoxElectric.AutoSize = true;
            this.checkBoxElectric.Location = new System.Drawing.Point(541, 19);
            this.checkBoxElectric.Name = "checkBoxElectric";
            this.checkBoxElectric.Size = new System.Drawing.Size(192, 17);
            this.checkBoxElectric.TabIndex = 5;
            this.checkBoxElectric.Tag = "Caunter_Elertric";
            this.checkBoxElectric.Text = "Двух тарифный Электро счетчик";
            this.checkBoxElectric.UseVisualStyleBackColor = true;
            this.checkBoxElectric.CheckedChanged += new System.EventHandler(this.checkBoxElectric_CheckedChanged);
            // 
            // checkBoxHot
            // 
            this.checkBoxHot.AutoSize = true;
            this.checkBoxHot.Location = new System.Drawing.Point(356, 20);
            this.checkBoxHot.Name = "checkBoxHot";
            this.checkBoxHot.Size = new System.Drawing.Size(117, 17);
            this.checkBoxHot.TabIndex = 4;
            this.checkBoxHot.Tag = "Caunter_Hot";
            this.checkBoxHot.Text = "Прибор учета ГВС";
            this.checkBoxHot.UseVisualStyleBackColor = true;
            this.checkBoxHot.CheckedChanged += new System.EventHandler(this.checkBoxHot_CheckedChanged);
            // 
            // checkBoxCold
            // 
            this.checkBoxCold.AutoSize = true;
            this.checkBoxCold.Location = new System.Drawing.Point(160, 20);
            this.checkBoxCold.Name = "checkBoxCold";
            this.checkBoxCold.Size = new System.Drawing.Size(118, 17);
            this.checkBoxCold.TabIndex = 3;
            this.checkBoxCold.Tag = "Caunter_Cold";
            this.checkBoxCold.Text = "Прибор учета ХВС";
            this.checkBoxCold.UseVisualStyleBackColor = true;
            this.checkBoxCold.CheckedChanged += new System.EventHandler(this.checkBoxCold_CheckedChanged);
            // 
            // groupBoxGet
            // 
            this.groupBoxGet.Controls.Add(this.TextBoxRezult);
            this.groupBoxGet.Location = new System.Drawing.Point(12, 231);
            this.groupBoxGet.Name = "groupBoxGet";
            this.groupBoxGet.Size = new System.Drawing.Size(508, 207);
            this.groupBoxGet.TabIndex = 4;
            this.groupBoxGet.TabStop = false;
            this.groupBoxGet.Tag = "GroupBox_Get";
            this.groupBoxGet.Text = "Расчет по предоставленным показаниям";
            // 
            // TextBoxRezult
            // 
            this.TextBoxRezult.Location = new System.Drawing.Point(9, 19);
            this.TextBoxRezult.Name = "TextBoxRezult";
            this.TextBoxRezult.Size = new System.Drawing.Size(493, 182);
            this.TextBoxRezult.TabIndex = 7;
            this.TextBoxRezult.Tag = "rezult";
            this.TextBoxRezult.Text = "";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(713, 188);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 5;
            this.button_start.Text = "Расчитать";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Visible = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Настройка страницы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button_Setup);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Печать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button_Print);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(527, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 49);
            this.button3.TabIndex = 8;
            this.button3.Text = "Предварительный просмотр";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button_Preview_Dialog);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(262, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "задать период";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_set_period);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Введите период расчета";
            // 
            // TextBox_period
            // 
            this.TextBox_period.Location = new System.Drawing.Point(156, 188);
            this.TextBox_period.Mask = "00_00_0000";
            this.TextBox_period.Name = "TextBox_period";
            this.TextBox_period.PromptChar = '.';
            this.TextBox_period.Size = new System.Drawing.Size(100, 20);
            this.TextBox_period.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBox_period);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.groupBoxGet);
            this.Controls.Add(this.groupBoxSet);
            this.Controls.Add(this.buttonNext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxSet.ResumeLayout(false);
            this.groupBoxSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_people)).EndInit();
            this.groupBoxGet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.GroupBox groupBoxSet;
        private System.Windows.Forms.GroupBox groupBoxGet;
        private System.Windows.Forms.CheckBox checkBoxElectric;
        private System.Windows.Forms.CheckBox checkBoxHot;
        private System.Windows.Forms.CheckBox checkBoxCold;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.MaskedTextBox TextBoxElectric;
        private System.Windows.Forms.MaskedTextBox TextBoxHot;
        private System.Windows.Forms.MaskedTextBox TextBoxCold;
        private System.Windows.Forms.RichTextBox TextBoxRezult;
        private System.Windows.Forms.Label labelCold;
        private System.Windows.Forms.Label labelHot;
        private System.Windows.Forms.Label labelNight;
        private System.Windows.Forms.Label labelDey;
        private System.Windows.Forms.MaskedTextBox TextBoxElectric_night;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_people;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TextBox_period;
    }
}

