namespace FinalProjectAS
{
    partial class descriptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(descriptionForm));
            this.menuButton = new System.Windows.Forms.Button();
            this.consoleBox = new System.Windows.Forms.RichTextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.textScroll = new System.Windows.Forms.Timer(this.components);
            this.nextForm = new System.Windows.Forms.Button();
            this.glLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(0, 329);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(75, 23);
            this.menuButton.TabIndex = 1;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // consoleBox
            // 
            this.consoleBox.BackColor = System.Drawing.Color.Black;
            this.consoleBox.ForeColor = System.Drawing.Color.Black;
            this.consoleBox.Location = new System.Drawing.Point(36, 12);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.Size = new System.Drawing.Size(557, 240);
            this.consoleBox.TabIndex = 2;
            this.consoleBox.Text = "";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Black;
            this.welcomeLabel.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Lime;
            this.welcomeLabel.Location = new System.Drawing.Point(83, 34);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(0, 24);
            this.welcomeLabel.TabIndex = 3;
            // 
            // textScroll
            // 
            this.textScroll.Interval = 60;
            this.textScroll.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nextForm
            // 
            this.nextForm.BackColor = System.Drawing.Color.Black;
            this.nextForm.ForeColor = System.Drawing.Color.Lime;
            this.nextForm.Location = new System.Drawing.Point(518, 229);
            this.nextForm.Name = "nextForm";
            this.nextForm.Size = new System.Drawing.Size(75, 23);
            this.nextForm.TabIndex = 4;
            this.nextForm.Text = "Next";
            this.nextForm.UseVisualStyleBackColor = false;
            this.nextForm.Click += new System.EventHandler(this.nextForm_Click);
            // 
            // glLabel
            // 
            this.glLabel.AutoSize = true;
            this.glLabel.BackColor = System.Drawing.Color.Black;
            this.glLabel.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glLabel.ForeColor = System.Drawing.Color.Lime;
            this.glLabel.Location = new System.Drawing.Point(269, 171);
            this.glLabel.Name = "glLabel";
            this.glLabel.Size = new System.Drawing.Size(78, 24);
            this.glLabel.TabIndex = 5;
            this.glLabel.Text = "Goodluck!";
            // 
            // descriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 353);
            this.Controls.Add(this.glLabel);
            this.Controls.Add(this.nextForm);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.menuButton);
            this.Name = "descriptionForm";
            this.Text = "Description";
            this.Load += new System.EventHandler(this.descriptionForm_Load);
            this.Click += new System.EventHandler(this.descriptionForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.RichTextBox consoleBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Timer textScroll;
        private System.Windows.Forms.Button nextForm;
        private System.Windows.Forms.Label glLabel;
    }
}