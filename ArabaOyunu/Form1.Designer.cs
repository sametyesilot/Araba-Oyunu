namespace ArabaOyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSolSerit6 = new System.Windows.Forms.Label();
            this.labelSagfSerit6 = new System.Windows.Forms.Label();
            this.labelSagfSerit5 = new System.Windows.Forms.Label();
            this.labelSolSerit5 = new System.Windows.Forms.Label();
            this.labelSagfSerit3 = new System.Windows.Forms.Label();
            this.labelSolSerit3 = new System.Windows.Forms.Label();
            this.labelSagfSerit4 = new System.Windows.Forms.Label();
            this.labelSolSerit4 = new System.Windows.Forms.Label();
            this.labelSagfSerit1 = new System.Windows.Forms.Label();
            this.labelSolSerit1 = new System.Windows.Forms.Label();
            this.labelSagfSerit2 = new System.Windows.Forms.Label();
            this.labelSolSerit2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.redCar = new System.Windows.Forms.PictureBox();
            this.timerSerit = new System.Windows.Forms.Timer(this.components);
            this.timerRandomCar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.redCar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-4, -8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 730);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(691, -8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 730);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // labelSolSerit6
            // 
            this.labelSolSerit6.BackColor = System.Drawing.Color.White;
            this.labelSolSerit6.Location = new System.Drawing.Point(223, -94);
            this.labelSolSerit6.Name = "labelSolSerit6";
            this.labelSolSerit6.Size = new System.Drawing.Size(11, 110);
            this.labelSolSerit6.TabIndex = 3;
            // 
            // labelSagfSerit6
            // 
            this.labelSagfSerit6.BackColor = System.Drawing.Color.White;
            this.labelSagfSerit6.Location = new System.Drawing.Point(464, -94);
            this.labelSagfSerit6.Name = "labelSagfSerit6";
            this.labelSagfSerit6.Size = new System.Drawing.Size(11, 110);
            this.labelSagfSerit6.TabIndex = 4;
            // 
            // labelSagfSerit5
            // 
            this.labelSagfSerit5.BackColor = System.Drawing.Color.White;
            this.labelSagfSerit5.Location = new System.Drawing.Point(464, 31);
            this.labelSagfSerit5.Name = "labelSagfSerit5";
            this.labelSagfSerit5.Size = new System.Drawing.Size(11, 110);
            this.labelSagfSerit5.TabIndex = 6;
            // 
            // labelSolSerit5
            // 
            this.labelSolSerit5.BackColor = System.Drawing.Color.White;
            this.labelSolSerit5.Location = new System.Drawing.Point(223, 31);
            this.labelSolSerit5.Name = "labelSolSerit5";
            this.labelSolSerit5.Size = new System.Drawing.Size(11, 110);
            this.labelSolSerit5.TabIndex = 5;
            // 
            // labelSagfSerit3
            // 
            this.labelSagfSerit3.BackColor = System.Drawing.Color.White;
            this.labelSagfSerit3.Location = new System.Drawing.Point(464, 285);
            this.labelSagfSerit3.Name = "labelSagfSerit3";
            this.labelSagfSerit3.Size = new System.Drawing.Size(11, 110);
            this.labelSagfSerit3.TabIndex = 10;
            // 
            // labelSolSerit3
            // 
            this.labelSolSerit3.BackColor = System.Drawing.Color.White;
            this.labelSolSerit3.Location = new System.Drawing.Point(223, 285);
            this.labelSolSerit3.Name = "labelSolSerit3";
            this.labelSolSerit3.Size = new System.Drawing.Size(11, 110);
            this.labelSolSerit3.TabIndex = 9;
            // 
            // labelSagfSerit4
            // 
            this.labelSagfSerit4.BackColor = System.Drawing.Color.White;
            this.labelSagfSerit4.Location = new System.Drawing.Point(464, 160);
            this.labelSagfSerit4.Name = "labelSagfSerit4";
            this.labelSagfSerit4.Size = new System.Drawing.Size(11, 110);
            this.labelSagfSerit4.TabIndex = 8;
            // 
            // labelSolSerit4
            // 
            this.labelSolSerit4.BackColor = System.Drawing.Color.White;
            this.labelSolSerit4.Location = new System.Drawing.Point(223, 160);
            this.labelSolSerit4.Name = "labelSolSerit4";
            this.labelSolSerit4.Size = new System.Drawing.Size(11, 110);
            this.labelSolSerit4.TabIndex = 7;
            // 
            // labelSagfSerit1
            // 
            this.labelSagfSerit1.BackColor = System.Drawing.Color.White;
            this.labelSagfSerit1.Location = new System.Drawing.Point(464, 540);
            this.labelSagfSerit1.Name = "labelSagfSerit1";
            this.labelSagfSerit1.Size = new System.Drawing.Size(11, 110);
            this.labelSagfSerit1.TabIndex = 14;
            // 
            // labelSolSerit1
            // 
            this.labelSolSerit1.BackColor = System.Drawing.Color.White;
            this.labelSolSerit1.Location = new System.Drawing.Point(223, 540);
            this.labelSolSerit1.Name = "labelSolSerit1";
            this.labelSolSerit1.Size = new System.Drawing.Size(11, 110);
            this.labelSolSerit1.TabIndex = 13;
            // 
            // labelSagfSerit2
            // 
            this.labelSagfSerit2.BackColor = System.Drawing.Color.White;
            this.labelSagfSerit2.Location = new System.Drawing.Point(464, 415);
            this.labelSagfSerit2.Name = "labelSagfSerit2";
            this.labelSagfSerit2.Size = new System.Drawing.Size(11, 110);
            this.labelSagfSerit2.TabIndex = 12;
            // 
            // labelSolSerit2
            // 
            this.labelSolSerit2.BackColor = System.Drawing.Color.White;
            this.labelSolSerit2.Location = new System.Drawing.Point(223, 415);
            this.labelSolSerit2.Name = "labelSolSerit2";
            this.labelSolSerit2.Size = new System.Drawing.Size(11, 110);
            this.labelSolSerit2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 650);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(710, 49);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // redCar
            // 
            this.redCar.Image = global::ArabaOyunu.Properties.Resources.car3;
            this.redCar.Location = new System.Drawing.Point(296, 428);
            this.redCar.Name = "redCar";
            this.redCar.Size = new System.Drawing.Size(120, 200);
            this.redCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redCar.TabIndex = 16;
            this.redCar.TabStop = false;
            // 
            // timerSerit
            // 
            this.timerSerit.Enabled = true;
            this.timerSerit.Interval = 200;
            this.timerSerit.Tick += new System.EventHandler(this.timerSerit_Tick);
            // 
            // timerRandomCar
            // 
            this.timerRandomCar.Enabled = true;
            this.timerRandomCar.Interval = 200;
            this.timerRandomCar.Tick += new System.EventHandler(this.timerRandomCar_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(705, 698);
            this.Controls.Add(this.redCar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSagfSerit1);
            this.Controls.Add(this.labelSolSerit1);
            this.Controls.Add(this.labelSagfSerit2);
            this.Controls.Add(this.labelSolSerit2);
            this.Controls.Add(this.labelSagfSerit3);
            this.Controls.Add(this.labelSolSerit3);
            this.Controls.Add(this.labelSagfSerit4);
            this.Controls.Add(this.labelSolSerit4);
            this.Controls.Add(this.labelSagfSerit5);
            this.Controls.Add(this.labelSolSerit5);
            this.Controls.Add(this.labelSagfSerit6);
            this.Controls.Add(this.labelSolSerit6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Araba Yarışı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.redCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSolSerit6;
        private System.Windows.Forms.Label labelSagfSerit6;
        private System.Windows.Forms.Label labelSagfSerit5;
        private System.Windows.Forms.Label labelSolSerit5;
        private System.Windows.Forms.Label labelSagfSerit3;
        private System.Windows.Forms.Label labelSolSerit3;
        private System.Windows.Forms.Label labelSagfSerit4;
        private System.Windows.Forms.Label labelSolSerit4;
        private System.Windows.Forms.Label labelSagfSerit1;
        private System.Windows.Forms.Label labelSolSerit1;
        private System.Windows.Forms.Label labelSagfSerit2;
        private System.Windows.Forms.Label labelSolSerit2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox redCar;
        private System.Windows.Forms.Timer timerSerit;
        private System.Windows.Forms.Timer timerRandomCar;
    }
}

