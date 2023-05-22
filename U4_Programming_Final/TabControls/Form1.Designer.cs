
namespace TabControls
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.second_tab = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.lstPlayer = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMember5 = new System.Windows.Forms.TextBox();
            this.txtMember4 = new System.Windows.Forms.TextBox();
            this.txtMember3 = new System.Windows.Forms.TextBox();
            this.txtMember2 = new System.Windows.Forms.TextBox();
            this.txtMember1 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.second_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.second_tab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // second_tab
            // 
            this.second_tab.Controls.Add(this.textBox30);
            this.second_tab.Controls.Add(this.btnNext);
            this.second_tab.Controls.Add(this.lstPlayer);
            this.second_tab.Controls.Add(this.btnSave);
            this.second_tab.Controls.Add(this.txtMember5);
            this.second_tab.Controls.Add(this.txtMember4);
            this.second_tab.Controls.Add(this.txtMember3);
            this.second_tab.Controls.Add(this.txtMember2);
            this.second_tab.Controls.Add(this.txtMember1);
            this.second_tab.Controls.Add(this.textBox11);
            this.second_tab.Controls.Add(this.textBox10);
            this.second_tab.Controls.Add(this.textBox9);
            this.second_tab.Controls.Add(this.textBox8);
            this.second_tab.Controls.Add(this.txtTeam);
            this.second_tab.Controls.Add(this.textBox6);
            this.second_tab.Controls.Add(this.textBox5);
            this.second_tab.Controls.Add(this.pictureBox2);
            this.second_tab.Location = new System.Drawing.Point(4, 22);
            this.second_tab.Name = "second_tab";
            this.second_tab.Padding = new System.Windows.Forms.Padding(3);
            this.second_tab.Size = new System.Drawing.Size(768, 400);
            this.second_tab.TabIndex = 1;
            this.second_tab.Text = "Team/Members";
            this.second_tab.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(415, 337);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(72, 27);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "Next ";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lstPlayer
            // 
            this.lstPlayer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstPlayer.FormattingEnabled = true;
            this.lstPlayer.Location = new System.Drawing.Point(415, 79);
            this.lstPlayer.Name = "lstPlayer";
            this.lstPlayer.Size = new System.Drawing.Size(347, 225);
            this.lstPlayer.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(210, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 27);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Enter";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMember5
            // 
            this.txtMember5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMember5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMember5.Location = new System.Drawing.Point(210, 277);
            this.txtMember5.Multiline = true;
            this.txtMember5.Name = "txtMember5";
            this.txtMember5.Size = new System.Drawing.Size(184, 27);
            this.txtMember5.TabIndex = 14;
            this.txtMember5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMember4
            // 
            this.txtMember4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMember4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMember4.Location = new System.Drawing.Point(210, 244);
            this.txtMember4.Multiline = true;
            this.txtMember4.Name = "txtMember4";
            this.txtMember4.Size = new System.Drawing.Size(184, 27);
            this.txtMember4.TabIndex = 13;
            this.txtMember4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMember3
            // 
            this.txtMember3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMember3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMember3.Location = new System.Drawing.Point(210, 211);
            this.txtMember3.Multiline = true;
            this.txtMember3.Name = "txtMember3";
            this.txtMember3.Size = new System.Drawing.Size(184, 27);
            this.txtMember3.TabIndex = 12;
            this.txtMember3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMember2
            // 
            this.txtMember2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMember2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMember2.Location = new System.Drawing.Point(210, 178);
            this.txtMember2.Multiline = true;
            this.txtMember2.Name = "txtMember2";
            this.txtMember2.Size = new System.Drawing.Size(184, 27);
            this.txtMember2.TabIndex = 11;
            this.txtMember2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMember1
            // 
            this.txtMember1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMember1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMember1.Location = new System.Drawing.Point(210, 145);
            this.txtMember1.Multiline = true;
            this.txtMember1.Name = "txtMember1";
            this.txtMember1.Size = new System.Drawing.Size(184, 27);
            this.txtMember1.TabIndex = 10;
            this.txtMember1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(54, 244);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(119, 27);
            this.textBox11.TabIndex = 9;
            this.textBox11.Text = "Member 4";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(54, 277);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(119, 27);
            this.textBox10.TabIndex = 8;
            this.textBox10.Text = "Member 5";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(54, 211);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(119, 27);
            this.textBox9.TabIndex = 7;
            this.textBox9.Text = "Member 3";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(54, 178);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(119, 27);
            this.textBox8.TabIndex = 6;
            this.textBox8.Text = "Member 2";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTeam
            // 
            this.txtTeam.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeam.Location = new System.Drawing.Point(210, 79);
            this.txtTeam.Multiline = true;
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(184, 27);
            this.txtTeam.TabIndex = 5;
            this.txtTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(54, 145);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(119, 27);
            this.textBox6.TabIndex = 4;
            this.textBox6.Text = "Member 1";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(54, 79);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(119, 27);
            this.textBox5.TabIndex = 3;
            this.textBox5.Text = "Team Name";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TabControls.Properties.Resources.Screenshot_2023_03_02_1246371;
            this.pictureBox2.Location = new System.Drawing.Point(-4, -7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(776, 411);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // textBox30
            // 
            this.textBox30.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox30.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox30.Location = new System.Drawing.Point(125, 16);
            this.textBox30.Multiline = true;
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(119, 27);
            this.textBox30.TabIndex = 18;
            this.textBox30.Text = "Teams";
            this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.second_tab.ResumeLayout(false);
            this.second_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage second_tab;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMember5;
        private System.Windows.Forms.TextBox txtMember4;
        private System.Windows.Forms.TextBox txtMember3;
        private System.Windows.Forms.TextBox txtMember2;
        private System.Windows.Forms.TextBox txtMember1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txtTeam;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ListBox lstPlayer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox textBox30;
    }
}

