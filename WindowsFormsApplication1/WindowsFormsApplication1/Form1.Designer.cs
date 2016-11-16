namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.wordInput = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.wordSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wordInput
            // 
            this.wordInput.Location = new System.Drawing.Point(165, 233);
            this.wordInput.Name = "wordInput";
            this.wordInput.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.wordInput.Size = new System.Drawing.Size(100, 20);
            this.wordInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Hangman!";
            // 
            // wordSubmit
            // 
            this.wordSubmit.Location = new System.Drawing.Point(271, 230);
            this.wordSubmit.Name = "wordSubmit";
            this.wordSubmit.Size = new System.Drawing.Size(72, 23);
            this.wordSubmit.TabIndex = 2;
            this.wordSubmit.Text = "Submit";
            this.wordSubmit.UseVisualStyleBackColor = true;
            this.wordSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input a word here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wordSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wordInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wordInput;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wordSubmit;
        private System.Windows.Forms.Label label2;
    }
}

