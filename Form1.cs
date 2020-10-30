using System;
using System.Windows.Forms;
namespace JuegoPuzzle
{
    public partial class Form1 : Form
    {
        Puzzle game;
        public Form1()
        {
            InitializeComponent();
            game = new Puzzle();
        }
        
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }  
        private void button1_Click(object sender, EventArgs e)
        {
            int[,] aux=new int[3,3];
           
            if (!(sender is Button))  return;
                var Butn =(Button)sender;
                string[] rowCol = Butn.Tag.ToString().Split('_');
                int row = Convert.ToInt32(rowCol[0]);
                int col = Convert.ToInt32(rowCol[1]);
                aux = game.showMatrix(row,col);
                game.play(aux, row, col);
                actualizar();
                if (Butn.Text == "0")
                {
                    Butn.Visible = false;
                }
                game.WinGame();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void acomodar(int[,] matriz)
        {
            
            button1_1.Text = Convert.ToString(matriz[0, 0]);       
            button1_2.Text = Convert.ToString(matriz[0, 1]);
            button1_3.Text = Convert.ToString(matriz[0, 2]);
            button2_1.Text = Convert.ToString(matriz[1, 0]);
            button2_2.Text = Convert.ToString(matriz[1, 1]);
            button2_3.Text = Convert.ToString(matriz[1, 2]);
            button3_1.Text = Convert.ToString(matriz[2, 0]);
            button3_2.Text = Convert.ToString(matriz[2, 1]);
            button3_3.Text = Convert.ToString(matriz[2, 2]);
        }
        private void actualizar()
        {
            button1_1.Text = Convert.ToString(game.show(0, 0));
            button1_1.Visible = true;
            button1_2.Text = Convert.ToString(game.show(0, 1));
            button1_2.Visible = true;
            button1_3.Text = Convert.ToString(game.show(0, 2));
            button1_3.Visible = true;
            button2_1.Text = Convert.ToString(game.show(1, 0));
            button2_1.Visible = true;
            button2_2.Text = Convert.ToString(game.show(1, 1));
            button2_2.Visible = true;
            button2_3.Text = Convert.ToString(game.show(1, 2));
            button2_3.Visible = true;
            button3_1.Text = Convert.ToString(game.show(2, 0));
            button3_1.Visible = true;
            button3_2.Text = Convert.ToString(game.show(2, 1));
            button3_2.Visible = true;
            button3_3.Text = Convert.ToString(game.show(2, 2));
            button3_3.Visible = true;
        }
        private void button10_Click(object sender, EventArgs e)
        {

            game.GenerarNumero();
            actualizar();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            button12.Text = Convert.ToString(game.segundo);
            game.segundo++;
            timer1.Enabled = true;
            timer1.Start();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
