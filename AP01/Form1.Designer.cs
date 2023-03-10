
namespace AP01
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProcessName = new System.Windows.Forms.Label();
            this.ProcessNameSave = new System.Windows.Forms.Button();
            this.EnableAllerts = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CheckInterval = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.LastTimeSeen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(86, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "NOT RUNNING";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(247)))));
            this.label3.Location = new System.Drawing.Point(86, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "NONE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.label2.Location = new System.Drawing.Point(8, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.label1.Location = new System.Drawing.Point(8, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Process:";
            // 
            // ProcessName
            // 
            this.ProcessName.AutoSize = true;
            this.ProcessName.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Bold);
            this.ProcessName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.ProcessName.Location = new System.Drawing.Point(12, 17);
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.Size = new System.Drawing.Size(94, 24);
            this.ProcessName.TabIndex = 1;
            this.ProcessName.Text = "Process Name";
            // 
            // ProcessNameSave
            // 
            this.ProcessNameSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(60)))), ((int)(((byte)(94)))));
            this.ProcessNameSave.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ProcessNameSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessNameSave.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.ProcessNameSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(247)))));
            this.ProcessNameSave.Location = new System.Drawing.Point(241, 44);
            this.ProcessNameSave.Margin = new System.Windows.Forms.Padding(0);
            this.ProcessNameSave.Name = "ProcessNameSave";
            this.ProcessNameSave.Size = new System.Drawing.Size(77, 27);
            this.ProcessNameSave.TabIndex = 3;
            this.ProcessNameSave.Text = "Save";
            this.ProcessNameSave.UseVisualStyleBackColor = false;
            this.ProcessNameSave.Click += new System.EventHandler(this.ProcessNameSave_Click);
            // 
            // EnableAllerts
            // 
            this.EnableAllerts.AutoSize = true;
            this.EnableAllerts.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Bold);
            this.EnableAllerts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(247)))));
            this.EnableAllerts.Location = new System.Drawing.Point(241, 86);
            this.EnableAllerts.Name = "EnableAllerts";
            this.EnableAllerts.Size = new System.Drawing.Size(114, 28);
            this.EnableAllerts.TabIndex = 4;
            this.EnableAllerts.Text = "Enable Allerts";
            this.EnableAllerts.UseVisualStyleBackColor = true;
            this.EnableAllerts.CheckedChanged += new System.EventHandler(this.EnableAllerts_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(60)))), ((int)(((byte)(94)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Font = new System.Drawing.Font("Dubai", 9.5F, System.Drawing.FontStyle.Bold);
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(247)))));
            this.richTextBox1.Location = new System.Drawing.Point(13, 3);
            this.richTextBox1.MaxLength = 10;
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(53, 21);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "1000";
            // 
            // CheckInterval
            // 
            this.CheckInterval.AutoSize = true;
            this.CheckInterval.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Bold);
            this.CheckInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.CheckInterval.Location = new System.Drawing.Point(8, 89);
            this.CheckInterval.Name = "CheckInterval";
            this.CheckInterval.Size = new System.Drawing.Size(126, 24);
            this.CheckInterval.TabIndex = 7;
            this.CheckInterval.Text = "Check Interval (ms)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(60)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(140, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 27);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(60)))), ((int)(((byte)(94)))));
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(12, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 27);
            this.panel3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.label5.Location = new System.Drawing.Point(8, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Last time running:";
            // 
            // LastTimeSeen
            // 
            this.LastTimeSeen.AutoSize = true;
            this.LastTimeSeen.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Bold);
            this.LastTimeSeen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(247)))));
            this.LastTimeSeen.Location = new System.Drawing.Point(133, 188);
            this.LastTimeSeen.Name = "LastTimeSeen";
            this.LastTimeSeen.Size = new System.Drawing.Size(37, 24);
            this.LastTimeSeen.TabIndex = 14;
            this.LastTimeSeen.Text = "8:01";
            this.LastTimeSeen.MouseLeave += new System.EventHandler(this.LastTimeSeen_MouseLeave);
            this.LastTimeSeen.MouseHover += new System.EventHandler(this.LastTimeSeen_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(336, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(60)))), ((int)(((byte)(94)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Dubai", 9.5F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(247)))));
            this.textBox1.Location = new System.Drawing.Point(13, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 22);
            this.textBox1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.label6.Location = new System.Drawing.Point(238, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Beep system sound";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(372, 233);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastTimeSeen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CheckInterval);
            this.Controls.Add(this.EnableAllerts);
            this.Controls.Add(this.ProcessNameSave);
            this.Controls.Add(this.ProcessName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ProcessName;
        private System.Windows.Forms.Button ProcessNameSave;
        private System.Windows.Forms.CheckBox EnableAllerts;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label CheckInterval;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LastTimeSeen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}

