using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRaceGame
{
    public partial class Form1 : Form
    {
        int gameSpeed = 0;
        int coinCollected = 0; 
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
        }
        Random rand = new Random();
        int x;

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveLine(gameSpeed);
            Enemy(gameSpeed);
            GameOver();
            Coins(gameSpeed);
            CoinsCollection(); 
        }

        private void GameOver()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds) ||
                car.Bounds.IntersectsWith(enemy2.Bounds) ||
                car.Bounds.IntersectsWith(enemy3.Bounds) )
            {
                timer1.Enabled = false; 
                over.Visible=true;
            }
        }

        private void CoinsCollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                coinCollected++; 
                scoreLbl.Text = "coins: "+coinCollected.ToString();
                x = rand.Next(50, 300);
                coin1.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                coinCollected++;
                scoreLbl.Text = "Coins=" + coinCollected.ToString();
                x = rand.Next(50, 300);
                coin2.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                coinCollected++;
                scoreLbl.Text = "Coins=" + coinCollected.ToString();
                x = rand.Next(50, 300);
                coin3.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                coinCollected++;
                scoreLbl.Text = "Coins=" + coinCollected.ToString();
                x = rand.Next(50, 300);
                coin4.Location = new Point(x, 0);
            }
        }
        private void Coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = rand.Next(10, 200);
                coin1.Location = new Point(x, 0);
            }
            else { coin1.Top += speed; }

            if (coin2.Top >= 500)
            {
                x = rand.Next(10, 200);
                coin2.Location = new Point(x, 0);
            }
            else { coin2.Top += speed; }

            if (coin3.Top >= 500)
            {
                x = rand.Next(50, 300);
                coin3.Location = new Point(x, 0);
            }
            else { coin3.Top += speed; }

            if (coin4.Top >= 500)
            {
                x = rand.Next(10, 380);
                coin4.Location = new Point(x, 0);
            }
            else { coin4.Top += speed; }
        }
        private void MoveLine(int speed)
        {
            if (line1.Top >= 500)
            { line1.Top = 0; }
            else { line1.Top += speed; }

            if (line2.Top >= 500)
            { line2.Top = 0; }
            else { line2.Top += speed; }

            if (line3.Top >= 500)
            { line3.Top = 0; }
            else { line3.Top += speed; }

            if (line4.Top >= 500)
            { line4.Top = 0; }
            else { line4.Top += speed; }
        }
        
        private void Enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = rand.Next(0, 400);
                enemy1.Location = new Point(x, 0);
            }

            else { 
                enemy1.Top += speed; 
            }

            if (enemy2.Top >= 500)
            {
                x = rand.Next(0, 200);
                enemy2.Location = new Point(x, 0);
            }
            else { enemy2.Top += speed; }

            if (enemy3.Top >= 500)
            {
                x = rand.Next(200, 350);
                enemy3.Location = new Point(x, 0);
            }
            else { enemy3.Top += speed; }
        }
        private void Form1_ArrowsKeysPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left){
                if (car.Left > 15)
                    car.Left += -8;}
            if (e.KeyCode == Keys.Right){
                if (car.Right < 375)
                    car.Left += 8; }

            if (e.KeyCode == Keys.Up) {
                if (gameSpeed < 5){ 
                    gameSpeed++; }
            }
            if (e.KeyCode == Keys.Down)
            { if (gameSpeed > 0){ 
                    gameSpeed--; 
                }
            }
        }
    }
}
