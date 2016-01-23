namespace CouchTo7KMMR_Invoker
{
    partial class SessionWindow
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
            this.timeElapsedTimer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.timeElapsedLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.invokeGroupBox = new System.Windows.Forms.GroupBox();
            this.fifthKeyLabel = new System.Windows.Forms.Label();
            this.fourthKeyLabel = new System.Windows.Forms.Label();
            this.thirdKeyLabel = new System.Windows.Forms.Label();
            this.secondKeyLabel = new System.Windows.Forms.Label();
            this.firstKeyLabel = new System.Windows.Forms.Label();
            this.invokeLabel = new System.Windows.Forms.Label();
            this.invokeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeElapsedTimer
            // 
            this.timeElapsedTimer.Interval = 1000;
            this.timeElapsedTimer.Tick += new System.EventHandler(this.timeElapsedTimer_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(79, 279);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timeElapsedLabel
            // 
            this.timeElapsedLabel.AutoSize = true;
            this.timeElapsedLabel.Location = new System.Drawing.Point(13, 13);
            this.timeElapsedLabel.Name = "timeElapsedLabel";
            this.timeElapsedLabel.Size = new System.Drawing.Size(77, 13);
            this.timeElapsedLabel.TabIndex = 1;
            this.timeElapsedLabel.Text = "Time Elapsed: ";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(15, 31);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(41, 13);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Score: ";
            // 
            // invokeGroupBox
            // 
            this.invokeGroupBox.Controls.Add(this.fifthKeyLabel);
            this.invokeGroupBox.Controls.Add(this.fourthKeyLabel);
            this.invokeGroupBox.Controls.Add(this.thirdKeyLabel);
            this.invokeGroupBox.Controls.Add(this.secondKeyLabel);
            this.invokeGroupBox.Controls.Add(this.firstKeyLabel);
            this.invokeGroupBox.Controls.Add(this.invokeLabel);
            this.invokeGroupBox.Location = new System.Drawing.Point(16, 61);
            this.invokeGroupBox.Name = "invokeGroupBox";
            this.invokeGroupBox.Size = new System.Drawing.Size(200, 100);
            this.invokeGroupBox.TabIndex = 3;
            this.invokeGroupBox.TabStop = false;
            this.invokeGroupBox.Text = "Invoke This!";
            // 
            // fifthKeyLabel
            // 
            this.fifthKeyLabel.AutoSize = true;
            this.fifthKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fifthKeyLabel.Location = new System.Drawing.Point(92, 52);
            this.fifthKeyLabel.Name = "fifthKeyLabel";
            this.fifthKeyLabel.Size = new System.Drawing.Size(0, 22);
            this.fifthKeyLabel.TabIndex = 5;
            // 
            // fourthKeyLabel
            // 
            this.fourthKeyLabel.AutoSize = true;
            this.fourthKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourthKeyLabel.Location = new System.Drawing.Point(70, 52);
            this.fourthKeyLabel.Name = "fourthKeyLabel";
            this.fourthKeyLabel.Size = new System.Drawing.Size(0, 22);
            this.fourthKeyLabel.TabIndex = 4;
            // 
            // thirdKeyLabel
            // 
            this.thirdKeyLabel.AutoSize = true;
            this.thirdKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdKeyLabel.Location = new System.Drawing.Point(49, 52);
            this.thirdKeyLabel.Name = "thirdKeyLabel";
            this.thirdKeyLabel.Size = new System.Drawing.Size(0, 22);
            this.thirdKeyLabel.TabIndex = 3;
            // 
            // secondKeyLabel
            // 
            this.secondKeyLabel.AutoSize = true;
            this.secondKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondKeyLabel.Location = new System.Drawing.Point(28, 52);
            this.secondKeyLabel.Name = "secondKeyLabel";
            this.secondKeyLabel.Size = new System.Drawing.Size(0, 22);
            this.secondKeyLabel.TabIndex = 2;
            // 
            // firstKeyLabel
            // 
            this.firstKeyLabel.AutoSize = true;
            this.firstKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstKeyLabel.Location = new System.Drawing.Point(7, 52);
            this.firstKeyLabel.Name = "firstKeyLabel";
            this.firstKeyLabel.Size = new System.Drawing.Size(0, 22);
            this.firstKeyLabel.TabIndex = 1;
            // 
            // invokeLabel
            // 
            this.invokeLabel.AutoSize = true;
            this.invokeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invokeLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.invokeLabel.Location = new System.Drawing.Point(7, 20);
            this.invokeLabel.Name = "invokeLabel";
            this.invokeLabel.Size = new System.Drawing.Size(0, 25);
            this.invokeLabel.TabIndex = 0;
            // 
            // SessionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 327);
            this.Controls.Add(this.invokeGroupBox);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.timeElapsedLabel);
            this.Controls.Add(this.startButton);
            this.KeyPreview = true;
            this.Name = "SessionWindow";
            this.Text = "SessionWindow";
            this.Load += new System.EventHandler(this.SessionWindow_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.onKeyPress);
            this.invokeGroupBox.ResumeLayout(false);
            this.invokeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timeElapsedTimer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label timeElapsedLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.GroupBox invokeGroupBox;
        private System.Windows.Forms.Label invokeLabel;
        private System.Windows.Forms.Label fifthKeyLabel;
        private System.Windows.Forms.Label fourthKeyLabel;
        private System.Windows.Forms.Label thirdKeyLabel;
        private System.Windows.Forms.Label secondKeyLabel;
        private System.Windows.Forms.Label firstKeyLabel;
    }
}