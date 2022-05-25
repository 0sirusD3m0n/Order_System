
namespace Final_Project
{
    partial class OrderForm
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
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.subButton = new System.Windows.Forms.RadioButton();
            this.hamburgerButton = new System.Windows.Forms.RadioButton();
            this.hamburgerPanel = new System.Windows.Forms.Panel();
            this.condomentsLB = new System.Windows.Forms.CheckedListBox();
            this.toppingsList = new System.Windows.Forms.CheckedListBox();
            this.hNameTB = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.hCheeseCB = new System.Windows.Forms.ComboBox();
            this.cheeseLabel = new System.Windows.Forms.Label();
            this.meatLabel = new System.Windows.Forms.Label();
            this.meatSelection = new System.Windows.Forms.ComboBox();
            this.subPanel = new System.Windows.Forms.Panel();
            this.sCondimentsLB = new System.Windows.Forms.CheckedListBox();
            this.sLB = new System.Windows.Forms.CheckedListBox();
            this.sCheeseCB = new System.Windows.Forms.ComboBox();
            this.sCheeseLabel = new System.Windows.Forms.Label();
            this.meatSelectCB = new System.Windows.Forms.ComboBox();
            this.sMeatLabel = new System.Windows.Forms.Label();
            this.sNameTB = new System.Windows.Forms.TextBox();
            this.sNameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveCancelPanel = new System.Windows.Forms.Panel();
            this.buttonPanel.SuspendLayout();
            this.hamburgerPanel.SuspendLayout();
            this.subPanel.SuspendLayout();
            this.saveCancelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.buttonPanel.Controls.Add(this.subButton);
            this.buttonPanel.Controls.Add(this.hamburgerButton);
            this.buttonPanel.Location = new System.Drawing.Point(50, 12);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(360, 92);
            this.buttonPanel.TabIndex = 0;
            // 
            // subButton
            // 
            this.subButton.AutoSize = true;
            this.subButton.Location = new System.Drawing.Point(229, 33);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(44, 17);
            this.subButton.TabIndex = 1;
            this.subButton.Text = "Sub";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.CheckedChanged += new System.EventHandler(this.subButton_CheckedChanged);
            // 
            // hamburgerButton
            // 
            this.hamburgerButton.AutoSize = true;
            this.hamburgerButton.Location = new System.Drawing.Point(51, 33);
            this.hamburgerButton.Name = "hamburgerButton";
            this.hamburgerButton.Size = new System.Drawing.Size(77, 17);
            this.hamburgerButton.TabIndex = 0;
            this.hamburgerButton.Text = "Hamburger";
            this.hamburgerButton.UseVisualStyleBackColor = true;
            this.hamburgerButton.CheckedChanged += new System.EventHandler(this.hamburgerButton_CheckedChanged);
            // 
            // hamburgerPanel
            // 
            this.hamburgerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hamburgerPanel.Controls.Add(this.condomentsLB);
            this.hamburgerPanel.Controls.Add(this.toppingsList);
            this.hamburgerPanel.Controls.Add(this.hNameTB);
            this.hamburgerPanel.Controls.Add(this.nameLabel);
            this.hamburgerPanel.Controls.Add(this.hCheeseCB);
            this.hamburgerPanel.Controls.Add(this.cheeseLabel);
            this.hamburgerPanel.Controls.Add(this.meatLabel);
            this.hamburgerPanel.Controls.Add(this.meatSelection);
            this.hamburgerPanel.Location = new System.Drawing.Point(50, 159);
            this.hamburgerPanel.Name = "hamburgerPanel";
            this.hamburgerPanel.Size = new System.Drawing.Size(360, 217);
            this.hamburgerPanel.TabIndex = 1;
            this.hamburgerPanel.Visible = false;
            // 
            // condomentsLB
            // 
            this.condomentsLB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.condomentsLB.CheckOnClick = true;
            this.condomentsLB.FormattingEnabled = true;
            this.condomentsLB.Items.AddRange(new object[] {
            "Ketchup",
            "Mustard",
            "Mayo"});
            this.condomentsLB.Location = new System.Drawing.Point(219, 129);
            this.condomentsLB.Name = "condomentsLB";
            this.condomentsLB.Size = new System.Drawing.Size(89, 64);
            this.condomentsLB.TabIndex = 7;
            // 
            // toppingsList
            // 
            this.toppingsList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toppingsList.CheckOnClick = true;
            this.toppingsList.FormattingEnabled = true;
            this.toppingsList.Items.AddRange(new object[] {
            "Bacon (Extra Charge)",
            "Lettuce",
            "Tomato",
            "Onion"});
            this.toppingsList.Location = new System.Drawing.Point(60, 129);
            this.toppingsList.Name = "toppingsList";
            this.toppingsList.Size = new System.Drawing.Size(150, 64);
            this.toppingsList.TabIndex = 6;
            // 
            // hNameTB
            // 
            this.hNameTB.Location = new System.Drawing.Point(112, 12);
            this.hNameTB.Name = "hNameTB";
            this.hNameTB.Size = new System.Drawing.Size(196, 20);
            this.hNameTB.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(68, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // hCheeseCB
            // 
            this.hCheeseCB.FormattingEnabled = true;
            this.hCheeseCB.Items.AddRange(new object[] {
            "American",
            "Provolone",
            "Swiss",
            "Pepper Jack"});
            this.hCheeseCB.Location = new System.Drawing.Point(112, 83);
            this.hCheeseCB.Name = "hCheeseCB";
            this.hCheeseCB.Size = new System.Drawing.Size(196, 21);
            this.hCheeseCB.TabIndex = 3;
            // 
            // cheeseLabel
            // 
            this.cheeseLabel.AutoSize = true;
            this.cheeseLabel.Location = new System.Drawing.Point(60, 86);
            this.cheeseLabel.Name = "cheeseLabel";
            this.cheeseLabel.Size = new System.Drawing.Size(46, 13);
            this.cheeseLabel.TabIndex = 2;
            this.cheeseLabel.Text = "Cheese:";
            // 
            // meatLabel
            // 
            this.meatLabel.AutoSize = true;
            this.meatLabel.Location = new System.Drawing.Point(76, 50);
            this.meatLabel.Name = "meatLabel";
            this.meatLabel.Size = new System.Drawing.Size(30, 13);
            this.meatLabel.TabIndex = 1;
            this.meatLabel.Text = "Size:";
            // 
            // meatSelection
            // 
            this.meatSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.meatSelection.FormattingEnabled = true;
            this.meatSelection.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.meatSelection.Location = new System.Drawing.Point(112, 47);
            this.meatSelection.Name = "meatSelection";
            this.meatSelection.Size = new System.Drawing.Size(196, 21);
            this.meatSelection.TabIndex = 0;
            // 
            // subPanel
            // 
            this.subPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subPanel.Controls.Add(this.sCondimentsLB);
            this.subPanel.Controls.Add(this.sLB);
            this.subPanel.Controls.Add(this.sCheeseCB);
            this.subPanel.Controls.Add(this.sCheeseLabel);
            this.subPanel.Controls.Add(this.meatSelectCB);
            this.subPanel.Controls.Add(this.sMeatLabel);
            this.subPanel.Controls.Add(this.sNameTB);
            this.subPanel.Controls.Add(this.sNameLabel);
            this.subPanel.Location = new System.Drawing.Point(50, 159);
            this.subPanel.Name = "subPanel";
            this.subPanel.Size = new System.Drawing.Size(360, 217);
            this.subPanel.TabIndex = 2;
            this.subPanel.Visible = false;
            // 
            // sCondimentsLB
            // 
            this.sCondimentsLB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sCondimentsLB.CheckOnClick = true;
            this.sCondimentsLB.FormattingEnabled = true;
            this.sCondimentsLB.Items.AddRange(new object[] {
            "Mayo",
            "Mustard",
            "Vinaigrette"});
            this.sCondimentsLB.Location = new System.Drawing.Point(221, 114);
            this.sCondimentsLB.Name = "sCondimentsLB";
            this.sCondimentsLB.Size = new System.Drawing.Size(89, 64);
            this.sCondimentsLB.TabIndex = 7;
            // 
            // sLB
            // 
            this.sLB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sLB.CheckOnClick = true;
            this.sLB.FormattingEnabled = true;
            this.sLB.Items.AddRange(new object[] {
            "Lettuce",
            "Tomato",
            "Onion",
            "Pickle"});
            this.sLB.Location = new System.Drawing.Point(62, 114);
            this.sLB.Name = "sLB";
            this.sLB.Size = new System.Drawing.Size(150, 64);
            this.sLB.TabIndex = 6;
            // 
            // sCheeseCB
            // 
            this.sCheeseCB.FormattingEnabled = true;
            this.sCheeseCB.Items.AddRange(new object[] {
            "American",
            "Provolone",
            "Swiss",
            "Pepper Jack"});
            this.sCheeseCB.Location = new System.Drawing.Point(114, 87);
            this.sCheeseCB.Name = "sCheeseCB";
            this.sCheeseCB.Size = new System.Drawing.Size(196, 21);
            this.sCheeseCB.TabIndex = 5;
            // 
            // sCheeseLabel
            // 
            this.sCheeseLabel.AutoSize = true;
            this.sCheeseLabel.Location = new System.Drawing.Point(62, 90);
            this.sCheeseLabel.Name = "sCheeseLabel";
            this.sCheeseLabel.Size = new System.Drawing.Size(46, 13);
            this.sCheeseLabel.TabIndex = 4;
            this.sCheeseLabel.Text = "Cheese:";
            // 
            // meatSelectCB
            // 
            this.meatSelectCB.FormattingEnabled = true;
            this.meatSelectCB.Items.AddRange(new object[] {
            "Roast Beef",
            "Sliced Chicken",
            "Oven Roasted Turkey",
            "Honey Baked Ham"});
            this.meatSelectCB.Location = new System.Drawing.Point(114, 49);
            this.meatSelectCB.Name = "meatSelectCB";
            this.meatSelectCB.Size = new System.Drawing.Size(196, 21);
            this.meatSelectCB.TabIndex = 3;
            // 
            // sMeatLabel
            // 
            this.sMeatLabel.AutoSize = true;
            this.sMeatLabel.Location = new System.Drawing.Point(74, 52);
            this.sMeatLabel.Name = "sMeatLabel";
            this.sMeatLabel.Size = new System.Drawing.Size(34, 13);
            this.sMeatLabel.TabIndex = 2;
            this.sMeatLabel.Text = "Meat:";
            // 
            // sNameTB
            // 
            this.sNameTB.Location = new System.Drawing.Point(114, 13);
            this.sNameTB.Name = "sNameTB";
            this.sNameTB.Size = new System.Drawing.Size(196, 20);
            this.sNameTB.TabIndex = 1;
            // 
            // sNameLabel
            // 
            this.sNameLabel.AutoSize = true;
            this.sNameLabel.Location = new System.Drawing.Point(70, 16);
            this.sNameLabel.Name = "sNameLabel";
            this.sNameLabel.Size = new System.Drawing.Size(38, 13);
            this.sNameLabel.TabIndex = 0;
            this.sNameLabel.Text = "Name:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(33, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(63, 29);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(248, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(62, 29);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveCancelPanel
            // 
            this.saveCancelPanel.Controls.Add(this.saveButton);
            this.saveCancelPanel.Controls.Add(this.cancelButton);
            this.saveCancelPanel.Location = new System.Drawing.Point(50, 397);
            this.saveCancelPanel.Name = "saveCancelPanel";
            this.saveCancelPanel.Size = new System.Drawing.Size(360, 34);
            this.saveCancelPanel.TabIndex = 5;
            this.saveCancelPanel.Visible = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 510);
            this.Controls.Add(this.saveCancelPanel);
            this.Controls.Add(this.subPanel);
            this.Controls.Add(this.hamburgerPanel);
            this.Controls.Add(this.buttonPanel);
            this.Name = "OrderForm";
            this.Text = "Form1";
            this.buttonPanel.ResumeLayout(false);
            this.buttonPanel.PerformLayout();
            this.hamburgerPanel.ResumeLayout(false);
            this.hamburgerPanel.PerformLayout();
            this.subPanel.ResumeLayout(false);
            this.subPanel.PerformLayout();
            this.saveCancelPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.RadioButton subButton;
        private System.Windows.Forms.RadioButton hamburgerButton;
        private System.Windows.Forms.Panel hamburgerPanel;
        private System.Windows.Forms.ComboBox meatSelection;
        private System.Windows.Forms.Label meatLabel;
        private System.Windows.Forms.CheckedListBox condomentsLB;
        private System.Windows.Forms.CheckedListBox toppingsList;
        private System.Windows.Forms.TextBox hNameTB;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox hCheeseCB;
        private System.Windows.Forms.Label cheeseLabel;
        private System.Windows.Forms.Panel subPanel;
        private System.Windows.Forms.CheckedListBox sCondimentsLB;
        private System.Windows.Forms.CheckedListBox sLB;
        private System.Windows.Forms.ComboBox sCheeseCB;
        private System.Windows.Forms.Label sCheeseLabel;
        private System.Windows.Forms.ComboBox meatSelectCB;
        private System.Windows.Forms.Label sMeatLabel;
        private System.Windows.Forms.TextBox sNameTB;
        private System.Windows.Forms.Label sNameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel saveCancelPanel;
    }
}