using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;



namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
        int soruNo = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                switch (soruNo)
                {
                    //Cevap 1
                    case 1:
                        if (textBox1.Text.ToLower() == "akdeniz")
                        {
                            A.BackColor = Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();

                        }
                        else
                        {
                            A.BackColor=Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                        }
                        A.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;
                       

                    //Cevap 2
                    case 2:
                        if (textBox1.Text.ToLower() == "bursa")
                        {
                            B.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            B.BackColor=Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        B.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;

                    //Cevap 3
                    case 3:
                        if (textBox1.Text.ToLower() == "cuma")
                        {
                            C.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            C.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        C.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;

                    //Cevap 4
                    case 4:
                        if (textBox1.Text.ToLower() == "diyarbakır")
                        {
                            D.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            D.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        D.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;

                    //Cevap 5
                    case 5:
                        if (textBox1.Text.ToLower() == "eski")
                        {
                            E.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            E.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        E.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;

                    //Cevap 6
                    case 6:
                        if (textBox1.Text.ToLower() == "ferman")
                        {
                            F.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            F.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        F.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;

                    //Cevap 7
                    case 7:
                        if (textBox1.Text.ToLower() == "güneş")
                        {
                            G.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            G.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        G.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;

                    //Cevap 8
                    case 8:
                        if (textBox1.Text.ToLower() == "halı")
                        {
                            H.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            H.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        H.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;

                    //Cevap 9
                    case 9:
                        if (textBox1.Text.ToLower() == "ısparta")
                        {
                            I.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            I.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        I.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;

                    //Cevap 10
                    case 10:
                        if (textBox1.Text.ToLower() == "izmir")
                        {
                            İ.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            İ.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        İ.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;


                    //Cevap 11
                    case 11:
                        if (textBox1.Text.ToLower() == "jandarma")
                        {
                            J.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            J.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        J.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;


                    //Cevap 12
                    case 12:
                        if (textBox1.Text.ToLower() == "kayısı")
                        {
                            K.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            K.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        K.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;

                    //Cevap 13
                    case 13:
                        if (textBox1.Text.ToLower() == "lale")
                        {
                            L.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            L.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        L.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;

                    //Cevap 14
                    case 14:
                        if (textBox1.Text.ToLower() == "mart")
                        {
                            M.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            M.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        M.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;

                    //Cevap 15
                    case 15:
                        if (textBox1.Text.ToLower() == "ney")
                        {
                            N.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            N.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        N.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;

                    //Cevap 16
                    case 16:
                        if (textBox1.Text.ToLower() == "ozan")
                        {
                            O.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            O.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        O.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;


                    //Cevap 17
                    case 17:
                        if (textBox1.Text.ToLower() == "püre")
                        {
                            P.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            P.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        P.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;

                    //Cevap 18
                    case 18:
                        if (textBox1.Text.ToLower() == "ramazan")
                        {
                            R.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            R.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        R.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;


                    //Cevap 19
                    case 19:
                        if (textBox1.Text.ToLower() == "snake")
                        {
                            S.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            S.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        S.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;


                    //Cevap 20
                    case 20:
                        if (textBox1.Text.ToLower() == "tarkan")
                        {
                            T.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            T.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        T.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;


                    //Cevap 21
                    case 21:
                        if (textBox1.Text.ToLower() == "umut")
                        {
                            U.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            U.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        U.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;

                    //Cevap 22
                    case 22:
                        if (textBox1.Text.ToLower() == "van")
                        {
                            V.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            V.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        V.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;

                    //Cevap 23
                    case 23:
                        if (textBox1.Text.ToLower() == "yıldırım")
                        {
                            Y.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            Y.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        Y.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;

                    //Cevap 24
                    case 24:
                        if (textBox1.Text.ToLower() == "zeytinyağı")
                        {
                            Z.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            Z.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        Z.Enabled = false;  // Butonu devre dışı bırak
                        textBox1.Clear();  // TextBox'ı temizle
                        break;

                }
                                      
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruNo++;
            this.Text=soruNo.ToString();

            if (soruNo==1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                A.BackColor = Color.Yellow;
                button1.Text = "A";
            }
            if (soruNo==2)
            {
                richTextBox1.Text = "Yeşilliği ile ünlü marmara ilimiz?";
                B.BackColor = Color.Yellow;
                button1.Text = "B";
            }
            if (soruNo==3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü";
                C.BackColor=Color.Yellow;
                button1.Text = "C";
            }
            if (soruNo==4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                D.BackColor = Color.Yellow;
                button1.Text = "D";
            }
            if (soruNo==5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?";
                E.BackColor = Color.Yellow;
                button1.Text = "E";
            }
            if (soruNo==6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                F.BackColor = Color.Yellow;
                button1.Text = "F";
            }
            if (soruNo==7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                G.BackColor = Color.Yellow;
                button1.Text= "G";
            }
            if(soruNo==8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne?";
                H.BackColor = Color.Yellow;
                button1.Text = "H";
            }
            if (soruNo==9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                I.BackColor = Color.Yellow;
                button1.Text = "I";
            }
            if (soruNo==10)
            {
                richTextBox1.Text = "Kumrusu ile meşhur ilimiz?";
                İ.BackColor = Color.Yellow;
                button1.Text = "İ";
            }
            if (soruNo == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk?";
                J.BackColor = Color.Yellow;
                button1.Text = "J";
            }
            if (soruNo == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi?";
                K.BackColor = Color.Yellow;
                button1.Text = "K";

            }
            if(soruNo== 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali?";
                L.BackColor = Color.Yellow;
                button1.Text = "L";

            }
            if (soruNo == 14)
            {
                richTextBox1.Text = "Yılın 3.ayı?";
                M.BackColor = Color.Yellow;
                button1.Text = "M";

            }
            if (soruNo==15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti?";
                N.BackColor = Color.Yellow;
                button1.Text = "N";
            }
            if (soruNo == 16)
            {
                richTextBox1.Text = "Halk şairi?";
                O.BackColor = Color.Yellow;
                button1.Text = "O";
            }
            if (soruNo == 17)
            {
                richTextBox1.Text = "Çocukların pek sevmediği pirinç havuç gibi sebzeler ile yapılan yemek?";
                P.BackColor = Color.Yellow;
                button1.Text = "P";
            }
            if (soruNo == 18)
            {
                richTextBox1.Text = "11.ayın sultanı?";
                R.BackColor = Color.Yellow;
                button1.Text = "R";
            }
            if (soruNo == 19)
            {
                richTextBox1.Text = "İngilizcede yılan?";
                S.BackColor = Color.Yellow;
                button1.Text = "S";
            }
            if (soruNo == 20)
            {
                richTextBox1.Text = "Türkiyenin megastarı?";
                T.BackColor = Color.Yellow;
                button1.Text = "T";

            }
            if (soruNo == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı";
                U.BackColor = Color.Yellow;
                button1.Text = "U";
            }
            if (soruNo == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
                V.BackColor = Color.Yellow;
                button1.Text = "V";
            }
            if (soruNo == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
                Y.BackColor = Color.Yellow;
                button1.Text = "Y";

            }
            if (soruNo == 24)
            {
                richTextBox1.Text = "Ege bölgesinin en çok ağacı bulunan yağı da yapılan bir besin?";
                Z.BackColor = Color.Yellow;
                button1.Text = "Z";

                MessageBox.Show($"Oyun Bitti!\nDoğru: {dogru}\nYanlış: {yanlis}", "Sonuç");
                System.Media.SystemSounds.Beep.Play();
            }

        }
    }
}
