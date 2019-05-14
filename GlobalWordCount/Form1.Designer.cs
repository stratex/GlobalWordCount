namespace GlobalWordCount
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckWindows = new System.Windows.Forms.CheckBox();
            this.ckShift = new System.Windows.Forms.CheckBox();
            this.ckControl = new System.Windows.Forms.CheckBox();
            this.ckAlt = new System.Windows.Forms.CheckBox();
            this.txtChar = new System.Windows.Forms.TextBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckWindows);
            this.groupBox1.Controls.Add(this.ckShift);
            this.groupBox1.Controls.Add(this.ckControl);
            this.groupBox1.Controls.Add(this.ckAlt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifiers";
            // 
            // ckWindows
            // 
            this.ckWindows.AutoSize = true;
            this.ckWindows.Location = new System.Drawing.Point(7, 88);
            this.ckWindows.Name = "ckWindows";
            this.ckWindows.Size = new System.Drawing.Size(70, 17);
            this.ckWindows.TabIndex = 3;
            this.ckWindows.Text = "Windows";
            this.ckWindows.UseVisualStyleBackColor = true;
            // 
            // ckShift
            // 
            this.ckShift.AutoSize = true;
            this.ckShift.Location = new System.Drawing.Point(7, 65);
            this.ckShift.Name = "ckShift";
            this.ckShift.Size = new System.Drawing.Size(47, 17);
            this.ckShift.TabIndex = 2;
            this.ckShift.Text = "Shift";
            this.ckShift.UseVisualStyleBackColor = true;
            // 
            // ckControl
            // 
            this.ckControl.AutoSize = true;
            this.ckControl.Location = new System.Drawing.Point(6, 42);
            this.ckControl.Name = "ckControl";
            this.ckControl.Size = new System.Drawing.Size(59, 17);
            this.ckControl.TabIndex = 1;
            this.ckControl.Text = "Control";
            this.ckControl.UseVisualStyleBackColor = true;
            // 
            // ckAlt
            // 
            this.ckAlt.AutoSize = true;
            this.ckAlt.Location = new System.Drawing.Point(6, 19);
            this.ckAlt.Name = "ckAlt";
            this.ckAlt.Size = new System.Drawing.Size(38, 17);
            this.ckAlt.TabIndex = 0;
            this.ckAlt.Text = "Alt";
            this.ckAlt.UseVisualStyleBackColor = true;
            // 
            // txtChar
            // 
            this.txtChar.Location = new System.Drawing.Point(12, 132);
            this.txtChar.MaxLength = 1;
            this.txtChar.Name = "txtChar";
            this.txtChar.Size = new System.Drawing.Size(44, 20);
            this.txtChar.TabIndex = 1;
            this.txtChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChar.TextChanged += new System.EventHandler(this.TxtChar_TextChanged);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(62, 130);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(184, 23);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "Testing";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 161);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.txtChar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Word Count";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckWindows;
        private System.Windows.Forms.CheckBox ckShift;
        private System.Windows.Forms.CheckBox ckControl;
        private System.Windows.Forms.CheckBox ckAlt;
        private System.Windows.Forms.TextBox txtChar;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

