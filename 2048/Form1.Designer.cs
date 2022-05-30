namespace _2048
{
    partial class Form1
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
            this.down = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.scoreBoard = new System.Windows.Forms.Button();
            this.text11 = new System.Windows.Forms.Label();
            this.text12 = new System.Windows.Forms.Label();
            this.text21 = new System.Windows.Forms.Label();
            this.text22 = new System.Windows.Forms.Label();
            this.text24 = new System.Windows.Forms.Label();
            this.text23 = new System.Windows.Forms.Label();
            this.text14 = new System.Windows.Forms.Label();
            this.text13 = new System.Windows.Forms.Label();
            this.text41 = new System.Windows.Forms.Label();
            this.text31 = new System.Windows.Forms.Label();
            this.text32 = new System.Windows.Forms.Label();
            this.text42 = new System.Windows.Forms.Label();
            this.text33 = new System.Windows.Forms.Label();
            this.text34 = new System.Windows.Forms.Label();
            this.text43 = new System.Windows.Forms.Label();
            this.text44 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // down
            // 
            this.down.BackColor = System.Drawing.Color.Orange;
            this.down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.down.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.down.Location = new System.Drawing.Point(230, 753);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(115, 60);
            this.down.TabIndex = 17;
            this.down.Text = "\\/";
            this.down.UseVisualStyleBackColor = false;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.Orange;
            this.right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.right.Font = new System.Drawing.Font("Microsoft YaHei", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.right.Location = new System.Drawing.Point(467, 518);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(60, 115);
            this.right.TabIndex = 18;
            this.right.Text = ">";
            this.right.UseVisualStyleBackColor = false;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.Orange;
            this.left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left.Font = new System.Drawing.Font("Microsoft YaHei", 20.14286F);
            this.left.Location = new System.Drawing.Point(45, 518);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(60, 115);
            this.left.TabIndex = 19;
            this.left.Text = "<";
            this.left.UseVisualStyleBackColor = false;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(108, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 101);
            this.label1.TabIndex = 20;
            this.label1.Text = "2048 GAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(45, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 80);
            this.button1.TabIndex = 21;
            this.button1.Text = "Start game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // up
            // 
            this.up.BackColor = System.Drawing.Color.Orange;
            this.up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.up.Location = new System.Drawing.Point(230, 333);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(115, 60);
            this.up.TabIndex = 22;
            this.up.Text = "/\\";
            this.up.UseVisualStyleBackColor = false;
            this.up.Click += new System.EventHandler(this.up_Click_1);
            // 
            // scoreBoard
            // 
            this.scoreBoard.BackColor = System.Drawing.Color.Bisque;
            this.scoreBoard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scoreBoard.Font = new System.Drawing.Font("OCR A Extended", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBoard.Location = new System.Drawing.Point(303, 207);
            this.scoreBoard.Name = "scoreBoard";
            this.scoreBoard.Size = new System.Drawing.Size(223, 80);
            this.scoreBoard.TabIndex = 23;
            this.scoreBoard.UseVisualStyleBackColor = false;
            this.scoreBoard.Click += new System.EventHandler(this.button2_Click);
            // 
            // text11
            // 
            this.text11.BackColor = System.Drawing.Color.Bisque;
            this.text11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text11.Font = new System.Drawing.Font("OCR A Extended", 11.14286F);
            this.text11.Location = new System.Drawing.Point(111, 397);
            this.text11.Name = "text11";
            this.text11.Size = new System.Drawing.Size(80, 80);
            this.text11.TabIndex = 24;
            this.text11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.text11.Click += new System.EventHandler(this.text11_Click);
            // 
            // text12
            // 
            this.text12.BackColor = System.Drawing.Color.Bisque;
            this.text12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text12.Font = new System.Drawing.Font("OCR A Extended", 11.14286F);
            this.text12.Location = new System.Drawing.Point(201, 396);
            this.text12.Name = "text12";
            this.text12.Size = new System.Drawing.Size(80, 80);
            this.text12.TabIndex = 25;
            this.text12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text21
            // 
            this.text21.BackColor = System.Drawing.Color.Bisque;
            this.text21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text21.Font = new System.Drawing.Font("OCR A Extended", 11.14286F);
            this.text21.Location = new System.Drawing.Point(111, 488);
            this.text21.Name = "text21";
            this.text21.Size = new System.Drawing.Size(80, 80);
            this.text21.TabIndex = 26;
            this.text21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text22
            // 
            this.text22.BackColor = System.Drawing.Color.Bisque;
            this.text22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text22.Font = new System.Drawing.Font("OCR A Extended", 11.14286F);
            this.text22.Location = new System.Drawing.Point(201, 488);
            this.text22.Name = "text22";
            this.text22.Size = new System.Drawing.Size(80, 80);
            this.text22.TabIndex = 27;
            this.text22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text24
            // 
            this.text24.BackColor = System.Drawing.Color.Bisque;
            this.text24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text24.Font = new System.Drawing.Font("OCR A Extended", 11.14286F);
            this.text24.Location = new System.Drawing.Point(381, 488);
            this.text24.Name = "text24";
            this.text24.Size = new System.Drawing.Size(80, 80);
            this.text24.TabIndex = 28;
            this.text24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text23
            // 
            this.text23.BackColor = System.Drawing.Color.Bisque;
            this.text23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text23.Font = new System.Drawing.Font("OCR A Extended", 11.14286F);
            this.text23.Location = new System.Drawing.Point(291, 488);
            this.text23.Name = "text23";
            this.text23.Size = new System.Drawing.Size(80, 80);
            this.text23.TabIndex = 29;
            this.text23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text14
            // 
            this.text14.BackColor = System.Drawing.Color.Bisque;
            this.text14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text14.Font = new System.Drawing.Font("OCR A Extended", 11.14286F);
            this.text14.Location = new System.Drawing.Point(381, 397);
            this.text14.Name = "text14";
            this.text14.Size = new System.Drawing.Size(80, 80);
            this.text14.TabIndex = 30;
            this.text14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text13
            // 
            this.text13.BackColor = System.Drawing.Color.Bisque;
            this.text13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text13.Font = new System.Drawing.Font("OCR A Extended", 11.14286F);
            this.text13.Location = new System.Drawing.Point(291, 397);
            this.text13.Name = "text13";
            this.text13.Size = new System.Drawing.Size(80, 80);
            this.text13.TabIndex = 31;
            this.text13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text41
            // 
            this.text41.BackColor = System.Drawing.Color.Bisque;
            this.text41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text41.Font = new System.Drawing.Font("OCR A Extended", 11.14286F);
            this.text41.Location = new System.Drawing.Point(111, 670);
            this.text41.Name = "text41";
            this.text41.Size = new System.Drawing.Size(80, 80);
            this.text41.TabIndex = 32;
            this.text41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text31
            // 
            this.text31.BackColor = System.Drawing.Color.Bisque;
            this.text31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text31.Font = new System.Drawing.Font("OCR A Extended", 11.14286F);
            this.text31.Location = new System.Drawing.Point(111, 579);
            this.text31.Name = "text31";
            this.text31.Size = new System.Drawing.Size(80, 80);
            this.text31.TabIndex = 33;
            this.text31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text32
            // 
            this.text32.BackColor = System.Drawing.Color.Bisque;
            this.text32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text32.Font = new System.Drawing.Font("OCR A Extended", 11.14286F);
            this.text32.Location = new System.Drawing.Point(201, 579);
            this.text32.Name = "text32";
            this.text32.Size = new System.Drawing.Size(80, 80);
            this.text32.TabIndex = 34;
            this.text32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text42
            // 
            this.text42.BackColor = System.Drawing.Color.Bisque;
            this.text42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text42.Font = new System.Drawing.Font("OCR A Extended", 11.14286F);
            this.text42.Location = new System.Drawing.Point(201, 670);
            this.text42.Name = "text42";
            this.text42.Size = new System.Drawing.Size(80, 80);
            this.text42.TabIndex = 35;
            this.text42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text33
            // 
            this.text33.BackColor = System.Drawing.Color.Bisque;
            this.text33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text33.Font = new System.Drawing.Font("OCR A Extended", 11.14286F);
            this.text33.Location = new System.Drawing.Point(291, 579);
            this.text33.Name = "text33";
            this.text33.Size = new System.Drawing.Size(80, 80);
            this.text33.TabIndex = 36;
            this.text33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text34
            // 
            this.text34.BackColor = System.Drawing.Color.Bisque;
            this.text34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text34.Font = new System.Drawing.Font("OCR A Extended", 11.14286F);
            this.text34.Location = new System.Drawing.Point(381, 579);
            this.text34.Name = "text34";
            this.text34.Size = new System.Drawing.Size(80, 80);
            this.text34.TabIndex = 37;
            this.text34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text43
            // 
            this.text43.BackColor = System.Drawing.Color.Bisque;
            this.text43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text43.Font = new System.Drawing.Font("OCR A Extended", 11.14286F);
            this.text43.Location = new System.Drawing.Point(291, 670);
            this.text43.Name = "text43";
            this.text43.Size = new System.Drawing.Size(80, 80);
            this.text43.TabIndex = 38;
            this.text43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text44
            // 
            this.text44.BackColor = System.Drawing.Color.Bisque;
            this.text44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text44.Font = new System.Drawing.Font("OCR A Extended", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text44.Location = new System.Drawing.Point(381, 670);
            this.text44.Name = "text44";
            this.text44.Size = new System.Drawing.Size(80, 80);
            this.text44.TabIndex = 39;
            this.text44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-10, 871);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(10, 10);
            this.button3.TabIndex = 41;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.8571429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(557, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(10, 10);
            this.button4.TabIndex = 42;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.8571429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(557, 864);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(10, 10);
            this.button2.TabIndex = 43;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 871);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.text44);
            this.Controls.Add(this.text43);
            this.Controls.Add(this.text34);
            this.Controls.Add(this.text33);
            this.Controls.Add(this.text42);
            this.Controls.Add(this.text32);
            this.Controls.Add(this.text31);
            this.Controls.Add(this.text41);
            this.Controls.Add(this.text13);
            this.Controls.Add(this.text14);
            this.Controls.Add(this.text23);
            this.Controls.Add(this.text24);
            this.Controls.Add(this.text22);
            this.Controls.Add(this.text21);
            this.Controls.Add(this.text12);
            this.Controls.Add(this.text11);
            this.Controls.Add(this.scoreBoard);
            this.Controls.Add(this.up);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.left);
            this.Controls.Add(this.right);
            this.Controls.Add(this.down);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button scoreBoard;
        private System.Windows.Forms.Label text11;
        private System.Windows.Forms.Label text12;
        private System.Windows.Forms.Label text21;
        private System.Windows.Forms.Label text22;
        private System.Windows.Forms.Label text24;
        private System.Windows.Forms.Label text23;
        private System.Windows.Forms.Label text14;
        private System.Windows.Forms.Label text13;
        private System.Windows.Forms.Label text41;
        private System.Windows.Forms.Label text31;
        private System.Windows.Forms.Label text32;
        private System.Windows.Forms.Label text42;
        private System.Windows.Forms.Label text33;
        private System.Windows.Forms.Label text34;
        private System.Windows.Forms.Label text43;
        private System.Windows.Forms.Label text44;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
    }
}

