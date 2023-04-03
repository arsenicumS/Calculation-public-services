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
            this.groupBoxGet.Location = new System.Drawing.Point(12, 188);
            this.groupBoxGet.Name = "groupBoxGet";
            this.groupBoxGet.Size = new System.Drawing.Size(508, 250);
            this.groupBoxGet.TabIndex = 4;
            this.groupBoxGet.TabStop = false;
            this.groupBoxGet.Tag = "GroupBox_Get";
            this.groupBoxGet.Text = "Расчет по предоставленным показаниям";
            // 
            // TextBoxRezult
            // 
            this.TextBoxRezult.Location = new System.Drawing.Point(9, 19);
            this.TextBoxRezult.Name = "TextBoxRezult";
            this.TextBoxRezult.Size = new System.Drawing.Size(478, 273);
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
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

