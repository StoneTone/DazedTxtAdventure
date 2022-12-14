namespace FinalProjectAS
{
    partial class worldBuild
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(worldBuild));
            this.consoleBox = new System.Windows.Forms.RichTextBox();
            this.menuButton = new System.Windows.Forms.Button();
            this.worldBuildLabel = new System.Windows.Forms.Label();
            this.nextForm = new System.Windows.Forms.Button();
            this.textScroll = new System.Windows.Forms.Timer(this.components);
            this.ActionButton2 = new System.Windows.Forms.Button();
            this.ActionButton1 = new System.Windows.Forms.Button();
            this.ActionButton3 = new System.Windows.Forms.Button();
            this.itemLabel = new System.Windows.Forms.Label();
            this.itemFade = new System.Windows.Forms.Timer(this.components);
            this.ItemButton = new System.Windows.Forms.Button();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // consoleBox
            // 
            this.consoleBox.BackColor = System.Drawing.Color.Black;
            this.consoleBox.ForeColor = System.Drawing.Color.Black;
            this.consoleBox.Location = new System.Drawing.Point(36, 12);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.Size = new System.Drawing.Size(557, 240);
            this.consoleBox.TabIndex = 3;
            this.consoleBox.Text = "";
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(0, 329);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(75, 23);
            this.menuButton.TabIndex = 4;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // worldBuildLabel
            // 
            this.worldBuildLabel.AutoSize = true;
            this.worldBuildLabel.BackColor = System.Drawing.Color.Black;
            this.worldBuildLabel.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worldBuildLabel.ForeColor = System.Drawing.Color.Lime;
            this.worldBuildLabel.Location = new System.Drawing.Point(83, 24);
            this.worldBuildLabel.Name = "worldBuildLabel";
            this.worldBuildLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.worldBuildLabel.Size = new System.Drawing.Size(0, 24);
            this.worldBuildLabel.TabIndex = 5;
            // 
            // nextForm
            // 
            this.nextForm.BackColor = System.Drawing.Color.Black;
            this.nextForm.ForeColor = System.Drawing.Color.Lime;
            this.nextForm.Location = new System.Drawing.Point(518, 229);
            this.nextForm.Name = "nextForm";
            this.nextForm.Size = new System.Drawing.Size(75, 23);
            this.nextForm.TabIndex = 6;
            this.nextForm.Text = "Next";
            this.nextForm.UseVisualStyleBackColor = false;
            this.nextForm.Click += new System.EventHandler(this.nextForm_Click);
            // 
            // textScroll
            // 
            this.textScroll.Interval = 50;
            this.textScroll.Tick += new System.EventHandler(this.textScroll_Tick);
            // 
            // ActionButton2
            // 
            this.ActionButton2.BackColor = System.Drawing.Color.Black;
            this.ActionButton2.ForeColor = System.Drawing.Color.Lime;
            this.ActionButton2.Location = new System.Drawing.Point(275, 229);
            this.ActionButton2.Name = "ActionButton2";
            this.ActionButton2.Size = new System.Drawing.Size(75, 23);
            this.ActionButton2.TabIndex = 7;
            this.ActionButton2.UseVisualStyleBackColor = false;
            this.ActionButton2.Visible = false;
            // 
            // ActionButton1
            // 
            this.ActionButton1.BackColor = System.Drawing.Color.Black;
            this.ActionButton1.ForeColor = System.Drawing.Color.Lime;
            this.ActionButton1.Location = new System.Drawing.Point(174, 229);
            this.ActionButton1.Name = "ActionButton1";
            this.ActionButton1.Size = new System.Drawing.Size(75, 23);
            this.ActionButton1.TabIndex = 8;
            this.ActionButton1.UseVisualStyleBackColor = false;
            this.ActionButton1.Visible = false;
            // 
            // ActionButton3
            // 
            this.ActionButton3.BackColor = System.Drawing.Color.Black;
            this.ActionButton3.ForeColor = System.Drawing.Color.Lime;
            this.ActionButton3.Location = new System.Drawing.Point(377, 229);
            this.ActionButton3.Name = "ActionButton3";
            this.ActionButton3.Size = new System.Drawing.Size(75, 23);
            this.ActionButton3.TabIndex = 9;
            this.ActionButton3.UseVisualStyleBackColor = false;
            this.ActionButton3.Visible = false;
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.BackColor = System.Drawing.Color.Black;
            this.itemLabel.ForeColor = System.Drawing.Color.Lime;
            this.itemLabel.Location = new System.Drawing.Point(39, 234);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(36, 13);
            this.itemLabel.TabIndex = 10;
            this.itemLabel.Text = "+ Item";
            this.itemLabel.Visible = false;
            // 
            // itemFade
            // 
            this.itemFade.Interval = 1;
            this.itemFade.Tick += new System.EventHandler(this.itemFade_Tick);
            // 
            // ItemButton
            // 
            this.ItemButton.Location = new System.Drawing.Point(557, 329);
            this.ItemButton.Name = "ItemButton";
            this.ItemButton.Size = new System.Drawing.Size(75, 23);
            this.ItemButton.TabIndex = 11;
            this.ItemButton.Text = "Inventory";
            this.ItemButton.UseVisualStyleBackColor = true;
            this.ItemButton.Click += new System.EventHandler(this.ItemButton_Click);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(261, 203);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeTextBox.TabIndex = 12;
            this.codeTextBox.Visible = false;
            // 
            // worldBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 353);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.ItemButton);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.ActionButton3);
            this.Controls.Add(this.ActionButton1);
            this.Controls.Add(this.ActionButton2);
            this.Controls.Add(this.nextForm);
            this.Controls.Add(this.worldBuildLabel);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.consoleBox);
            this.Name = "worldBuild";
            this.Text = "Slab";
            this.Load += new System.EventHandler(this.worldBuild_Load);
            this.Click += new System.EventHandler(this.worldBuild_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox consoleBox;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label worldBuildLabel;
        private System.Windows.Forms.Button nextForm;
        private System.Windows.Forms.Timer textScroll;
        private System.Windows.Forms.Button ActionButton2;
        private System.Windows.Forms.Button ActionButton1;
        private System.Windows.Forms.Button ActionButton3;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Timer itemFade;
        private System.Windows.Forms.Button ItemButton;
        private System.Windows.Forms.TextBox codeTextBox;
    }
}