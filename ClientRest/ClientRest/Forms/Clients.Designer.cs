namespace ClientRest.Forms
{
    partial class Clients
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
            this.ClientsCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InvoicesCB = new System.Windows.Forms.ComboBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ClientsCB
            // 
            this.ClientsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClientsCB.FormattingEnabled = true;
            this.ClientsCB.Location = new System.Drawing.Point(346, 9);
            this.ClientsCB.Name = "ClientsCB";
            this.ClientsCB.Size = new System.Drawing.Size(288, 32);
            this.ClientsCB.TabIndex = 0;
            this.ClientsCB.DropDown += new System.EventHandler(this.ClientsCB_DropDown);
            this.ClientsCB.SelectedIndexChanged += new System.EventHandler(this.ClientsCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz klienta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(269, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Faktury";
            // 
            // InvoicesCB
            // 
            this.InvoicesCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InvoicesCB.FormattingEnabled = true;
            this.InvoicesCB.Location = new System.Drawing.Point(346, 50);
            this.InvoicesCB.Name = "InvoicesCB";
            this.InvoicesCB.Size = new System.Drawing.Size(287, 32);
            this.InvoicesCB.TabIndex = 3;
            this.InvoicesCB.DropDown += new System.EventHandler(this.InvoicesCB_DropDown);
            this.InvoicesCB.SelectedIndexChanged += new System.EventHandler(this.InvoicesCB_SelectedIndexChanged);
            // 
            // Panel
            // 
            this.Panel.Location = new System.Drawing.Point(12, 88);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(955, 546);
            this.Panel.TabIndex = 4;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 646);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.InvoicesCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientsCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clients";
            this.Text = "Clients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClientsCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox InvoicesCB;
        private System.Windows.Forms.Panel Panel;
    }
}