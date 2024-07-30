using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Over.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gameSpeed);
            enemy(gameSpeed+2);
            GameOver();
            coin(gameSpeed +1);
            CoinCollection(); 
        }

        Random random = new Random();
        int x,y;
        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else 
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

            if (pictureBox5.Top >= 500)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += speed;
            }

            if (pictureBox6.Top >= 500)
            {
                pictureBox6.Top = 0;
            }
            else
            {
                pictureBox6.Top += speed;
            }

            if (pictureBox7.Top >= 500)
            {
                pictureBox7.Top = 0;
            }
            else
            {
                pictureBox7.Top += speed;
            }
        }

        int gameSpeed = 9;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 12)
                {
                    car.Left += -10;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 380)
                {
                    car.Left += 12;
                }
            }
        }
        
        int collectedCoins = 0;

        void CoinCollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedCoins++;
                Coins.Text = "Coins = "+ collectedCoins.ToString();
                x = random.Next(0, 380);
                y = random.Next(-59, 10);
                coin1.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedCoins++;
                Coins.Text = "Coins = " + collectedCoins.ToString();
                x = random.Next(0, 380);
                y = random.Next(-59, 10);
                coin2.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedCoins++;
                Coins.Text = "Coins = " + collectedCoins.ToString();
                x = random.Next(0, 380);
                y = random.Next(-59, 10);
                coin3.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedCoins++;
                Coins.Text = "Coins = " + collectedCoins.ToString();
                x = random.Next(0, 380);
                y = random.Next(-59, 10);
                coin4.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin5.Bounds))
            {
                collectedCoins++;
                Coins.Text = "Coins = " + collectedCoins.ToString();
                x = random.Next(0, 380);
                y = random.Next(-59, 10);
                coin5.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin6.Bounds))
            {
                collectedCoins++;
                Coins.Text = "Coins = " + collectedCoins.ToString();
                x = random.Next(0, 380);
                y = random.Next(-59, 10);
                coin6.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin7.Bounds))
            {
                collectedCoins++;
                Coins.Text = "Coins = " + collectedCoins.ToString();
                x = random.Next(0, 380);
                y = random.Next(-59, 10);
                coin7.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin8.Bounds))
            {
                collectedCoins++;
                Coins.Text = "Coins = " + collectedCoins.ToString();
                x = random.Next(0, 380);
                y = random.Next(-59, 10);
                coin8.Location = new Point(x, 0);
            }

        }

        void GameOver()
        {
           
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }
           
            
            if (car.Bounds.IntersectsWith(enemy5.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy6.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy7.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy8.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (gameSpeed < 20) { gameSpeed++; }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (gameSpeed > 0) { gameSpeed--; }
            }

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        void coin (int speed)
        {
            if (coin1.Top >= 500)
            {
                x = random.Next(0, 380);
                y = random.Next(-59, 10);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }

            if (coin2.Top >= 500)
            {
                x = random.Next(0, 380);
                y = random.Next(-59, 10);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }
            if (coin3.Top >= 500)
            {
                x = random.Next(0, 380);
                y = random.Next(-59, 10);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }
            if (coin4.Top >= 500)
            {
                x = random.Next(0, 380);
                y = random.Next(-59, 10);
                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }
            if (coin5.Top >= 500)
            {
                x = random.Next(0, 380);
                y = random.Next(-59, 10);
                coin5.Location = new Point(x, 0);
            }
            else
            {
                coin5.Top += speed;
            }
            if (coin6.Top >= 500)
            {
                x = random.Next(0, 380);
                y = random.Next(-59, 10);
                coin6.Location = new Point(x, 0);
            }
            else
            {
                coin6.Top += speed;
            }
            if (coin7.Top >= 500)
            {
                x = random.Next(0, 380);
                y = random.Next(-59, 10);
                coin7.Location = new Point(x, 0);
            }
            else
            {
                coin7.Top += speed;
            }
            if (coin8.Top >= 500)
            {
                x = random.Next(0, 380);
                y = random.Next(-59, 10);
                coin8.Location = new Point(x, 0);
            }
            else
            {
                coin8.Top += speed;
            }
           
        }

        void enemy(int speed)
        {
           

            if (enemy2.Top >= 500)
            {
                x = random.Next(0, 200);
                y = random.Next(-59, 10);
                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }

            

            

            if (enemy5.Top >= 500)
            {
                x = random.Next(300, 350);
                y = random.Next(-59, 10);
                enemy5.Location = new Point(x, 0);
            }
            else
            {
                enemy5.Top += speed;
            }

            if (enemy6.Top >= 500)
            {
                x = random.Next(0, 100);
                y = random.Next(-59, 10);
                enemy6.Location = new Point(x, 0);
            }
            else
            {
                enemy6.Top += speed;
            }

            if (enemy7.Top >= 500)
            {
                x = random.Next(250, 380);
                y = random.Next(-59, 10);
                enemy7.Location = new Point(x, 0);
            }
            else
            {
                enemy7.Top += speed;
            }

            if (enemy8.Top >= 500)
            {
                x = random.Next(100, 350);
                y = random.Next(-59, 10);
                enemy8.Location = new Point(x, 0);
            }
            else
            {
                enemy8.Top += speed;
            }

           


        }

       
    }
}
