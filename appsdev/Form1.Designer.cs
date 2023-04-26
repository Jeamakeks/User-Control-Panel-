namespace appsdev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelOne = new System.Windows.Forms.Button();
            this.panelTwo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inputOne = new System.Windows.Forms.TextBox();
            this.inputTwo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Two1 = new appsdev.Panel_Two();
            this.panel_One1 = new appsdev.Panel_One();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelOne);
            this.panel1.Controls.Add(this.panelTwo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 507);
            this.panel1.TabIndex = 0;
            // 
            // panelOne
            // 
            this.panelOne.Location = new System.Drawing.Point(57, 143);
            this.panelOne.Name = "panelOne";
            this.panelOne.Size = new System.Drawing.Size(75, 30);
            this.panelOne.TabIndex = 4;
            this.panelOne.Text = "Panel One";
            this.panelOne.UseVisualStyleBackColor = true;
            this.panelOne.Click += new System.EventHandler(this.panelOne_Click);
            // 
            // panelTwo
            // 
            this.panelTwo.Location = new System.Drawing.Point(57, 225);
            this.panelTwo.Name = "panelTwo";
            this.panelTwo.Size = new System.Drawing.Size(75, 30);
            this.panelTwo.TabIndex = 5;
            this.panelTwo.Text = "Panel Two";
            this.panelTwo.UseVisualStyleBackColor = true;
            this.panelTwo.Click += new System.EventHandler(this.panelTwo_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.inputOne);
            this.panel2.Controls.Add(this.inputTwo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(729, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 507);
            this.panel2.TabIndex = 0;
            // 
            // inputOne
            // 
            this.inputOne.Location = new System.Drawing.Point(16, 160);
            this.inputOne.Name = "inputOne";
            this.inputOne.Size = new System.Drawing.Size(144, 23);
            this.inputOne.TabIndex = 1;
            // 
            // inputTwo
            // 
            this.inputTwo.Location = new System.Drawing.Point(16, 264);
            this.inputTwo.Name = "inputTwo";
            this.inputTwo.Size = new System.Drawing.Size(144, 23);
            this.inputTwo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input One:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Input Two:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(217, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Control Panel Application";
            // 
            // panel_Two1
            // 
            this.panel_Two1.BackColor = System.Drawing.Color.Moccasin;
            this.panel_Two1.Location = new System.Drawing.Point(206, 66);
            this.panel_Two1.Name = "panel_Two1";
            this.panel_Two1.Size = new System.Drawing.Size(517, 429);
            this.panel_Two1.TabIndex = 1;
            // 
            // panel_One1
            // 
            this.panel_One1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel_One1.Location = new System.Drawing.Point(206, 66);
            this.panel_One1.Name = "panel_One1";
            this.panel_One1.Size = new System.Drawing.Size(517, 429);
            this.panel_One1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 507);
            this.Controls.Add(this.panel_One1);
            this.Controls.Add(this.panel_Two1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button panelOne;
        private Button panelTwo;
        private Panel panel2;
        private TextBox inputOne;
        private TextBox inputTwo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private Panel_Two panel_Two1;
        private Panel_One panel_One1;
    }
}