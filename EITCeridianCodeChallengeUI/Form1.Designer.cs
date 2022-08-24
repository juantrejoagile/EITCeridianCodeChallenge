namespace EITCeridianCodeChallengeUI
{
    partial class Form1
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
            this.txOrdering = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.lbNames = new System.Windows.Forms.ListBox();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btReorder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txOrdering
            // 
            this.txOrdering.Location = new System.Drawing.Point(181, 67);
            this.txOrdering.Name = "txOrdering";
            this.txOrdering.Size = new System.Drawing.Size(209, 26);
            this.txOrdering.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ordering";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Individual Name";
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(181, 127);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(557, 26);
            this.txName.TabIndex = 2;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(1025, 122);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 36);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "&Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lbNames
            // 
            this.lbNames.FormattingEnabled = true;
            this.lbNames.ItemHeight = 20;
            this.lbNames.Location = new System.Drawing.Point(50, 183);
            this.lbNames.Name = "lbNames";
            this.lbNames.Size = new System.Drawing.Size(500, 424);
            this.lbNames.TabIndex = 4;
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 20;
            this.lbResults.Location = new System.Drawing.Point(600, 183);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(500, 424);
            this.lbResults.TabIndex = 5;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(600, 644);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(100, 36);
            this.btClear.TabIndex = 7;
            this.btClear.Text = "&Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btReorder
            // 
            this.btReorder.Location = new System.Drawing.Point(450, 644);
            this.btReorder.Name = "btReorder";
            this.btReorder.Size = new System.Drawing.Size(100, 36);
            this.btReorder.TabIndex = 6;
            this.btReorder.Text = "&Reorder";
            this.btReorder.UseVisualStyleBackColor = true;
            this.btReorder.Click += new System.EventHandler(this.btReorder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Example: 4,2,1,3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(744, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Example: Laruen Ana Eagles Beneke";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btReorder);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.lbNames);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txOrdering);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Challenge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txOrdering;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ListBox lbNames;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btReorder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

