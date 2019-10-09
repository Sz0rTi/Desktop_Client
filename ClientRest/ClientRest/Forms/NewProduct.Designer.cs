namespace ClientRest.Forms
{
    partial class NewProduct
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
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.UnitCB = new System.Windows.Forms.ComboBox();
            this.PriceNUD = new System.Windows.Forms.NumericUpDown();
            this.AmountNUD = new System.Windows.Forms.NumericUpDown();
            this.AddButton = new System.Windows.Forms.Button();
            this.IsOk = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.TaxStageCB = new System.Windows.Forms.ComboBox();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryCB
            // 
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(98, 143);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(121, 21);
            this.CategoryCB.TabIndex = 1;
            this.CategoryCB.SelectedIndexChanged += new System.EventHandler(this.CategoryCB_SelectedIndexChanged);
            // 
            // UnitCB
            // 
            this.UnitCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.UnitCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UnitCB.FormattingEnabled = true;
            this.UnitCB.Location = new System.Drawing.Point(98, 197);
            this.UnitCB.Name = "UnitCB";
            this.UnitCB.Size = new System.Drawing.Size(121, 21);
            this.UnitCB.TabIndex = 2;
            this.UnitCB.SelectedIndexChanged += new System.EventHandler(this.UnitCB_SelectedIndexChanged);
            // 
            // PriceNUD
            // 
            this.PriceNUD.DecimalPlaces = 2;
            this.PriceNUD.Location = new System.Drawing.Point(98, 225);
            this.PriceNUD.Name = "PriceNUD";
            this.PriceNUD.Size = new System.Drawing.Size(120, 20);
            this.PriceNUD.TabIndex = 3;
            // 
            // AmountNUD
            // 
            this.AmountNUD.Location = new System.Drawing.Point(98, 252);
            this.AmountNUD.Name = "AmountNUD";
            this.AmountNUD.Size = new System.Drawing.Size(120, 20);
            this.AmountNUD.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(297, 199);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Dodaj";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // IsOk
            // 
            this.IsOk.AutoSize = true;
            this.IsOk.Location = new System.Drawing.Point(391, 205);
            this.IsOk.Name = "IsOk";
            this.IsOk.Size = new System.Drawing.Size(0, 13);
            this.IsOk.TabIndex = 6;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(98, 90);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(274, 20);
            this.NameTB.TabIndex = 7;
            // 
            // TaxStageCB
            // 
            this.TaxStageCB.FormattingEnabled = true;
            this.TaxStageCB.Location = new System.Drawing.Point(98, 170);
            this.TaxStageCB.Name = "TaxStageCB";
            this.TaxStageCB.Size = new System.Drawing.Size(121, 21);
            this.TaxStageCB.TabIndex = 8;
            this.TaxStageCB.SelectedIndexChanged += new System.EventHandler(this.TaxStageCB_SelectedIndexChanged);
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Location = new System.Drawing.Point(98, 117);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(274, 20);
            this.DescriptionTB.TabIndex = 9;
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.TaxStageCB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.IsOk);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AmountNUD);
            this.Controls.Add(this.PriceNUD);
            this.Controls.Add(this.UnitCB);
            this.Controls.Add(this.CategoryCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewProduct";
            this.Text = "NewProduct";
            ((System.ComponentModel.ISupportInitialize)(this.PriceNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.ComboBox UnitCB;
        private System.Windows.Forms.NumericUpDown PriceNUD;
        private System.Windows.Forms.NumericUpDown AmountNUD;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label IsOk;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.ComboBox TaxStageCB;
        private System.Windows.Forms.TextBox DescriptionTB;
    }
}