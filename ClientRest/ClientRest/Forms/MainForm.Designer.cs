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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ISButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.InvoiceSellsButton = new System.Windows.Forms.Button();
            this.InvoiceBuysButton = new System.Windows.Forms.Button();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.IBButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.SellersButton = new System.Windows.Forms.Button();
            this.SummariesButton = new System.Windows.Forms.Button();
            this.NPPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NPPanel
            // 
            this.NPPanel.Controls.Add(this.TitleLabel);
            this.NPPanel.Location = new System.Drawing.Point(296, 53);
            this.NPPanel.Name = "NPPanel";
            this.NPPanel.Size = new System.Drawing.Size(891, 730);
            this.NPPanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleLabel.Location = new System.Drawing.Point(197, 298);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(534, 117);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Witamy w systemie fakturowania.\r\n\r\nAutor: Marcin Flisiuk\r\n";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ISButton
            // 
            this.ISButton.Location = new System.Drawing.Point(34, 53);
            this.ISButton.Name = "ISButton";
            this.ISButton.Size = new System.Drawing.Size(256, 23);
            this.ISButton.TabIndex = 2;
            this.ISButton.Text = "Nowa faktura sprzedaży";
            this.ISButton.UseVisualStyleBackColor = true;
            this.ISButton.Click += new System.EventHandler(this.ISButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lista produktów";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InvoiceSellsButton
            // 
            this.InvoiceSellsButton.Location = new System.Drawing.Point(34, 276);
            this.InvoiceSellsButton.Name = "InvoiceSellsButton";
            this.InvoiceSellsButton.Size = new System.Drawing.Size(256, 26);
            this.InvoiceSellsButton.TabIndex = 5;
            this.InvoiceSellsButton.Text = "Faktury sprzedaży";
            this.InvoiceSellsButton.UseVisualStyleBackColor = true;
            this.InvoiceSellsButton.Click += new System.EventHandler(this.InvoiceSellsButton_Click);
            // 
            // InvoiceBuysButton
            // 
            this.InvoiceBuysButton.Location = new System.Drawing.Point(34, 308);
            this.InvoiceBuysButton.Name = "InvoiceBuysButton";
            this.InvoiceBuysButton.Size = new System.Drawing.Size(256, 23);
            this.InvoiceBuysButton.TabIndex = 6;
            this.InvoiceBuysButton.Text = "Faktury zakupowe";
            this.InvoiceBuysButton.UseVisualStyleBackColor = true;
            this.InvoiceBuysButton.Click += new System.EventHandler(this.InvoiceBuysButton_Click);
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(34, 351);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(256, 433);
            this.ListBox1.TabIndex = 7;
            this.ListBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // IBButton
            // 
            this.IBButton.Location = new System.Drawing.Point(34, 82);
            this.IBButton.Name = "IBButton";
            this.IBButton.Size = new System.Drawing.Size(256, 23);
            this.IBButton.TabIndex = 3;
            this.IBButton.Text = "Nowa faktura zakupowa";
            this.IBButton.UseVisualStyleBackColor = true;
            this.IBButton.Click += new System.EventHandler(this.IBButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(1233, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 8;
            this.LogoutButton.Text = "Wyloguj";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ClientsButton
            // 
            this.ClientsButton.Location = new System.Drawing.Point(34, 162);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(256, 23);
            this.ClientsButton.TabIndex = 9;
            this.ClientsButton.Text = "Klienci";
            this.ClientsButton.UseVisualStyleBackColor = true;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // SellersButton
            // 
            this.SellersButton.Location = new System.Drawing.Point(34, 192);
            this.SellersButton.Name = "SellersButton";
            this.SellersButton.Size = new System.Drawing.Size(256, 23);
            this.SellersButton.TabIndex = 10;
            this.SellersButton.Text = "Sprzedawcy";
            this.SellersButton.UseVisualStyleBackColor = true;
            this.SellersButton.Click += new System.EventHandler(this.SellersButton_Click);
            // 
            // SummariesButton
            // 
            this.SummariesButton.Location = new System.Drawing.Point(34, 222);
            this.SummariesButton.Name = "SummariesButton";
            this.SummariesButton.Size = new System.Drawing.Size(256, 23);
            this.SummariesButton.TabIndex = 11;
            this.SummariesButton.Text = "Zestawienia";
            this.SummariesButton.UseVisualStyleBackColor = true;
            this.SummariesButton.Click += new System.EventHandler(this.SummariesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 900);
            this.Controls.Add(this.SummariesButton);
            this.Controls.Add(this.SellersButton);
            this.Controls.Add(this.ClientsButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.InvoiceBuysButton);
            this.Controls.Add(this.InvoiceSellsButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IBButton);
            this.Controls.Add(this.ISButton);
            this.Controls.Add(this.NPPanel);
            this.Name = "MainForm";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.NPPanel.ResumeLayout(false);
            this.NPPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NPPanel;
        private System.Windows.Forms.Button ISButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button InvoiceSellsButton;
        private System.Windows.Forms.Button InvoiceBuysButton;
        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.Button IBButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button ClientsButton;
        private System.Windows.Forms.Button SellersButton;
        private System.Windows.Forms.Button SummariesButton;
    }
}