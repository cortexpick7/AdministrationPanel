namespace AdministrationPanel.Forms
{
    partial class AddForm
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
            this.productNameTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categories = new System.Windows.Forms.ComboBox();
            this.quantityTB = new System.Windows.Forms.TextBox();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productNameTB
            // 
            this.productNameTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.productNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productNameTB.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.productNameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.productNameTB.Location = new System.Drawing.Point(71, 41);
            this.productNameTB.Name = "productNameTB";
            this.productNameTB.Size = new System.Drawing.Size(171, 23);
            this.productNameTB.TabIndex = 0;
            this.productNameTB.TextChanged += new System.EventHandler(this.productNameTB_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(199)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.createButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.categories);
            this.panel1.Controls.Add(this.quantityTB);
            this.panel1.Controls.Add(this.priceTB);
            this.panel1.Controls.Add(this.productNameTB);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(236, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 344);
            this.panel1.TabIndex = 4;
            // 
            // createButton
            // 
            this.createButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.createButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createButton.Enabled = false;
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.createButton.ForeColor = System.Drawing.SystemColors.Window;
            this.createButton.Location = new System.Drawing.Point(71, 272);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(171, 48);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Create new item";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(67, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(67, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity in stock";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(67, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(67, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product name";
            // 
            // categories
            // 
            this.categories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categories.Font = new System.Drawing.Font("Myriad Pro", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.categories.FormattingEnabled = true;
            this.categories.Items.AddRange(new object[] {
            "Add new..."});
            this.categories.Location = new System.Drawing.Point(71, 216);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(171, 28);
            this.categories.TabIndex = 3;
            this.categories.SelectedIndexChanged += new System.EventHandler(this.categories_SelectedIndexChanged);
            this.categories.TextUpdate += new System.EventHandler(this.categories_TextUpdate);
            // 
            // quantityTB
            // 
            this.quantityTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantityTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.quantityTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTB.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.quantityTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.quantityTB.Location = new System.Drawing.Point(71, 157);
            this.quantityTB.Name = "quantityTB";
            this.quantityTB.Size = new System.Drawing.Size(171, 23);
            this.quantityTB.TabIndex = 2;
            this.quantityTB.TextChanged += new System.EventHandler(this.quantityTB_TextChanged);
            this.quantityTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTB_KeyPress);
            // 
            // priceTB
            // 
            this.priceTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.priceTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTB.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.priceTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.priceTB.Location = new System.Drawing.Point(71, 98);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(171, 23);
            this.priceTB.TabIndex = 1;
            this.priceTB.TextChanged += new System.EventHandler(this.priceTB_TextChanged);
            this.priceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTB_KeyPress);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox productNameTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox categories;
        private System.Windows.Forms.TextBox quantityTB;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createButton;
    }
}