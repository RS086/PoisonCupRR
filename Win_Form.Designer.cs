namespace PoisonCup
{
	partial class Win_Form
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
            this.lblWinLose = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWinLose
            // 
            this.lblWinLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLose.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblWinLose.Location = new System.Drawing.Point(199, 102);
            this.lblWinLose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinLose.Name = "lblWinLose";
            this.lblWinLose.Size = new System.Drawing.Size(671, 160);
            this.lblWinLose.TabIndex = 0;
            this.lblWinLose.Text = "YOU WIN!";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnReset.Location = new System.Drawing.Point(331, 318);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(201, 59);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Play Again";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnClose.Location = new System.Drawing.Point(552, 318);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(201, 59);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Win_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblWinLose);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Win_Form";
            this.Text = "Game Win Form";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblWinLose;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnClose;
	}
}