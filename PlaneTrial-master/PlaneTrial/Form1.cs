using System;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.IO;


namespace PlaneTrial
{
    public partial class Form1 : Form
    {
        private static string resources_path = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName + "\\Resources";
        private static string soundtrack_file = resources_path + "\\" + "Fatboy_Slim_-_Acid_8000.mp3";

        private static int spaceShipPos_X;
        private static int spaceShipPos_Y;

        private static int lassersPos_X;
        private static int lassersPos_Y;

        private static int score = 0;
        private static int attempts = 3;
        private static string level = "easy";

        private static int ship_increment   = 18;
        private static int lasser_increment = 28;

        private static Random rnd = new Random();
        private static int[] enemy_increment = { 10, 10, 10, -6, 6, -4, -4 };
        private static int[] enemy_rand_pos  = { 300, 500, 600, 320, 320, 250, 550 };
        private static int[] enemy_restric   = { 522, 522, 522, -87, 824, -121, -121 };
        private static int[] enemy_start_pos = { -125, -125, -125, 830, -90, 549, 549 };

        private static PictureBox[] enemies;
        public Form1() {

            InitializeComponent();

            pause_Button.Enabled = false;
            spaceShipPos_X = spaceShip.Location.X;
            spaceShipPos_Y = spaceShip.Location.Y;

            score_label.Text =  "Score: " + score;
            attempts_label.Text = "Attempts: " + attempts;
            enemies = new PictureBox[7] { rocket1, rocket2, rocket3, leftShip, rightShip, darkShip1, darkShip2 };

            for (int i = 0; i < 3; i++) enemy_rand_pos[i] = rnd.Next(0, 40) * 20;
            for (int i = 3; i < 5; i++) enemy_rand_pos[i] = rnd.Next(0, 25) * 20;
            for (int i = 5; i < enemies.Length; i++) enemy_rand_pos[i] = rnd.Next(0, 40) * 20;

            Mp3Player.open_file(soundtrack_file);
        }

        private async void set_start_pose() {
            spaceShipPos_X = 369;
            spaceShipPos_Y = 399;
            set_position(ref twoLassers, -200, -200);
            set_position(ref spaceShip, spaceShipPos_X, spaceShipPos_Y);
            set_position(ref  leftShip, enemy_start_pos[3], enemy_rand_pos[3]);
            set_position(ref rightShip, enemy_start_pos[4], enemy_rand_pos[4]);


            for (int i=0; i<3; i++) 
                set_position(ref enemies[i], enemy_rand_pos[i], enemy_start_pos[i]);
            for (int i = 5; i < enemies.Length; i++)
                set_position(ref enemies[i], enemy_rand_pos[i], enemy_start_pos[i]);
            
            timer.Stop();
            await Task.Delay(800);
        }
        private void start_ButtonClick(object sender, EventArgs e) {
            Mp3Player.play();
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            if (level == "easy") easy_ButtonClick(sender, e);
            else if (level == "normal") normal_ButtonClick(sender, e);
            else if (level == "hard") hard_ButtonClick(sender, e);
            timer.Start();
            start_Button.Enabled = false;
            pause_Button.Enabled = true;
            score_label.Text = "Score: " + score;
            attempts_label.Text = "Attempts: " + attempts;
        }
        private void easy_ButtonClick(object sender, EventArgs e) {
            level = "easy";
            backGround.Image = Properties.Resources.blue_sky;
            spaceShip.Visible = true;
            rocket1.Visible = true;
            rocket2.Visible = true;
            rocket3.Visible = true;

            leftShip.Visible  = false;
            rightShip.Visible = false;

            darkShip1.Visible = false;
            darkShip2.Visible = false;
        }
        private void normal_ButtonClick(object sender, EventArgs e) {
            level = "normal";
            backGround.Image = Properties.Resources.night_sky;
            spaceShip.Visible = true;
            leftShip.Visible  = true;
            rightShip.Visible = true;

            darkShip1.Visible = false;
            darkShip2.Visible = false;
        }

        private void hard_ButtonClick(object sender, EventArgs e) {
            level = "hard";
            backGround.Image = Properties.Resources.blood_sky;
            spaceShip.Visible = true;
            leftShip.Visible  = true;
            rightShip.Visible = true;

            darkShip1.Visible = true;
            darkShip2.Visible = true;
        }

        private void pause_ButtonClick(object sender, EventArgs e) {
            timer.Stop();
            Mp3Player.stop();
            KeyDown -= new KeyEventHandler(Form1_KeyDown);
            pause_Button.Enabled = false;
            start_Button.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right: 
                    if(spaceShipPos_X < backGround.Width - 130) spaceShipPos_X += ship_increment; 
                    break;
                case Keys.Left:  
                    if(spaceShipPos_X > 5) spaceShipPos_X -= ship_increment; 
                    break;
                case Keys.Up:    
                    if(spaceShipPos_Y > 10) spaceShipPos_Y -= ship_increment; 
                    break;
                case Keys.Down:  
                    if(spaceShipPos_Y < backGround.Height - 100) spaceShipPos_Y += ship_increment; 
                    break;
                case Keys.Space: 
                    lassersPos_X = spaceShipPos_X + 43;
                    lassersPos_Y = spaceShipPos_Y - 50;
                    twoLassers.Visible = true;
                    set_position(ref twoLassers, lassersPos_X, lassersPos_Y);
                    break;
                default: Debug.WriteLine("The button is not useful"); break;
            }

            set_position(ref spaceShip, spaceShipPos_X, spaceShipPos_Y);
        }
        private void timer1_Tick(object sender, EventArgs e) {
            beam_lasser();
            start_level1();
            if (level == "normal" || level == "hard") start_level2();
            if (level == "hard") start_level3();

            for (int i = 0; i < enemies.Length; i++) {
                if (spaceShip.Bounds.IntersectsWith(enemies[i].Bounds) && enemies[i].Visible) {
                    set_start_pose();
                    attempts -= 1;
                    attempts_label.Text = "Attempts: " + attempts;
                    if (attempts < 1) losser(sender, e);
                    else timer.Start();
                }
                if (enemies[i].Bounds.IntersectsWith(twoLassers.Bounds) && enemies[i].Visible) {
                    vanish(ref enemies[i]);
                    if (i < 3) score++;
                    else if (i < 5) score += 3;
                    else score += 5;
                    score_label.Text = "Score: " + score;
                }
            }
        }
        private void vanish(ref PictureBox image) {
            image.Visible = false;
        }
        private void set_position(ref PictureBox image, int x, int y) {
            image.Location = new System.Drawing.Point(x, y);
        }
        private void beam_lasser() {
            if (lassersPos_Y > -200) {
                lassersPos_Y = lassersPos_Y - lasser_increment;
                set_position(ref twoLassers, lassersPos_X, lassersPos_Y);
            }
        }
        private void start_level1() {
            for (int i = 0; i < 3; i++) {
                set_position(ref enemies[i], enemy_rand_pos[i], enemies[i].Location.Y + enemy_increment[i]);

                if (enemies[i].Location.Y >= enemy_restric[i]) {
                    enemy_rand_pos[i] = rnd.Next(0, 40) * 20;
                    set_position(ref enemies[i], enemy_rand_pos[i], enemy_start_pos[i]);
                    enemies[i].Visible = true;
                }
            }
        }
        private void start_level2() {
            set_position(ref enemies[3], enemies[3].Location.X + enemy_increment[3], enemy_rand_pos[3]);
            set_position(ref enemies[4], enemies[4].Location.X + enemy_increment[4], enemy_rand_pos[4]);

            if (enemies[3].Location.X <= enemy_restric[3]) {
                enemy_rand_pos[3] = rnd.Next(0, 25) * 20;
                set_position(ref enemies[3], enemy_start_pos[3], enemy_rand_pos[3]);
                enemies[3].Visible = true;
            }
            if (enemies[4].Location.X >= enemy_restric[4]) {
                enemy_rand_pos[4] = rnd.Next(0, 25) * 20;
                set_position(ref enemies[4], enemy_start_pos[4], enemy_rand_pos[4]);
                enemies[4].Visible = true;
            }
        }
        private void start_level3() {
            for (int i = 5; i < enemies.Length; i++) {
                set_position(ref enemies[i], enemy_rand_pos[i], enemies[i].Location.Y + enemy_increment[i]);

                if (enemies[i].Location.Y <= enemy_restric[i]) {
                    enemy_rand_pos[i] = rnd.Next(0, 40) * 20;
                    set_position(ref enemies[i], enemy_rand_pos[i], enemy_start_pos[i]);
                    enemies[i].Visible = true;
                }
            }
        }
        private void instructions_ButtonClick(object sender, EventArgs e) {
            Instructions instructions = new Instructions();
            instructions.Show();
            pause_ButtonClick(sender, e);
        }
        private void exit_ButtonClick(object sender, EventArgs e) {
            Exit exit = new Exit();
            exit.Show();
            pause_ButtonClick(sender, e);
        }
        private void losser(object sender, EventArgs e) {
            Losser losser = new Losser();
            losser.Show();
            pause_ButtonClick(sender, e);
            backGround.Image = Properties.Resources.intro_sky;
            level = "easy";
            score = 0;
            attempts = 3;
            spaceShip.Visible = false;
        }
        public static int get_score() {
            return score;
        }
        private void level_ButtonClick(object sender, EventArgs e) {
            pause_ButtonClick(sender, e);
        }
    }

    public class Mp3Player
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString,
                                                   int uReturnLength, int hwdCallBack);
        public static void open_file(string File) {

            string Format = @"open ""{0}"" type MPEGVideo alias MediaFile";
            string command = string.Format(Format, File);
            mciSendString(command, null, 0, 0);
            Debug.WriteLine("Sound track path->" + File);
        }
        public static void play() {

            string command = "Play MediaFile";
            mciSendString(command, null, 0, 0);
            Debug.WriteLine("Playing soundtrack");
        }
        public static void stop() {

            string command = "stop MediaFile";
            mciSendString(command, null, 0, 0);
            Debug.WriteLine("Stopping soundtrack");
        }
    }
}
