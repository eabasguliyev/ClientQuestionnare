
namespace WinformsTask2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.DraggablePanel = new System.Windows.Forms.Panel();
            this.LeftArrowBtn = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.FirstNameTxtB = new System.Windows.Forms.TextBox();
            this.LastNameTxtB = new System.Windows.Forms.TextBox();
            this.TitleTxtB = new System.Windows.Forms.TextBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.DepartmentTxtB = new System.Windows.Forms.TextBox();
            this.DepartmentLbl = new System.Windows.Forms.Label();
            this.CompanyNameTxtB = new System.Windows.Forms.TextBox();
            this.CompanyLbl = new System.Windows.Forms.Label();
            this.IndustryTxtB = new System.Windows.Forms.TextBox();
            this.IndustryLbl = new System.Windows.Forms.Label();
            this.EmailTxtB = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.PhoneNumberMaskBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MaleRBtn = new System.Windows.Forms.RadioButton();
            this.FemaleRBtn = new System.Windows.Forms.RadioButton();
            this.OthersRBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FrenchChBox = new System.Windows.Forms.CheckBox();
            this.TurkishChBox = new System.Windows.Forms.CheckBox();
            this.RussianChBox = new System.Windows.Forms.CheckBox();
            this.EnglishChBox = new System.Windows.Forms.CheckBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.firstNameRequiredLbl = new System.Windows.Forms.Label();
            this.LastNameRequiredLbl = new System.Windows.Forms.Label();
            this.GenderRequiredLbl = new System.Windows.Forms.Label();
            this.EmailRequiredLbl = new System.Windows.Forms.Label();
            this.PhoneNumberRequiredLbl = new System.Windows.Forms.Label();
            this.FormLbl = new System.Windows.Forms.Label();
            this.DraggablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrowBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DraggablePanel
            // 
            this.DraggablePanel.BackColor = System.Drawing.Color.LightBlue;
            this.DraggablePanel.Controls.Add(this.FormLbl);
            this.DraggablePanel.Controls.Add(this.LeftArrowBtn);
            this.DraggablePanel.Controls.Add(this.CloseBtn);
            this.DraggablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DraggablePanel.Location = new System.Drawing.Point(0, 0);
            this.DraggablePanel.Name = "DraggablePanel";
            this.DraggablePanel.Size = new System.Drawing.Size(620, 32);
            this.DraggablePanel.TabIndex = 2;
            this.DraggablePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DraggablePanel_MouseDown);
            this.DraggablePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DraggablePanel_MouseMove);
            this.DraggablePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DraggablePanel_MouseUp);
            // 
            // LeftArrowBtn
            // 
            this.LeftArrowBtn.Image = ((System.Drawing.Image)(resources.GetObject("LeftArrowBtn.Image")));
            this.LeftArrowBtn.Location = new System.Drawing.Point(3, 1);
            this.LeftArrowBtn.Name = "LeftArrowBtn";
            this.LeftArrowBtn.Size = new System.Drawing.Size(34, 30);
            this.LeftArrowBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftArrowBtn.TabIndex = 2;
            this.LeftArrowBtn.TabStop = false;
            this.LeftArrowBtn.Click += new System.EventHandler(this.LeftArrowBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.Image = global::WinformsTask2.Properties.Resources.CloseImage;
            this.CloseBtn.Location = new System.Drawing.Point(581, 1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(34, 30);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameLbl.Location = new System.Drawing.Point(21, 48);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(53, 20);
            this.NameLbl.TabIndex = 3;
            this.NameLbl.Text = "Name";
            // 
            // FirstNameTxtB
            // 
            this.FirstNameTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FirstNameTxtB.ForeColor = System.Drawing.Color.Gray;
            this.FirstNameTxtB.Location = new System.Drawing.Point(24, 73);
            this.FirstNameTxtB.Multiline = true;
            this.FirstNameTxtB.Name = "FirstNameTxtB";
            this.FirstNameTxtB.Size = new System.Drawing.Size(244, 28);
            this.FirstNameTxtB.TabIndex = 4;
            this.FirstNameTxtB.Text = "First Name";
            this.FirstNameTxtB.MouseEnter += new System.EventHandler(this.FirstNameTxtB_MouseEnter);
            this.FirstNameTxtB.MouseLeave += new System.EventHandler(this.FirstNameTxtB_MouseLeave);
            // 
            // LastNameTxtB
            // 
            this.LastNameTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LastNameTxtB.ForeColor = System.Drawing.Color.Gray;
            this.LastNameTxtB.Location = new System.Drawing.Point(295, 73);
            this.LastNameTxtB.Multiline = true;
            this.LastNameTxtB.Name = "LastNameTxtB";
            this.LastNameTxtB.Size = new System.Drawing.Size(298, 28);
            this.LastNameTxtB.TabIndex = 5;
            this.LastNameTxtB.Text = "Last Name";
            this.LastNameTxtB.MouseEnter += new System.EventHandler(this.LastNameTxtB_MouseEnter);
            this.LastNameTxtB.MouseLeave += new System.EventHandler(this.LastNameTxtB_MouseLeave);
            // 
            // TitleTxtB
            // 
            this.TitleTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TitleTxtB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TitleTxtB.Location = new System.Drawing.Point(23, 271);
            this.TitleTxtB.Multiline = true;
            this.TitleTxtB.Name = "TitleTxtB";
            this.TitleTxtB.Size = new System.Drawing.Size(244, 28);
            this.TitleTxtB.TabIndex = 7;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TitleLbl.Location = new System.Drawing.Point(20, 246);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(41, 20);
            this.TitleLbl.TabIndex = 6;
            this.TitleLbl.Text = "Title";
            // 
            // DepartmentTxtB
            // 
            this.DepartmentTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DepartmentTxtB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DepartmentTxtB.Location = new System.Drawing.Point(295, 271);
            this.DepartmentTxtB.Multiline = true;
            this.DepartmentTxtB.Name = "DepartmentTxtB";
            this.DepartmentTxtB.Size = new System.Drawing.Size(298, 28);
            this.DepartmentTxtB.TabIndex = 9;
            // 
            // DepartmentLbl
            // 
            this.DepartmentLbl.AutoSize = true;
            this.DepartmentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DepartmentLbl.Location = new System.Drawing.Point(292, 246);
            this.DepartmentLbl.Name = "DepartmentLbl";
            this.DepartmentLbl.Size = new System.Drawing.Size(97, 20);
            this.DepartmentLbl.TabIndex = 8;
            this.DepartmentLbl.Text = "Department";
            // 
            // CompanyNameTxtB
            // 
            this.CompanyNameTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CompanyNameTxtB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CompanyNameTxtB.Location = new System.Drawing.Point(24, 337);
            this.CompanyNameTxtB.Multiline = true;
            this.CompanyNameTxtB.Name = "CompanyNameTxtB";
            this.CompanyNameTxtB.Size = new System.Drawing.Size(244, 28);
            this.CompanyNameTxtB.TabIndex = 11;
            // 
            // CompanyLbl
            // 
            this.CompanyLbl.AutoSize = true;
            this.CompanyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CompanyLbl.Location = new System.Drawing.Point(21, 312);
            this.CompanyLbl.Name = "CompanyLbl";
            this.CompanyLbl.Size = new System.Drawing.Size(128, 20);
            this.CompanyLbl.TabIndex = 10;
            this.CompanyLbl.Text = "Company Name";
            // 
            // IndustryTxtB
            // 
            this.IndustryTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IndustryTxtB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IndustryTxtB.Location = new System.Drawing.Point(294, 337);
            this.IndustryTxtB.Multiline = true;
            this.IndustryTxtB.Name = "IndustryTxtB";
            this.IndustryTxtB.Size = new System.Drawing.Size(298, 28);
            this.IndustryTxtB.TabIndex = 13;
            // 
            // IndustryLbl
            // 
            this.IndustryLbl.AutoSize = true;
            this.IndustryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IndustryLbl.Location = new System.Drawing.Point(291, 312);
            this.IndustryLbl.Name = "IndustryLbl";
            this.IndustryLbl.Size = new System.Drawing.Size(68, 20);
            this.IndustryLbl.TabIndex = 12;
            this.IndustryLbl.Text = "Industry";
            // 
            // EmailTxtB
            // 
            this.EmailTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmailTxtB.ForeColor = System.Drawing.Color.Gray;
            this.EmailTxtB.Location = new System.Drawing.Point(295, 141);
            this.EmailTxtB.Multiline = true;
            this.EmailTxtB.Name = "EmailTxtB";
            this.EmailTxtB.Size = new System.Drawing.Size(300, 28);
            this.EmailTxtB.TabIndex = 15;
            this.EmailTxtB.Text = "example@example.com";
            this.EmailTxtB.MouseEnter += new System.EventHandler(this.EmailTxtB_MouseEnter);
            this.EmailTxtB.MouseLeave += new System.EventHandler(this.EmailTxtB_MouseLeave);
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmailLbl.Location = new System.Drawing.Point(292, 116);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(51, 20);
            this.EmailLbl.TabIndex = 14;
            this.EmailLbl.Text = "Email";
            // 
            // PhoneNumberMaskBox
            // 
            this.PhoneNumberMaskBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PhoneNumberMaskBox.Location = new System.Drawing.Point(295, 203);
            this.PhoneNumberMaskBox.Mask = "(+000) 00-0000000";
            this.PhoneNumberMaskBox.Name = "PhoneNumberMaskBox";
            this.PhoneNumberMaskBox.Size = new System.Drawing.Size(299, 27);
            this.PhoneNumberMaskBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(292, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Phone Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MaleRBtn);
            this.groupBox1.Controls.Add(this.FemaleRBtn);
            this.groupBox1.Controls.Add(this.OthersRBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(25, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 128);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // MaleRBtn
            // 
            this.MaleRBtn.AutoSize = true;
            this.MaleRBtn.Location = new System.Drawing.Point(16, 23);
            this.MaleRBtn.Name = "MaleRBtn";
            this.MaleRBtn.Size = new System.Drawing.Size(66, 24);
            this.MaleRBtn.TabIndex = 19;
            this.MaleRBtn.TabStop = true;
            this.MaleRBtn.Text = "Male";
            this.MaleRBtn.UseVisualStyleBackColor = true;
            // 
            // FemaleRBtn
            // 
            this.FemaleRBtn.AutoSize = true;
            this.FemaleRBtn.Location = new System.Drawing.Point(16, 57);
            this.FemaleRBtn.Name = "FemaleRBtn";
            this.FemaleRBtn.Size = new System.Drawing.Size(85, 24);
            this.FemaleRBtn.TabIndex = 20;
            this.FemaleRBtn.TabStop = true;
            this.FemaleRBtn.Text = "Female";
            this.FemaleRBtn.UseVisualStyleBackColor = true;
            this.FemaleRBtn.CheckedChanged += new System.EventHandler(this.FemaleRBtn_CheckedChanged);
            // 
            // OthersRBtn
            // 
            this.OthersRBtn.AutoSize = true;
            this.OthersRBtn.Location = new System.Drawing.Point(16, 92);
            this.OthersRBtn.Name = "OthersRBtn";
            this.OthersRBtn.Size = new System.Drawing.Size(72, 24);
            this.OthersRBtn.TabIndex = 21;
            this.OthersRBtn.TabStop = true;
            this.OthersRBtn.Text = "Other";
            this.OthersRBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FrenchChBox);
            this.groupBox2.Controls.Add(this.TurkishChBox);
            this.groupBox2.Controls.Add(this.RussianChBox);
            this.groupBox2.Controls.Add(this.EnglishChBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(25, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 81);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Languages";
            // 
            // FrenchChBox
            // 
            this.FrenchChBox.AutoSize = true;
            this.FrenchChBox.Location = new System.Drawing.Point(394, 37);
            this.FrenchChBox.Name = "FrenchChBox";
            this.FrenchChBox.Size = new System.Drawing.Size(83, 24);
            this.FrenchChBox.TabIndex = 3;
            this.FrenchChBox.Text = "French";
            this.FrenchChBox.UseVisualStyleBackColor = true;
            // 
            // TurkishChBox
            // 
            this.TurkishChBox.AutoSize = true;
            this.TurkishChBox.Location = new System.Drawing.Point(272, 37);
            this.TurkishChBox.Name = "TurkishChBox";
            this.TurkishChBox.Size = new System.Drawing.Size(86, 24);
            this.TurkishChBox.TabIndex = 2;
            this.TurkishChBox.Text = "Turkish";
            this.TurkishChBox.UseVisualStyleBackColor = true;
            // 
            // RussianChBox
            // 
            this.RussianChBox.AutoSize = true;
            this.RussianChBox.Location = new System.Drawing.Point(146, 37);
            this.RussianChBox.Name = "RussianChBox";
            this.RussianChBox.Size = new System.Drawing.Size(92, 24);
            this.RussianChBox.TabIndex = 1;
            this.RussianChBox.Text = "Russian";
            this.RussianChBox.UseVisualStyleBackColor = true;
            // 
            // EnglishChBox
            // 
            this.EnglishChBox.AutoSize = true;
            this.EnglishChBox.Location = new System.Drawing.Point(16, 37);
            this.EnglishChBox.Name = "EnglishChBox";
            this.EnglishChBox.Size = new System.Drawing.Size(86, 24);
            this.EnglishChBox.TabIndex = 0;
            this.EnglishChBox.Text = "English";
            this.EnglishChBox.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveBtn.Location = new System.Drawing.Point(25, 467);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(568, 46);
            this.SaveBtn.TabIndex = 23;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // firstNameRequiredLbl
            // 
            this.firstNameRequiredLbl.AutoSize = true;
            this.firstNameRequiredLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firstNameRequiredLbl.Location = new System.Drawing.Point(268, 71);
            this.firstNameRequiredLbl.Name = "firstNameRequiredLbl";
            this.firstNameRequiredLbl.Size = new System.Drawing.Size(23, 29);
            this.firstNameRequiredLbl.TabIndex = 24;
            this.firstNameRequiredLbl.Text = "*";
            // 
            // LastNameRequiredLbl
            // 
            this.LastNameRequiredLbl.AutoSize = true;
            this.LastNameRequiredLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LastNameRequiredLbl.Location = new System.Drawing.Point(594, 73);
            this.LastNameRequiredLbl.Name = "LastNameRequiredLbl";
            this.LastNameRequiredLbl.Size = new System.Drawing.Size(23, 29);
            this.LastNameRequiredLbl.TabIndex = 25;
            this.LastNameRequiredLbl.Text = "*";
            // 
            // GenderRequiredLbl
            // 
            this.GenderRequiredLbl.AutoSize = true;
            this.GenderRequiredLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GenderRequiredLbl.Location = new System.Drawing.Point(268, 119);
            this.GenderRequiredLbl.Name = "GenderRequiredLbl";
            this.GenderRequiredLbl.Size = new System.Drawing.Size(23, 29);
            this.GenderRequiredLbl.TabIndex = 26;
            this.GenderRequiredLbl.Text = "*";
            // 
            // EmailRequiredLbl
            // 
            this.EmailRequiredLbl.AutoSize = true;
            this.EmailRequiredLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmailRequiredLbl.Location = new System.Drawing.Point(593, 140);
            this.EmailRequiredLbl.Name = "EmailRequiredLbl";
            this.EmailRequiredLbl.Size = new System.Drawing.Size(23, 29);
            this.EmailRequiredLbl.TabIndex = 27;
            this.EmailRequiredLbl.Text = "*";
            // 
            // PhoneNumberRequiredLbl
            // 
            this.PhoneNumberRequiredLbl.AutoSize = true;
            this.PhoneNumberRequiredLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PhoneNumberRequiredLbl.Location = new System.Drawing.Point(594, 202);
            this.PhoneNumberRequiredLbl.Name = "PhoneNumberRequiredLbl";
            this.PhoneNumberRequiredLbl.Size = new System.Drawing.Size(23, 29);
            this.PhoneNumberRequiredLbl.TabIndex = 28;
            this.PhoneNumberRequiredLbl.Text = "*";
            // 
            // FormLbl
            // 
            this.FormLbl.AutoSize = true;
            this.FormLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormLbl.Location = new System.Drawing.Point(43, 7);
            this.FormLbl.Name = "FormLbl";
            this.FormLbl.Size = new System.Drawing.Size(109, 20);
            this.FormLbl.TabIndex = 29;
            this.FormLbl.Text = "Questionnare";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 525);
            this.Controls.Add(this.PhoneNumberRequiredLbl);
            this.Controls.Add(this.IndustryTxtB);
            this.Controls.Add(this.CompanyNameTxtB);
            this.Controls.Add(this.TitleTxtB);
            this.Controls.Add(this.DepartmentTxtB);
            this.Controls.Add(this.PhoneNumberMaskBox);
            this.Controls.Add(this.EmailTxtB);
            this.Controls.Add(this.EmailRequiredLbl);
            this.Controls.Add(this.GenderRequiredLbl);
            this.Controls.Add(this.LastNameTxtB);
            this.Controls.Add(this.LastNameRequiredLbl);
            this.Controls.Add(this.FirstNameTxtB);
            this.Controls.Add(this.firstNameRequiredLbl);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.IndustryLbl);
            this.Controls.Add(this.CompanyLbl);
            this.Controls.Add(this.DepartmentLbl);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.DraggablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.DraggablePanel.ResumeLayout(false);
            this.DraggablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrowBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DraggablePanel;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox FirstNameTxtB;
        private System.Windows.Forms.TextBox LastNameTxtB;
        private System.Windows.Forms.PictureBox LeftArrowBtn;
        private System.Windows.Forms.TextBox TitleTxtB;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.TextBox DepartmentTxtB;
        private System.Windows.Forms.Label DepartmentLbl;
        private System.Windows.Forms.TextBox CompanyNameTxtB;
        private System.Windows.Forms.Label CompanyLbl;
        private System.Windows.Forms.TextBox IndustryTxtB;
        private System.Windows.Forms.Label IndustryLbl;
        private System.Windows.Forms.TextBox EmailTxtB;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.MaskedTextBox PhoneNumberMaskBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OthersRBtn;
        private System.Windows.Forms.RadioButton FemaleRBtn;
        private System.Windows.Forms.RadioButton MaleRBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox FrenchChBox;
        private System.Windows.Forms.CheckBox TurkishChBox;
        private System.Windows.Forms.CheckBox RussianChBox;
        private System.Windows.Forms.CheckBox EnglishChBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label firstNameRequiredLbl;
        private System.Windows.Forms.Label LastNameRequiredLbl;
        private System.Windows.Forms.Label GenderRequiredLbl;
        private System.Windows.Forms.Label EmailRequiredLbl;
        private System.Windows.Forms.Label PhoneNumberRequiredLbl;
        private System.Windows.Forms.Label FormLbl;
    }
}