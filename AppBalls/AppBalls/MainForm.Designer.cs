namespace AppBalls
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.square = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxCountBalls = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSiseSquare = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.square)).BeginInit();
            this.SuspendLayout();
            // 
            // square
            // 
            this.square.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.square.BackColor = System.Drawing.Color.LightSteelBlue;
            this.square.Location = new System.Drawing.Point(12, 12);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(400, 400);
            this.square.TabIndex = 0;
            this.square.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxCountBalls
            // 
            this.textBoxCountBalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountBalls.Location = new System.Drawing.Point(156, 446);
            this.textBoxCountBalls.Name = "textBoxCountBalls";
            this.textBoxCountBalls.Size = new System.Drawing.Size(77, 26);
            this.textBoxCountBalls.TabIndex = 2;
            this.textBoxCountBalls.Text = "1";
            this.textBoxCountBalls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Кол-во шаров";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Размер квадрата";
            // 
            // textBoxSiseSquare
            // 
            this.textBoxSiseSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSiseSquare.Location = new System.Drawing.Point(156, 501);
            this.textBoxSiseSquare.Name = "textBoxSiseSquare";
            this.textBoxSiseSquare.Size = new System.Drawing.Size(77, 26);
            this.textBoxSiseSquare.TabIndex = 5;
            this.textBoxSiseSquare.Text = "400";
            this.textBoxSiseSquare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(294, 471);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(91, 29);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "Старт";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 590);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxSiseSquare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCountBalls);
            this.Controls.Add(this.square);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 629);
            this.MinimumSize = new System.Drawing.Size(440, 629);
            this.Name = "MainForm";
            this.Text = "Balls";
            ((System.ComponentModel.ISupportInitialize)(this.square)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox square;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxCountBalls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSiseSquare;
        private System.Windows.Forms.Button buttonOK;

    }
}

