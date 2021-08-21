using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_4___Eventos___JogoVelha
{
    public partial class Form1 : Form
    {
        Boolean alternaJogada = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {   
            if (alternaJogada == true)
            {
                panel1.BackColor = Color.Green;
                panel10.BackColor = Color.Red;

                if (panel1.BackColor == panel2.BackColor)
                {
                    if (panel1.BackColor == panel3.BackColor)
                    {
                        if (panel1.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel1.BackColor == panel6.BackColor)
                {
                    if (panel1.BackColor == panel9.BackColor)
                    {
                        if (panel1.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel1.BackColor == panel5.BackColor)
                {
                    if (panel1.BackColor == panel7.BackColor)
                    {
                        if (panel1.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                alternaJogada = false;
            }
            else
            {
                panel1.BackColor = Color.Red;
                panel10.BackColor = Color.Green;

                if (panel1.BackColor == panel2.BackColor)
                {
                    if (panel1.BackColor == panel3.BackColor)
                    {
                        if (panel1.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel1.BackColor == panel6.BackColor)
                {
                    if (panel1.BackColor == panel9.BackColor)
                    {
                        if (panel1.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel1.BackColor == panel5.BackColor)
                {
                    if (panel1.BackColor == panel7.BackColor)
                    {
                        if (panel1.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                alternaJogada = true;
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (alternaJogada == true)
            {
                panel2.BackColor = Color.Green;
                panel10.BackColor = Color.Red;

                if (panel1.BackColor == panel2.BackColor)
                {
                    if (panel2.BackColor == panel3.BackColor)
                    {
                        if (panel2.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel2.BackColor == panel5.BackColor)
                {
                    if (panel2.BackColor == panel8.BackColor)
                    {
                        if (panel2.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                alternaJogada = false;
            }
            else
            {
                panel2.BackColor = Color.Red;
                panel10.BackColor = Color.Green;

                if (panel1.BackColor == panel2.BackColor)
                {
                    if (panel2.BackColor == panel3.BackColor)
                    {
                        if (panel2.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel2.BackColor == panel5.BackColor)
                {
                    if (panel2.BackColor == panel8.BackColor)
                    {
                        if (panel2.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                alternaJogada = true;
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (alternaJogada == true)
            {
                panel3.BackColor = Color.Green;
                panel10.BackColor = Color.Red;

                if (panel3.BackColor == panel2.BackColor)
                {
                    if (panel3.BackColor == panel1.BackColor)
                    {
                        if (panel3.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel3.BackColor == panel4.BackColor)
                {
                    if (panel3.BackColor == panel7.BackColor)
                    {
                        if (panel3.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel3.BackColor == panel5.BackColor)
                {
                    if (panel3.BackColor == panel9.BackColor)
                    {
                        if (panel3.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                alternaJogada = false;
            }
            else
            {
                panel3.BackColor = Color.Red;
                panel10.BackColor = Color.Green;

                if (panel3.BackColor == panel2.BackColor)
                {
                    if (panel3.BackColor == panel1.BackColor)
                    {
                        if (panel3.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel3.BackColor == panel4.BackColor)
                {
                    if (panel3.BackColor == panel7.BackColor)
                    {
                        if (panel3.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel3.BackColor == panel5.BackColor)
                {
                    if (panel3.BackColor == panel9.BackColor)
                    {
                        if (panel3.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                alternaJogada = true;
            }
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (alternaJogada == true)
            {
                panel6.BackColor = Color.Green;
                panel10.BackColor = Color.Red;

                if (panel6.BackColor == panel1.BackColor)
                {
                    if (panel6.BackColor == panel9.BackColor)
                    {
                        if (panel6.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel6.BackColor == panel5.BackColor)
                {
                    if (panel6.BackColor == panel4.BackColor)
                    {
                        if (panel6.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                alternaJogada = false;
            }
            else
            {
                panel6.BackColor = Color.Red;
                panel10.BackColor = Color.Green;

                if (panel6.BackColor == panel1.BackColor)
                {
                    if (panel6.BackColor == panel9.BackColor)
                    {
                        if (panel6.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel6.BackColor == panel5.BackColor)
                {
                    if (panel6.BackColor == panel4.BackColor)
                    {
                        if (panel6.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                alternaJogada = true;
            }
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (alternaJogada == true)
            {
                panel5.BackColor = Color.Green;
                panel10.BackColor = Color.Red;

                if (panel5.BackColor == panel1.BackColor)
                {
                    if (panel5.BackColor == panel7.BackColor)
                    {
                        if (panel5.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel5.BackColor == panel2.BackColor)
                {
                    if (panel5.BackColor == panel8.BackColor)
                    {
                        if (panel5.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel5.BackColor == panel3.BackColor)
                {
                    if (panel5.BackColor == panel9.BackColor)
                    {
                        if (panel5.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel5.BackColor == panel4.BackColor)
                {
                    if (panel5.BackColor == panel6.BackColor)
                    {
                        if (panel5.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                alternaJogada = false;
            }
            else
            {
                panel5.BackColor = Color.Red;
                panel10.BackColor = Color.Green;

                if (panel5.BackColor == panel1.BackColor)
                {
                    if (panel5.BackColor == panel7.BackColor)
                    {
                        if (panel5.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel5.BackColor == panel2.BackColor)
                {
                    if (panel5.BackColor == panel8.BackColor)
                    {
                        if (panel5.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel5.BackColor == panel3.BackColor)
                {
                    if (panel5.BackColor == panel9.BackColor)
                    {
                        if (panel5.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel5.BackColor == panel4.BackColor)
                {
                    if (panel5.BackColor == panel6.BackColor)
                    {
                        if (panel5.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                alternaJogada = true;
            }

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (alternaJogada == true)
            {
                panel4.BackColor = Color.Green;
                panel10.BackColor = Color.Red;

                if (panel4.BackColor == panel3.BackColor)
                {
                    if (panel4.BackColor == panel7.BackColor)
                    {
                        if (panel4.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel4.BackColor == panel5.BackColor)
                {
                    if (panel4.BackColor == panel6.BackColor)
                    {
                        if (panel4.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                alternaJogada = false;
            }
            else
            {
                panel4.BackColor = Color.Red;
                panel10.BackColor = Color.Green;

                if (panel4.BackColor == panel3.BackColor)
                {
                    if (panel4.BackColor == panel7.BackColor)
                    {
                        if (panel4.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel4.BackColor == panel5.BackColor)
                {
                    if (panel4.BackColor == panel6.BackColor)
                    {
                        if (panel4.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                alternaJogada = true;
            }

        }

        private void panel9_Click(object sender, EventArgs e)
        {
            if (alternaJogada == true)
            {
                panel9.BackColor = Color.Green;
                panel10.BackColor = Color.Red;

                if (panel9.BackColor == panel6.BackColor)
                {
                    if (panel9.BackColor == panel1.BackColor)
                    {
                        if (panel9.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel9.BackColor == panel5.BackColor)
                {
                    if (panel9.BackColor == panel3.BackColor)
                    {
                        if (panel9.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel9.BackColor == panel8.BackColor)
                {
                    if (panel9.BackColor == panel7.BackColor)
                    {
                        if (panel9.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                alternaJogada = false;
            }
            else
            {
                panel9.BackColor = Color.Red;
                panel10.BackColor = Color.Green;

                if (panel9.BackColor == panel6.BackColor)
                {
                    if (panel9.BackColor == panel1.BackColor)
                    {
                        if (panel9.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel9.BackColor == panel5.BackColor)
                {
                    if (panel9.BackColor == panel3.BackColor)
                    {
                        if (panel9.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel9.BackColor == panel8.BackColor)
                {
                    if (panel9.BackColor == panel7.BackColor)
                    {
                        if (panel9.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                alternaJogada = true;
            }

        }

        private void panel8_Click(object sender, EventArgs e)
        {
            if (alternaJogada == true)
            {
                panel8.BackColor = Color.Green;
                panel10.BackColor = Color.Red;

                if (panel8.BackColor == panel5.BackColor)
                {
                    if (panel8.BackColor == panel2.BackColor)
                    {
                        if (panel8.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel8.BackColor == panel7.BackColor)
                {
                    if (panel8.BackColor == panel9.BackColor)
                    {
                        if (panel8.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                alternaJogada = false;
            }
            else
            {
                panel8.BackColor = Color.Red;
                panel10.BackColor = Color.Green;

                if (panel8.BackColor == panel5.BackColor)
                {
                    if (panel8.BackColor == panel2.BackColor)
                    {
                        if (panel8.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel8.BackColor == panel7.BackColor)
                {
                    if (panel8.BackColor == panel9.BackColor)
                    {
                        if (panel8.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                alternaJogada = true;
            }

        }

        private void panel7_Click(object sender, EventArgs e)
        {
            if (alternaJogada == true)
            {
                panel7.BackColor = Color.Green;
                panel10.BackColor = Color.Red;

                if (panel7.BackColor == panel8.BackColor)
                {
                    if (panel7.BackColor == panel9.BackColor)
                    {
                        if (panel7.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel7.BackColor == panel5.BackColor)
                {
                    if (panel7.BackColor == panel1.BackColor)
                    {
                        if (panel7.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel7.BackColor == panel4.BackColor)
                {
                    if (panel7.BackColor == panel3.BackColor)
                    {
                        if (panel7.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Verde' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                alternaJogada = false;
            }
            else
            {
                panel7.BackColor = Color.Red;
                panel10.BackColor = Color.Green;

                if (panel7.BackColor == panel8.BackColor)
                {
                    if (panel7.BackColor == panel9.BackColor)
                    {
                        if (panel7.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel7.BackColor == panel5.BackColor)
                {
                    if (panel7.BackColor == panel1.BackColor)
                    {
                        if (panel7.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                if (panel7.BackColor == panel4.BackColor)
                {
                    if (panel7.BackColor == panel3.BackColor)
                    {
                        if (panel7.BackColor != Color.Khaki)
                        {
                            MessageBox.Show("O jogo acabou!\n" + "\n" + "Jogador 'Vermelho' Venceu!!!");
                            panel1.BackColor = Color.Khaki;
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            panel6.BackColor = Color.Khaki;
                            panel7.BackColor = Color.Khaki;
                            panel8.BackColor = Color.Khaki;
                            panel9.BackColor = Color.Khaki;
                        }
                    }
                }
                alternaJogada = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Khaki;
            panel2.BackColor = Color.Khaki;
            panel3.BackColor = Color.Khaki;
            panel4.BackColor = Color.Khaki;
            panel5.BackColor = Color.Khaki;
            panel6.BackColor = Color.Khaki;
            panel7.BackColor = Color.Khaki;
            panel8.BackColor = Color.Khaki;
            panel9.BackColor = Color.Khaki;
            alternaJogada = true;
            panel10.BackColor = Color.Green;
        }
    }
}
