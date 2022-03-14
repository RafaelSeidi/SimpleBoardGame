using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuleiro_Prova
{
    public partial class Form1 : Form
    {
        bool jogador = true;
        Random dado1 = new Random();
        int x1, casa1, casa2;
        public static bool Ok = false;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            Form regras = new Regras();
            regras.ShowDialog();

            for (int i = 1; i <= 54; i++)
            {
                Controls["pictureBox" + i].Parent = pictureBox55;
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Questao Q = new Questao();
            Q.ShowDialog();
            if (Ok)
            {
                MessageBox.Show("Ande uma casa");
            }
            else
            {
                MessageBox.Show("Volte uma casa");
            }
            Ok = false;
        }

        private void PictureBox55_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x1 = dado1.Next(1, 7);
            button1.Image = Image.FromFile("dado" + x1 + ".png");

            if (jogador == true)
            {
                casa1 += x1;
                pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                pictureBox56.Top = 0;
                pictureBox56.Left = 0;
                jogador = false;
                if (casa1==casa2)
                {
                    casa2 -= 1;
                    pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                }
            }
            else
            {
                if (jogador == false)
                {
                    casa2 += x1;
                    pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                    pictureBox57.Top = 0;
                    pictureBox57.Left = 0;
                    jogador = true;
                    if (casa1 == casa2)
                    {
                        casa1 -= 1;
                        pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                    }
                }
            }
            

            if (casa1 >= 54)
            {
                button1.Enabled = false;
                pictureBox56.Parent = pictureBox54;
                MessageBox.Show("Parabéns jogador amarelo você venceu");
            }
            if (casa2 >= 54)
            {
                pictureBox57.Parent = pictureBox54;
                MessageBox.Show("Parabéns jogador azul você venceu");
                button1.Enabled = false;
            }
            
            //Perguntas
            if (pictureBox56.Parent == pictureBox3)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                    casa1 += 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa1 -= 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                Ok = false;
            }
            if (pictureBox56.Parent == pictureBox6)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                    casa1 += 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa1 -= 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                Ok = false;
            }
            if (pictureBox56.Parent == pictureBox9)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                    casa1 += 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa1 -= 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                Ok = false;
            }
            if (pictureBox56.Parent == pictureBox12)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                    casa1 += 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa1 -= 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                Ok = false;
            }
            if (pictureBox56.Parent == pictureBox15)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                    casa1 += 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa1 -= 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                Ok = false;
            }
            if (pictureBox56.Parent == pictureBox18)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                    casa1 += 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa1 -= 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                Ok = false;
            }
            if (pictureBox56.Parent == pictureBox21)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                    casa1 += 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa1 -= 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                Ok = false;
            }
            if (pictureBox56.Parent == pictureBox24)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                    casa1 += 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa1 -= 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                Ok = false;
            }
            if (pictureBox56.Parent == pictureBox27)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa1 += 1;
                        pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa1 -= 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                Ok = false;
            }
            if (pictureBox56.Parent == pictureBox30)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa1 += 1;
                        pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa1 -= 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                Ok = false;
            }
            if (pictureBox56.Parent == pictureBox33)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa1 += 1;
                        pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa1 -= 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                Ok = false;
            }
            if (pictureBox56.Parent == pictureBox36)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa1 += 1;
                        pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa1 -= 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                Ok = false;
            }
            if (pictureBox56.Parent == pictureBox39)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa1 += 1;
                        pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa1 -= 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                Ok = false;
            }
            if (pictureBox56.Parent == pictureBox42)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa1 += 1;
                        pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa1 -= 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                Ok = false;
            }
            if (pictureBox56.Parent == pictureBox45)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa1 += 1;
                        pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa1 -= 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                Ok = false;
            }
            if (pictureBox56.Parent == pictureBox48)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa1 += 1;
                        pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa1 -= 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                Ok = false;
            }
            if (pictureBox56.Parent == pictureBox51)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa1 += 1;
                        pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa1 -= 1;
                    pictureBox56.Parent = pictureBox55.Controls["pictureBox" + casa1];
                }
                Ok = false;
            }
            //AZUL
            if (pictureBox57.Parent == pictureBox3)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa2 += 1;
                        pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa2 -= 1;
                    pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                }
                Ok = false;
            }
            if (pictureBox57.Parent == pictureBox6)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa2 += 1;
                        pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa2 -= 1;
                    pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                }
                Ok = false;
            }
            if (pictureBox57.Parent == pictureBox9)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa2 += 1;
                        pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa2 -= 1;
                    pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                }
                Ok = false;
            }
            if (pictureBox57.Parent == pictureBox12)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa2 += 1;
                        pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa2 -= 1;
                    pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                }
                Ok = false;
            }
            if (pictureBox57.Parent == pictureBox15)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa2 += 1;
                        pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa2 -= 1;
                    pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                }
                Ok = false;
            }
            if (pictureBox57.Parent == pictureBox18)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa2 += 1;
                        pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa2 -= 1;
                    pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                }
                Ok = false;
            }
            if (pictureBox57.Parent == pictureBox21)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa2 += 1;
                        pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa2 -= 1;
                    pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                }
                Ok = false;
            }
            if (pictureBox57.Parent == pictureBox24)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa2 += 1;
                        pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa2 -= 1;
                    pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                }
                Ok = false;
            }
            if (pictureBox57.Parent == pictureBox27)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa2 += 1;
                        pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa2 -= 1;
                    pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                }
                Ok = false;
            }
            if (pictureBox57.Parent == pictureBox30)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa2 += 1;
                        pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa2 -= 1;
                    pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                }
                Ok = false;
            }
            if (pictureBox57.Parent == pictureBox33)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa2 += 1;
                        pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa2 -= 1;
                    pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                }
                Ok = false;
            }
            if (pictureBox57.Parent == pictureBox36)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa2 += 1;
                        pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa2 -= 1;
                    pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                }
                Ok = false;
            }
            if (pictureBox57.Parent == pictureBox39)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa2 += 1;
                        pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa2 -= 1;
                    pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                }
                Ok = false;
            }
            if (pictureBox57.Parent == pictureBox42)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa2 += 1;
                        pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa2 -= 1;
                    pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                }
                Ok = false;
            }
            if (pictureBox57.Parent == pictureBox45)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa2 += 1;
                        pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa2 -= 1;
                    pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                }
                Ok = false;
            }
            if (pictureBox57.Parent == pictureBox48)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa2 += 1;
                        pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa2 -= 1;
                    pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                }
                Ok = false;
            }
            if (pictureBox57.Parent == pictureBox51)
            {
                Questao Q = new Questao();
                Q.ShowDialog();
                if (Ok)
                {
                    MessageBox.Show("Acertou!!! Ande uma casa");
                        casa2 += 1;
                        pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                    }
                else
                {
                    MessageBox.Show("Errou... Volte uma casa");
                    casa2 -= 1;
                    pictureBox57.Parent = pictureBox55.Controls["pictureBox" + casa2];
                }
                Ok = false;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

    }
}
