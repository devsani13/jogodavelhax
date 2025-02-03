using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Velha
{
    public partial class MainPage : ContentPage
    {
        public string JogadorAtual = "X";
        public int contvelha = 0;
        public MainPage()
        {
            InitializeComponent();
            btn1.Clicked += Button1;
            btn2.Clicked += Button2;
            btn3.Clicked += Button3;
            btn4.Clicked += Button4;
            btn5.Clicked += Button5;
            btn6.Clicked += Button6;
            btn7.Clicked += Button7;
            btn8.Clicked += Button8;
            btn9.Clicked += Button9;
            btnjogar.Clicked += Button0;
            Zerar();
        }

        public string InverteJogador()
        {
            if (JogadorAtual == "X")
            {
                return "O";
            }
            else
            {
                return "X";
            }
            //return "X";
        }
        public void Zerar()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            JogadorAtual = "X";
            contvelha = 0;
        }

        public bool Verificar(string Jogador)
        {
            if(contvelha==9)
            {
                DisplayAlert("Palavra chula", "Deu velha", "OK");
            }

            if (btn1.Text == Jogador && btn2.Text == Jogador && btn3.Text == Jogador)
            {
                Ganhar();
                return true;
            }
            if (btn4.Text == Jogador && btn5.Text == Jogador && btn6.Text == Jogador)
            {
                Ganhar();
                return true;
            }
            if (btn7.Text == Jogador && btn8.Text == Jogador && btn9.Text == Jogador)
            {
                Ganhar();
                return true;
            }
            if (btn1.Text == Jogador && btn4.Text == Jogador && btn7.Text == Jogador)
            {
                Ganhar();
                return true;
            }
            if (btn2.Text == Jogador && btn5.Text == Jogador && btn8.Text == Jogador)
            {
                Ganhar();
                return true;
            }
            if (btn3.Text == Jogador && btn6.Text == Jogador && btn9.Text == Jogador)
            {
                Ganhar();
                return true;
            }
            if (btn1.Text == Jogador && btn5.Text == Jogador && btn9.Text == Jogador)
            {
                Ganhar();
                return true;
            }
            if (btn3.Text == Jogador && btn5.Text == Jogador && btn7.Text == Jogador)
            {
                Ganhar();
                return true;
            }
            lbljogadoratual.Text = "Jogador Atual: " + JogadorAtual;
            JogadorAtual = InverteJogador();
            return false;
        }


        public void Ganhar()
        {
            DisplayAlert("Ganhou", "Jogador atual:  " + JogadorAtual.ToString(), "OK");
            Zerar();
        }

        private void Button0(object sender, EventArgs args)
        {
            Zerar();
        }
        private void Button1(object sender, EventArgs args)
        {
            if (btn1.Text == "")
            {
                btn1.Text = JogadorAtual;
                contvelha++;
                Verificar(JogadorAtual);
            }
        }
        private void Button2(object sender, EventArgs args)
        {
            if (btn2.Text == "")
            {
                btn2.Text = JogadorAtual;
                contvelha++;
                Verificar(JogadorAtual);
            }
        }
        private void Button3(object sender, EventArgs args)
        {
            if (btn3.Text == "")
            {
                btn3.Text = JogadorAtual;
                contvelha++;
                Verificar(JogadorAtual);
            }
        }
        private void Button4(object sender, EventArgs args)
        {
            if (btn4.Text == "")
            {
                btn4.Text = JogadorAtual;
                contvelha++;
                Verificar(JogadorAtual);
            }
        }
        private void Button5(object sender, EventArgs args)
        {
            if (btn5.Text == "")
            {
                btn5.Text = JogadorAtual;
                contvelha++;
                Verificar(JogadorAtual);
            }
        }
        private void Button6(object sender, EventArgs args)
        {
            if (btn6.Text == "")
            {
                btn6.Text = JogadorAtual;
                contvelha++;
                Verificar(JogadorAtual);
            }
        }
        private void Button7(object sender, EventArgs args)
        {
            if (btn7.Text == "")
            {
                btn7.Text = JogadorAtual;
                contvelha++;
                Verificar(JogadorAtual);
            }
        }
        private void Button8(object sender, EventArgs args)
        {
            if (btn8.Text == "")
            {
                btn8.Text = JogadorAtual;
                contvelha++;
                Verificar(JogadorAtual);
            }
        }
        private void Button9(object sender, EventArgs args)
        {
            if (btn9.Text == "")
            {
                btn9.Text = JogadorAtual;
                contvelha++;
                Verificar(JogadorAtual);
            }
        }
    }
}
