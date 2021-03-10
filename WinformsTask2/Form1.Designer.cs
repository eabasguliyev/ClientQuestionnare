
namespace WinformsTask2
{
    partial class Form1
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
            this.DraggablePanel = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.WorkersComboBox = new System.Windows.Forms.ComboBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.DraggablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // DraggablePanel
            // 
            this.DraggablePanel.BackColor = System.Drawing.Color.LightBlue;
            this.DraggablePanel.Controls.Add(this.CloseBtn);
            this.DraggablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DraggablePanel.Location = new System.Drawing.Point(0, 0);
            this.DraggablePanel.Name = "DraggablePanel";
            this.DraggablePanel.Size = new System.Drawing.Size(344, 32);
            this.DraggablePanel.TabIndex = 1;
            this.DraggablePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DraggablePanel_MouseDown);
            this.DraggablePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DraggablePanel_MouseMove);
            this.DraggablePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DraggablePanel_MouseUp);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.Image = global::WinformsTask2.Properties.Resources.CloseImage;
            this.CloseBtn.Location = new System.Drawing.Point(305, 1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(34, 30);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LoadBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoadBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.LoadBtn.Location = new System.Drawing.Point(36, 118);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(135, 46);
            this.LoadBtn.TabIndex = 12;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            this.LoadBtn.MouseEnter += new System.EventHandler(this.LoadBtn_MouseEnter);
            this.LoadBtn.MouseLeave += new System.EventHandler(this.LoadBtn_MouseLeave);
            // 
            // WorkersComboBox
            // 
            this.WorkersComboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.WorkersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkersComboBox.FormattingEnabled = true;
            this.WorkersComboBox.Items.AddRange(new object[] {
            "Elgun Abasquliyev",
            "Resul Osmanli",
            "Abil Yaqublu"});
            this.WorkersComboBox.Location = new System.Drawing.Point(36, 75);
            this.WorkersComboBox.Name = "WorkersComboBox";
            this.WorkersComboBox.Size = new System.Drawing.Size(275, 24);
            this.WorkersComboBox.TabIndex = 11;
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CreateBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CreateBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.CreateBtn.Location = new System.Drawing.Point(176, 118);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(135, 46);
            this.CreateBtn.TabIndex = 13;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            this.CreateBtn.MouseEnter += new System.EventHandler(this.CreateBtn_MouseEnter);
            this.CreateBtn.MouseLeave += new System.EventHandler(this.CreateBtn_MouseLeave);
            // 
            // Form1
            // 
            this.AcceptButton = this.LoadBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 189);
            this.Controls.Add(this.WorkersComboBox);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.DraggablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(200, 80);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DraggablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.Panel DraggablePanel;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.ComboBox WorkersComboBox;
        private System.Windows.Forms.Button CreateBtn;
    }
}

