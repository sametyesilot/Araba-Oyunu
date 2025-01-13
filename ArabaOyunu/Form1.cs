using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seritSayisi = 1;
        Random R = new Random();

        class RandomCar
        {
            public bool FakeHaveCar = false;
            public PictureBox FakeCar;
            public bool vakit = false;

        }

        RandomCar[] rndCar = new RandomCar[2];
        void BringRandomCar(PictureBox pb)
        {
            int rnd = R.Next(0,4);

            switch (rnd)
            {
                case 0:
                    pb.Image = Properties.Resources.car0;
                    break;
                case 1:
                    pb.Image = Properties.Resources.car1;
                    break;
                case 2:
                    pb.Image = Properties.Resources.car2;
                    break;
                case 3:
                    pb.Image = Properties.Resources.car3;
                    break;
            }
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
        }



        private void AracYerine()
        {
            if (seritSayisi==1)
            {
                redCar.Location = new Point(223, 328);
            }
            else if (seritSayisi == 0)
            {
                redCar.Location = new Point(50, 328);
            }
            else if (seritSayisi == 2)
            {
                redCar.Location = new Point(400, 328);
            }
        }
        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void labelSpeed_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (var i = 0; i < rndCar.Length; i++)
            {
                rndCar[i] = new RandomCar();
            }
            rndCar[0].vakit = true;
            AracYerine();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                if (seritSayisi < 2)
                {
                    seritSayisi++;
                }
            }else if(e.KeyCode == Keys.Left)
            {
                if (seritSayisi > 0)
                    seritSayisi--;
            }
            AracYerine();
        }

        private void timerRandomCar_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < rndCar.Length; i++)
            {
                if (!rndCar[i].FakeHaveCar && rndCar[i].vakit)
                {
                    rndCar[i].FakeCar = new PictureBox();
                    BringRandomCar(rndCar[i].FakeCar);
                    rndCar[i].FakeCar.Size = new Size(120, 200);
                    rndCar[i].FakeCar.Top = -rndCar[i].FakeCar.Height;

                    int seriteYerlestir = R.Next(0,3);

                    if (seriteYerlestir == 0)
                    {
                        rndCar[i].FakeCar.Left = 50;
                    }
                    else if (seriteYerlestir == 1)
                    {
                        rndCar[i].FakeCar.Left = 223;
                    }
                    else if (seriteYerlestir == 2)
                    {
                        rndCar[i].FakeCar.Left = 400;
                    }
                    this.Controls.Add(rndCar[i].FakeCar);
                    rndCar[i].FakeHaveCar = true;
                }
                else
                {
                    if (rndCar[i].vakit)
                    {
                        rndCar[i].FakeCar.Top += 20;
                        if (rndCar[i].FakeCar.Top >=154)
                        {
                            for (int j = 0; j < rndCar.Length; j++)
                            {
                                if (!rndCar[j].vakit)
                                {
                                    rndCar[j].vakit = true;
                                    break;
                                }
                            }
                        }
                    }

                    if (rndCar[i].FakeCar != null && rndCar[i].FakeCar.Top >= this.Height - 20)
                    {
                        rndCar[i].FakeCar.Dispose();
                        rndCar[i].FakeCar = null; // Dispose sonrası referansı temizle
                        rndCar[i].FakeHaveCar = false;
                        rndCar[i].vakit = false;
                    }
                }


                if (rndCar[i].vakit)
                {
                    if (rndCar[i].FakeCar == null)
                        continue; // FakeCar yoksa işlemleri atla

                    float mutlakX = Math.Abs(((redCar.Left + (redCar.Width / 2)) - (rndCar[i].FakeCar.Left + (rndCar[i].FakeCar.Width / 2))));
                    float mutlakY = Math.Abs(((redCar.Top + (redCar.Height / 2)) - (rndCar[i].FakeCar.Top + (rndCar[i].FakeCar.Height / 2))));
                    float farkGenislik = (redCar.Width / 2) + (rndCar[i].FakeCar.Width / 2);
                    float farkYukseklik = (redCar.Height / 2) + (rndCar[i].FakeCar.Height / 2);

                    if (farkGenislik > mutlakX && farkYukseklik > mutlakY)
                    {
                        timerRandomCar.Enabled = false;
                        timerSerit.Enabled = false;
                        DialogResult dr = MessageBox.Show("Kaza Yaptın. Tekrar Denemek İster Misin.", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            AracYerine();
                            for (int j = 0; j < rndCar.Length; j++)
                            {
                                if (rndCar[j].FakeCar != null)
                                {
                                    rndCar[j].FakeCar.Dispose(); // Dispose işlemi
                                    rndCar[j].FakeCar = null;    // Referansı temizle
                                }
                                rndCar[j].FakeHaveCar = false;
                                rndCar[j].vakit = false;
                            }

                            rndCar[0].vakit = true;
                            timerRandomCar.Enabled = true;
                            timerRandomCar.Interval = 200;

                            timerSerit.Enabled = true;
                            timerSerit.Interval = 200;
                        }
                    }
                }


            }
        }

        bool seritHareket = false;
        private void timerSerit_Tick(object sender, EventArgs e)
        {
            if (seritHareket==false)
            {
                for (int i = 1; i < 7; i++)
                {
                    this.Controls.Find("labelSolSerit" + i.ToString(), true)[0].Top -= 25;
                    this.Controls.Find("labelSagfSerit" + i.ToString(), true)[0].Top -= 25;
                    seritHareket = true;
                }
            }
            else
            {
                for (int i = 1; i < 7; i++)
                {
                    this.Controls.Find("labelSolSerit" + i.ToString(), true)[0].Top += 25;
                    this.Controls.Find("labelSagfSerit" + i.ToString(), true)[0].Top += 25;
                    seritHareket = false;
                }
            }
        }
    }
}
