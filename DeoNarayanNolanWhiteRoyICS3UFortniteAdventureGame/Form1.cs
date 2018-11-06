using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DeoNarayanNolanWhiteRoyICS3UFortniteAdventureGame
{
    public partial class Form1 : Form
    {
        int scene = 1;
        Random randGen = new Random();
        int randomNumberHolder1;
        int randomNumberHolder2;

        public Form1()
        {
            InitializeComponent();
        }
            public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)//red
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 3) { scene = 7; }
                else if (scene == 4) { scene = 9; }
                else if (scene == 5) { scene = 13; }
                else if (scene == 6) { scene = 15; }
                else if (scene == 7) { scene = 17; }
                else if (scene == 8) { scene = 22; }
                else if (scene == 9) { scene = 1; }
                else if (scene == 10) { scene = 1; }
                else if (scene == 11) { scene = 20; }
                else if (scene == 12) { scene = 1; }
                else if (scene == 13) { scene = 1; }
                else if (scene == 14) { scene = 27; }
                else if (scene == 15) { scene = 1; }
                else if (scene == 16) { scene = 1; }
                else if (scene == 17) { scene = 1; }
                else if (scene == 18) { scene = 1; }
                else if (scene == 20) { scene = 25; }
                else if (scene == 22) { scene = 1; }
                else if (scene == 23) { scene = 38; }
                else if (scene == 24) { scene = 25; }
                else if (scene == 25) { scene = 1; }
                else if (scene == 26) { scene = 1; }
                else if (scene == 27) { scene = 36; }
                else if (scene == 28) { scene = 32; }
                else if (scene == 32) { scene = 1; }
                else if (scene == 33) { scene = 1; }
                else if (scene == 34) { scene = 1; }
                else if (scene == 36) { scene = 1; }
                else if (scene == 37) { scene = 1; }
                else if (scene == 38) { scene = 1; }
                else if (scene == 39) { scene = 1; }
                Refresh();
            }
            else if (e.KeyCode == Keys.M)  //blue button press
            {
                randomNumberHolder1 = randGen.Next(1, 11);
                randomNumberHolder2 = randGen.Next(1, 3);

                if (scene == 1) { scene = 3; }
                else if (scene == 2)
                {
                    if (randomNumberHolder2 < 2) { scene = 5; }
                    else { scene = 6; }
                }
                else if (scene == 3) { scene = 8; }
                else if (scene == 4)
                {
                    if (randomNumberHolder1 < 3) { scene = 11; }
                    else { scene = 12; }
                }
                else if (scene == 5) { scene = 14; }
                else if (scene == 6) { scene = 16; }
                else if (scene == 7) { scene = 18; }
                else if (scene == 8) { scene = 23; }
                else if (scene == 9) { this.Close(); }
                else if (scene == 10) { this.Close(); }
                else if (scene == 11) { scene = 24; }
                else if (scene == 12) { this.Close(); }
                else if (scene == 13) { this.Close(); }
                else if (scene == 14) { scene = 28; }
                else if (scene == 15) { this.Close(); }
                else if (scene == 16) { this.Close(); }
                else if (scene == 17) { this.Close(); }
                else if (scene == 18) { this.Close(); }
                else if (scene == 20) { scene = 26; }
                else if (scene == 22) { this.Close(); }
                else if (scene == 23) { scene = 39; }
                else if (scene == 35) { scene = 39; }
                else if (scene == 24) { scene = 26; }
                else if (scene == 25) { this.Close(); }
                else if (scene == 26) { this.Close(); }
                else if (scene == 27) { scene = 37; }
                else if (scene == 28) { scene = 34; }
                else if (scene == 32) { this.Close(); }
                else if (scene == 33) { this.Close(); }
                else if (scene == 34) { this.Close(); }
                else if (scene == 36) { this.Close(); }
                else if (scene == 37) { this.Close(); }
                else if (scene == 38) { this.Close(); }
                else if (scene == 39) { this.Close(); }
                Refresh();
            }

            else if (e.KeyCode == Keys.N)
            {
                if (scene == 4) { scene = 10; }
                else if (scene == 28) { scene = 33; }
                Refresh();
            }


            switch (scene)
            {
                case 1:
                    outputLabel.Text = "You are in a Fortnite Battle Royale. Pick a skin.";
                    redLabel.Text = "Default";
                    blueLabel.Text = "John Wick";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                  //  reel1.Image = download
                  //reel1.Location = new Point (whatever); 
                    break;
                case 2:
                    outputLabel.Text = "Another player sees you and is trying to trap kill you!";
                    redLabel.Text = "Fight the player";
                    blueLabel.Text = "Rift-To-Go away";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 3:
                    outputLabel.Text = "Where you drop, you only see one other player.";
                    redLabel.Text = "Shoot at the player";
                    blueLabel.Text = "Hide in a bush";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 4:
                    outputLabel.Text = "The other player rips through your shield and you are left with 80 health.";
                    redLabel.Text = "Shoot your rocket launcher";
                    blueLabel.Text = "Shoot your pump shotgun";
                    yellowLabel.Text = "Build walls around you";
                    yellowLabel.Visible = true;
                    break;
                case 5:
                    outputLabel.Text = "You escape safely.";
                    redLabel.Text = "Hide in a bush";
                    blueLabel.Text = "Farm materials";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 6:
                    outputLabel.Text = "The other player uses the rift and follows you!";
                    redLabel.Text = "Build battle the player";
                    blueLabel.Text = "Run away";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 7:
                    outputLabel.Text = "The other player rifts away";
                    redLabel.Text = "Rift after the player";
                    blueLabel.Text = "Don't bother";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 8:
                    outputLabel.Text = "The player sees you in the bush and start shooting!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    Refresh();
                    Thread.Sleep(3000);
                    
                    outputLabel.Text = "Uh Oh! Mr. T sees you playing Fortnite in class";
                    redLabel.Text = "Stop playing like a good child";
                    blueLabel.Text = "Explain to Mr. T that you're being shot at";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    Refresh();
                    break;
                case 9:
                    outputLabel.Text = "You accidently rocket launch the ground below you and you eliminate yourself";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 10:
                    outputLabel.Text = "You accidently build floors instead of walls. Player shoots you easily.";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 11:
                    outputLabel.Text = "You get a head shot dealing 170 damage to the opponent. You get the elimination!";
                    redLabel.Text = "Start dancing";
                    blueLabel.Text = "Don't bother";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 12:
                    outputLabel.Text = "Your shot deals 1 damage to the opponent. The other player kills you easily. ";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 13:
                    outputLabel.Text = "A player sees you in the bush. You get sniped.";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 14:
                    outputLabel.Text = "You are safe... ...for now!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    Refresh();
                    Thread.Sleep(3000);
                    Refresh();
                    outputLabel.Text = "There are 10 people left in the match and you are not in the next circle.";
                    redLabel.Text = "Move to a bush in the next circle";
                    blueLabel.Text = "Build a 1 by 1 in the circle";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 15:
                    outputLabel.Text = "Your Fortnite lags and you die of fall damage!";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 16:
                    outputLabel.Text = "The other player easily shoots you";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 17:
                    outputLabel.Text = "Someone snipes you as you are gliding through the air!";
                    redLabel.Text = "Play again";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 18:
                    outputLabel.Text = "Another player that you did not see snipes you from behind";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 20:
                    //play Orange Justice
                    outputLabel.Text = "There are 3 people left in the match";
                    redLabel.Text = "Engage";
                    blueLabel.Text = "Hide in a bush";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 22:
                    outputLabel.Text = "Bad choice! You lost.";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 23:
                    outputLabel.Text = "Mr. T is very understanding and allows you to keep playing.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = "You shoot back at your opponent and get the elimination";
                    Refresh();
                    Thread.Sleep(3000);
                    Refresh();
                    outputLabel.Text = "There is only one other player left in the match and it's a noob.";
                    redLabel.Text = "Engage";
                    blueLabel.Text = "Hide in a bush";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 24:
                    outputLabel.Text = "There are only 3 people left in the match";
                    redLabel.Text = "Engage";
                    blueLabel.Text = "Hide in a bush";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 25:
                    outputLabel.Text = "You snipe a player! There are only 2 people left";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    Refresh();
                    Thread.Sleep(3000);
                    Refresh();
                    outputLabel.Text = "The school wifi cuts out and your screen freezes. " +
                        "You don't know what happened, but it's safe to say you died.";
                    yellowLabel.Text = "";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";
                    yellowLabel.Visible = false;
                    break;
                case 26:
                    outputLabel.Text = "Someone sees you get into the bush and snipes you.";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 27:
                    outputLabel.Text = "You successfully make it to the next bush";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    Refresh();
                    Thread.Sleep(3000);
                    Refresh();
                    outputLabel.Text = "A player is killed. There are only 2 people left.";
                    redLabel.Text = "Stay in your bush";
                    blueLabel.Text = "Engage";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 28:
                    outputLabel.Text = "What material do you use?";
                    redLabel.Text = "Wood";
                    blueLabel.Text = "Metal";
                    yellowLabel.Text = "Stone";
                    yellowLabel.Visible = true;
                    break;
                case 32:
                    outputLabel.Text = "Someone rocket launches you!";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 33:
                    outputLabel.Text = "A grenade is thrown into your base!";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 34:
                    outputLabel.Text = "You get sniped";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 36:
                    outputLabel.Text = "The other player dies in the storm. You won!";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 37:
                    outputLabel.Text = "Because you're trash, the other player kills you instantly!";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 38:
                    outputLabel.Text = "You're Fortnite crashes. What a shame!";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
                case 39:
                    outputLabel.Text = "The other player dies of fall damage. You won!";
                    redLabel.Text = "Play again";
                    blueLabel.Text = "Exit the game";
                    yellowLabel.Text = "";
                    yellowLabel.Visible = false;
                    break;
            }
        }
    }
}