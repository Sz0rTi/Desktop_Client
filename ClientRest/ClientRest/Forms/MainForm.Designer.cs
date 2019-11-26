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
            this.InvoiceSellsButton = new System.Windows.Forms.Button();
            this.InvoiceBuysButton = new System.Windows.Forms.Button();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // NPPanel
            // 
            this.NPPanel.Location = new System.Drawing.Point(333, 110);
            this.NPPanel.Name = "NPPanel";
            this.NPPanel.Size = new System.Drawing.Size(891, 730);
            this.NPPanel.TabIndex = 0;
            // 
            // NPButton
            // 
            this.NPButton.Location = new System.Drawing.Point(60, 110);
            this.NPButton.Name = "NPButton";
            this.NPButton.Size = new System.Drawing.Size(210, 23);
            this.NPButton.TabIndex = 1;
            this.NPButton.Text = "Nowy produkt";
            this.NPButton.UseVisualStyleBackColor = true;
            this.NPButton.Click += new System.EventHandler(this.NPButton_Click);
            // 
            // ISButton
            // 
            this.ISButton.Location = new System.Drawing.Point(60, 156);
            this.ISButton.Name = "ISButton";
            this.ISButton.Size = new System.Drawing.Size(210, 23);
            this.ISButton.TabIndex = 2;
            this.ISButton.Text = "Nowa faktura sprzedaży";
            this.ISButton.UseVisualStyleBackColor = true;
            this.ISButton.Click += new System.EventHandler(this.ISButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(60, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Lista produktów";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lista produktów";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InvoiceSellsButton
            // 
            this.InvoiceSellsButton.Location = new System.Drawing.Point(60, 333);
            this.InvoiceSellsButton.Name = "InvoiceSellsButton";
            this.InvoiceSellsButton.Size = new System.Drawing.Size(210, 26);
            this.InvoiceSellsButton.TabIndex = 5;
            this.InvoiceSellsButton.Text = "Faktury sprzedaży";
            this.InvoiceSellsButton.UseVisualStyleBackColor = true;
            this.InvoiceSellsButton.Click += new System.EventHandler(this.InvoiceSellsButton_Click);
            // 
            // InvoiceBuysButton
            // 
            this.InvoiceBuysButton.Location = new System.Drawing.Point(60, 365);
            this.InvoiceBuysButton.Name = "InvoiceBuysButton";
            this.InvoiceBuysButton.Size = new System.Drawing.Size(210, 23);
            this.InvoiceBuysButton.TabIndex = 6;
            this.InvoiceBuysButton.Text = "Faktury zakupowe";
            this.InvoiceBuysButton.UseVisualStyleBackColor = true;
            this.InvoiceBuysButton.Click += new System.EventHandler(this.InvoiceBuysButton_Click);
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(60, 408);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(210, 433);
            this.ListBox1.TabIndex = 7;
            this.ListBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 900);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.InvoiceBuysButton);
            this.Controls.Add(this.InvoiceSellsButton);
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
        private System.Windows.Forms.Button InvoiceSellsButton;
        private System.Windows.Forms.Button InvoiceBuysButton;
        private System.Windows.Forms.ListBox ListBox1;
    }
}