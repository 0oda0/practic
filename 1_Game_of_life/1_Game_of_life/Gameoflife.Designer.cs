
namespace _1_Game_of_life
{
    partial class game
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
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.Bluecolor = new System.Windows.Forms.Button();
            this.Redcolor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.DarkKhaki;
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_button.Location = new System.Drawing.Point(12, 12);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 60);
            this.start_button.TabIndex = 4;
            this.start_button.Text = "Начать";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click_1);
            // 
            // stop_button
            // 
            this.stop_button.BackColor = System.Drawing.Color.HotPink;
            this.stop_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stop_button.ForeColor = System.Drawing.Color.Cornsilk;
            this.stop_button.Location = new System.Drawing.Point(12, 80);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 60);
            this.stop_button.TabIndex = 5;
            this.stop_button.Text = "Пауза";
            this.stop_button.UseVisualStyleBackColor = false;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // Bluecolor
            // 
            this.Bluecolor.BackColor = System.Drawing.Color.SlateBlue;
            this.Bluecolor.Location = new System.Drawing.Point(839, 57);
            this.Bluecolor.Margin = new System.Windows.Forms.Padding(2);
            this.Bluecolor.Name = "Bluecolor";
            this.Bluecolor.Size = new System.Drawing.Size(41, 40);
            this.Bluecolor.TabIndex = 6;
            this.Bluecolor.Text = "🖋";
            this.Bluecolor.UseVisualStyleBackColor = false;
            this.Bluecolor.Click += new System.EventHandler(this.bluecolor_Click);
            // 
            // Redcolor
            // 
            this.Redcolor.BackColor = System.Drawing.Color.IndianRed;
            this.Redcolor.Location = new System.Drawing.Point(839, 13);
            this.Redcolor.Margin = new System.Windows.Forms.Padding(2);
            this.Redcolor.Name = "Redcolor";
            this.Redcolor.Size = new System.Drawing.Size(41, 40);
            this.Redcolor.TabIndex = 7;
            this.Redcolor.Text = "✒";
            this.Redcolor.UseVisualStyleBackColor = false;
            this.Redcolor.Click += new System.EventHandler(this.redcolor_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(107, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 536);
            this.panel1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.ForeColor = System.Drawing.Color.Orchid;
            this.button1.Location = new System.Drawing.Point(839, 100);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "🗑";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.clear_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(12, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 60);
            this.button2.TabIndex = 9;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumPurple;
            this.button3.Cursor = System.Windows.Forms.Cursors.Help;
            this.button3.ForeColor = System.Drawing.Color.MistyRose;
            this.button3.Location = new System.Drawing.Point(839, 498);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 40);
            this.button3.TabIndex = 10;
            this.button3.Text = "📎";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.info_button_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(891, 560);
            this.Controls.Add(this.Bluecolor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.Redcolor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stop_button);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Играв в ЖИЗНЬ🧨🧨🧨";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button Bluecolor;
        private System.Windows.Forms.Button Redcolor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

