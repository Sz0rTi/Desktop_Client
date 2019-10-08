namespace ClientRest.Forms
{
    partial class MainForm
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
            this.NPPanel = new System.Windows.Forms.Panel();
            this.NPButton = new System.Windows.Forms.Button();
            this.ISButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NPPanel
            // 
            this.NPPanel.Location = new System.Drawing.Point(399, 110);
            this.NPPanel.Name = "NPPanel";
            this.NPPanel.Size = new System.Drawing.Size(891, 730);
            this.NPPanel.TabIndex = 0;
            // 
            // NPButton
            // 
            this.NPButton.Location = new System.Drawing.Point(138, 189);
            this.NPButton.Name = "NPButton";
            this.NPButton.Size = new System.Drawing.Size(210, 23);
            this.NPButton.TabIndex = 1;
            this.NPButton.Text = "Nowy produkt";
            this.NPButton.UseVisualStyleBackColor = true;
            this.NPButton.Click += new System.EventHandler(this.NPButton_Click);
            // 
            // ISButton
            // 
            this.ISButton.Location = new System.Drawing.Point(138, 235);
            this.ISButton.Name = "ISButton";
            this.ISButton.Size = new System.Drawing.Size(210, 23);
            this.ISButton.TabIndex = 2;
            this.ISButton.Text = "Nowa faktura sprzedaży";
            this.ISButton.UseVisualStyleBackColor = true;
            this.ISButton.Click += new System.EventHandler(this.ISButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Lista produktów";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lista produktów";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 900);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ISButton);
            this.Controls.Add(this.NPButton);
            this.Controls.Add(this.NPPanel);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NPPanel;
        private System.Windows.Forms.Button NPButton;
        private System.Windows.Forms.Button ISButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}