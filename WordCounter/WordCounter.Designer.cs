
namespace WordCounter
{
    partial class WordCounterForm
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
            this.countWordsBtn = new System.Windows.Forms.Button();
            this.sentenceTxtBox = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.numberOfWordsLabel = new System.Windows.Forms.Label();
            this.numberOfWordCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countWordsBtn
            // 
            this.countWordsBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countWordsBtn.Location = new System.Drawing.Point(290, 283);
            this.countWordsBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.countWordsBtn.Name = "countWordsBtn";
            this.countWordsBtn.Size = new System.Drawing.Size(365, 75);
            this.countWordsBtn.TabIndex = 0;
            this.countWordsBtn.Text = "Count Words!";
            this.countWordsBtn.UseVisualStyleBackColor = true;
            // 
            // sentenceTxtBox
            // 
            this.sentenceTxtBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentenceTxtBox.Location = new System.Drawing.Point(88, 181);
            this.sentenceTxtBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.sentenceTxtBox.Name = "sentenceTxtBox";
            this.sentenceTxtBox.Size = new System.Drawing.Size(768, 29);
            this.sentenceTxtBox.TabIndex = 1;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(379, 64);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(187, 32);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Word Counter";
            this.headerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // numberOfWordsLabel
            // 
            this.numberOfWordsLabel.AutoSize = true;
            this.numberOfWordsLabel.Location = new System.Drawing.Point(286, 425);
            this.numberOfWordsLabel.Name = "numberOfWordsLabel";
            this.numberOfWordsLabel.Size = new System.Drawing.Size(166, 22);
            this.numberOfWordsLabel.TabIndex = 3;
            this.numberOfWordsLabel.Text = "Number of Words:";
            // 
            // numberOfWordCountLabel
            // 
            this.numberOfWordCountLabel.AutoSize = true;
            this.numberOfWordCountLabel.Location = new System.Drawing.Point(489, 425);
            this.numberOfWordCountLabel.Name = "numberOfWordCountLabel";
            this.numberOfWordCountLabel.Size = new System.Drawing.Size(21, 22);
            this.numberOfWordCountLabel.TabIndex = 4;
            this.numberOfWordCountLabel.Text = "0";
            // 
            // WordCounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(945, 514);
            this.Controls.Add(this.numberOfWordCountLabel);
            this.Controls.Add(this.numberOfWordsLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.sentenceTxtBox);
            this.Controls.Add(this.countWordsBtn);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "WordCounterForm";
            this.Text = "Word Counter";
            this.Load += new System.EventHandler(this.WordCounter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button countWordsBtn;
        private System.Windows.Forms.TextBox sentenceTxtBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label numberOfWordsLabel;
        private System.Windows.Forms.Label numberOfWordCountLabel;
    }
}