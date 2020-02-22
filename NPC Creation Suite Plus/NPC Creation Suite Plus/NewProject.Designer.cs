namespace NPC_Creation_Suite_Plus
{
    partial class NewProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.projectName = new System.Windows.Forms.TextBox();
            this.newNPC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name your project Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "[CP]";
            // 
            // projectName
            // 
            this.projectName.Location = new System.Drawing.Point(45, 33);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(117, 20);
            this.projectName.TabIndex = 2;
            // 
            // newNPC
            // 
            this.newNPC.Location = new System.Drawing.Point(63, 66);
            this.newNPC.Name = "newNPC";
            this.newNPC.Size = new System.Drawing.Size(75, 23);
            this.newNPC.TabIndex = 3;
            this.newNPC.Text = "Create";
            this.newNPC.UseVisualStyleBackColor = true;
            this.newNPC.Click += new System.EventHandler(this.NewNPC_Click);
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(207, 101);
            this.Controls.Add(this.newNPC);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewProject";
            this.Text = "NewProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox projectName;
        private System.Windows.Forms.Button newNPC;
    }
}