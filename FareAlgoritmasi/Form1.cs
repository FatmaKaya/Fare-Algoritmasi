using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FareAlgoritmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] dizi;
        bool dFare = false;
        bool dPeynir = false;
        bool engel = true;
        int xMax, yMax;
        string[] farekonum = new string[2];

        private void btnDuvar_Click(object sender, EventArgs e)
        {
            
            Button b = sender as Button;
            string[] bol = new string[2];
            bol = b.Tag.ToString().Split(',');
            
            if (engel)
            {
                b.Image = Properties.Resources.duvar;
                b.Enabled = false;
                dizi[Convert.ToInt32(bol[0]), Convert.ToInt32(bol[1])] = -1;
            }
            if(dFare)
            {
                
                b.Image = Properties.Resources.fare;
                btnPeynir.Enabled = true;
                dPeynir = false;
                engel = false;
                b.Enabled = false;
                farekonum = b.Tag.ToString().Split(',');
                dizi[Convert.ToInt32(bol[0]), Convert.ToInt32(bol[1])] = -2;
                
            }
            if (dPeynir)
            {
                b.Image = Properties.Resources.peynir;
                dFare = false;
                engel = false;
                btnBasla.Enabled = true;
                dizi[Convert.ToInt32(bol[0]), Convert.ToInt32(bol[1])] = -3;
            }

            dFare = false;
            dPeynir = false;
            int sayac = 0;
            int sayac2 = 0;
            for (int i = 0; i < xMax; i++) // Labirentin tamamını engel ile doldurduğunda uyarı mesajı verir.
            {
                for (int j = 0; j < yMax; j++)
                {
                    if (dizi[i, j] == 0)
                        sayac++;
                    if (dizi[i, j] == -2 && dizi[i, j + 1] == -3)
                        return;
                    if (dizi[i, j] == -2 && dizi[i, j - 1] == -3)
                        return;
                    if (dizi[i, j] == -2 && dizi[i + 1, j] == -3)
                        return;
                    if (dizi[i, j] == -2 && dizi[i - 1, j] == -3)
                        return;
                    if (dizi[i, j] == -2 && dizi[i, j - 1] == -1 && dizi[i, j + 1] == -1 && dizi[i + 1, j] == -1 && dizi[i - 1, j] == -1)
                        sayac2++;
                }
            }
            if (sayac == 0 || sayac2==1)
            {
                MessageBox.Show("Farenin ilerleyebileceği yol yok...");
                panelLabirent.Controls.Clear();
                btnPeynir.Enabled = false;
                lblMesaj.Text = "";
                lblMesaj.Text= "En ve Boy bilgilerini girip \nDuvar oluşturabilirsiniz..";
            }
 
        }
      
        private void buttonCiz_Click(object sender, EventArgs e)
        {
            engel = true;          
            btnBasla.Enabled = false;
            panelLabirent.Controls.Clear();
            btnPeynir.Enabled = false;
            lblMesaj.Text = "İstediğiniz konumda \nEngel oluşturabilirsiniz..";
           
            int deger1, deger2;
          
            try
            {
                deger1 = Convert.ToInt32(txtX.Text);
                deger2 = Convert.ToInt32(txtY.Text);
                txtX.Clear();
                txtY.Clear();
                dizi = new int[deger1, deger2];

                if ((deger1 < 11 && deger1 > 3) && (deger2 < 12 && deger2 > 3))
                {
                    xMax = deger1;
                    yMax = deger2;
                    Ciz(deger1, deger2);
                    btnFare.Enabled = true;
                }

                else
                {
                    lblMesaj.Text = "";
                    MessageBox.Show("Labirentin;\n>>> Eni ve boyu 3'den büyük olmalı.\n>>> Boyu 11'den, eni 12'den küçük olmalı.");
                    lblMesaj.Text = "En ve Boy bilgilerini girip \nDuvar oluşturabilirsiniz..";
                    txtX.Enabled = true;
                    txtY.Enabled = true;
                    txtX.Clear();
                    txtY.Clear();
                    buttonCiz.Enabled = true;
                    btnBasla.Enabled = false;
                    btnFare.Enabled = false;
                }
            }
            catch 
            {
                lblMesaj.Text = "";
                MessageBox.Show("Hata! Lütfen değerleri kontrol ediniz..");
                lblMesaj.Text = "En ve Boy bilgilerini girip \nDuvar oluşturabilirsiniz..";
                txtX.Clear();
                txtY.Clear();
                txtX.Enabled = true;
                txtY.Enabled = true;
                buttonCiz.Enabled = true;
            } 
        }

        private void Ciz(int x, int y)
        {
            
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (i == 0)
                        dizi[i, j] = -1;
                    else if (j == 0)
                        dizi[i, j] = -1;
                    else if (j == y - 1)
                        dizi[i, j] = -1;
                    else if (i == x - 1)
                        dizi[i, j] = -1;
                }
            }
            int xPoint = 0, yPoint = 0;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Button b = new Button();
                    if(dizi[i,j]==-1)
                    {
                       b.Enabled = false;
                        b.Image = Properties.Resources.duvar;              
                    }
                    else
                    {
                        b.BackColor = Color.Transparent;
                    }
                    b.FlatStyle = FlatStyle.Flat;
                    b.Top = yPoint;
                    b.Left = xPoint;
                    b.Height = 50;
                    b.Width = 50;
                    b.Tag = i + "," + j;

                    b.Click += btnDuvar_Click;
                    panelLabirent.Controls.Add(b);

                    if (j==y-1)
                    {
                        xPoint = 0;
                        yPoint += 50;
                    }
                    else
                    {
                        xPoint += 50;
                    }
                }
            }
        }

        private void btnFare_Click(object sender, EventArgs e)
        {
            btnFare.Enabled = false;
            dFare = true;
            lblMesaj.Text = "İstediğiniz konuma \nFareyi yerleştirebilirsiniz..";
        }

        private void btnPeynir_Click(object sender, EventArgs e)
        {
            btnPeynir.Enabled = false;
            dPeynir = true;
            lblMesaj.Text = "İstediğiniz konuma \nPeynir'i yerleştirebilirip \noyunu başlatabilirsiniz..";
        }

        //string temp;
        private async void buttonBasla_Click(object sender, EventArgs e)
        {
            
            lblMesaj.Text = "Fare Peyniri arıyor.";
            btnBasla.Enabled = false;

           /*for (int i = 0; i < xMax; i++)
            {
                for (int j = 0; j < yMax; j++)
                {
                    
                    temp += dizi[i, j].ToString();
                   
                }
                temp += "\n";
            }
            MessageBox.Show(temp);*/
            await hareket();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPeynir.Enabled = false;
            btnBasla.Enabled = false;
            btnFare.Enabled = false;
            lblMesaj.Text = "En ve Boy bilgilerini girip \nDuvar oluşturabilirsiniz..";

        }

        private async Task<int> hareket()
        {
            int x,y;
            y = Convert.ToInt32(farekonum[1]);

            if (farekonum[0] == "1")
                x = Convert.ToInt32(farekonum[0]) + 1;  
            else
                x = Convert.ToInt32(farekonum[0]) - 1;

            while (true)
                {
                    if (x > xMax || y > yMax) break;
                    int xBulunan = 0, yBulunan = y, min = 0, bulunan = 0;


                    int ust = y - 1;
                    int alt = y + 1;
                    int sol = x - 1;
                    int sag = x + 1;
                    int[] siralama = new int[] { int.MaxValue, dizi[x, ust], dizi[x, alt], dizi[sol, y], dizi[sag, y] };

                    for (int i = 1; i < siralama.Length; i++)
                    {
                        if (siralama[i] < siralama[min] && siralama[i] != -1)
                        {
                            min = i;

                            if (i == 1)
                            {
                                xBulunan = x;
                                yBulunan = ust;
                            }
                            else if (i == 2)
                            {
                                xBulunan = x;
                                yBulunan = alt;
                            }
                            else if (i == 3)
                            {
                                xBulunan = sol;
                                yBulunan = y;
                            }
                            else if (i == 4)
                            {
                                xBulunan = sag;
                                yBulunan = y;
                            }
                            bulunan = i;
                        }
                    }

                    foreach (var i in panelLabirent.Controls)
                    {
                        if (i is Button)
                        {
                            string[] bol = new string[2];
                            bol = (i as Button).Tag.ToString().Split(',');
                            if (bol[0] == xBulunan.ToString() && bol[1] == yBulunan.ToString())
                            {
                                if (dizi[Convert.ToInt32(bol[0]), Convert.ToInt32(bol[1])] == -3)
                                {
                                    
                                   
                                    (i as Button).Image = Properties.Resources.fare;
                                    lblMesaj.Text = "Oyun bitti..";
                                    MessageBox.Show("Peynir Yakalandı");
                                    panelLabirent.Controls.Clear();
                                    lblMesaj.Text = "En ve Boy bilgilerini girip \nDuvar oluşturabilirsiniz..";
                                    return 0;

                                }


                                (i as Button).Image = Properties.Resources.fare;
                                (i as Button).Text = "";
                                await Task.Delay(150);
                                dizi[xBulunan, yBulunan] += 2;
                                if (dizi[xBulunan, yBulunan] == 20)
                                {
                                    MessageBox.Show("Fare'nin kafası karıştı!!\nLabirenti çözülemedi..");
                                    panelLabirent.Controls.Clear();
                                    lblMesaj.Text = "En ve Boy bilgilerini girip \nDuvar oluşturabilirsiniz..";
                                    return 0;
                                }
                                (i as Button).BackColor = Color.Transparent;
                                (i as Button).Image = null;
                                break;
                            }
                        }
                    }
                    x = xBulunan;
                    y = yBulunan;

                    await Task.Delay(150);
                }
            return 0;
        }
    }
}
