using System.Drawing;
using System.Windows.Forms;

namespace UTS_PAD_REMAKE
{
    public partial class Form1 : Form
    {
        List<Sheep> sheepList = new List<Sheep>();
        List<Sheep> topLeftSheep = new List<Sheep>();
        List<Sheep> midLeftSheep = new List<Sheep>();
        List<Sheep> botLeftSheep = new List<Sheep>();
        List<Sheep> topRightSheep = new List<Sheep>();
        List<Sheep> midRightSheep = new List<Sheep>();
        List<Sheep> botRightSheep = new List<Sheep>();
        int CooldownL = 0;
        int CooldownR = 0;
        int PlayerLeftPoint = 0;
        int PlayerRightPoint = 0;

        int topLeftStrength = 0;
        int topRightStrength = 0;
        int midLeftStrength = 0;
        int midRightStrength = 0;
        int botLeftStrength = 0;
        int botRightStrength = 0;

        int gameTimer = 120;
        short minute = 0;

        public Form1()
        {
            InitializeComponent();

            pl_label.Text = PlayerLeftPoint.ToString() + " Pts";
            pr_label.Text = PlayerRightPoint.ToString() + " Pts";
        }



        private void SpawnSheep(int locationX, int locationY, bool team, short row)
        {
            Random type_r = new Random();
            short type = (short)type_r.Next(1, 3);
            int width, height;

            if (type == 1)
            {
                width = 63;
                height = 56;
            }
            else
            {
                width = 160;
                height = 80;
            }
            Sheep sheep = new Sheep(team, type, row, locationX, locationY, width, height);
            sheepList.Add(sheep);

            if (team)
            {
                if (row == 1)
                {
                    if (topLeftSheep.Count <= 2)
                    {
                        topLeftSheep.Add(sheep);
                    }
                }
                else if (row == 2)
                {
                    if (midLeftSheep.Count <= 2) {
                        midLeftSheep.Add(sheep);
                    }

                }
                else {
                    if(botLeftSheep.Count <= 2)
                    {
                        botLeftSheep.Add(sheep);
                    }
                }
            }
            else
            {
                if (row == 1)
                {
                    if(topRightSheep.Count <= 2) topRightSheep.Add(sheep);
                }
                else if (row == 2)
                {
                    if(midRightSheep.Count <= 2) midRightSheep.Add(sheep);
                }
                else
                {
                    if(botRightSheep.Count <= 2) botRightSheep.Add(sheep);
                }
            }


            if (team)
            {
                CooldownL = type * 2;
            }
            else
            {
                CooldownR = type * 2;
            }
        }

        private void spawn_leftTop_Click(object sender, EventArgs e)
        {
            if (CooldownL == 0)
            {
                SpawnSheep(spawn_leftTop.Location.X + spawn_leftTop.Size.Width + 25, spawn_leftTop.Location.Y, true, 1);
            }
        }

        private void spawn_leftMid_Click(object sender, EventArgs e)
        {
            if (CooldownL == 0)
            {
                SpawnSheep(spawn_leftMid.Location.X + spawn_leftMid.Size.Width + 25, spawn_leftMid.Location.Y, true, 2);
            }
        }

        private void spawn_leftBot_Click(object sender, EventArgs e)
        {
            if (CooldownL == 0)
            {
                SpawnSheep(spawn_leftBot.Location.X + spawn_leftBot.Size.Width + 25, spawn_leftBot.Location.Y, true, 3);
            }
        }

        private void spawn_rightTop_Click(object sender, EventArgs e)
        {
            if (CooldownR == 0)
            {
                SpawnSheep(spawn_rightTop.Location.X - (63 + 25), spawn_rightTop.Location.Y, false, 1);
            }
        }

        private void spawn_rightMid_Click(object sender, EventArgs e)
        {
            if (CooldownR == 0)
            {
                SpawnSheep(spawn_rightMid.Location.X - (63 + 25), spawn_rightMid.Location.Y, false, 2);
            }
        }

        private void spawn_rightBot_Click(object sender, EventArgs e)
        {
            if (CooldownR == 0)
            {
                SpawnSheep(spawn_rightBot.Location.X - (63 + 25), spawn_rightBot.Location.Y, false, 3);
            }
        }

        private void AnimatorTimer_Tick(object sender, EventArgs e)
        {
            if (sheepList.Count > 0)
            {
                List<Sheep> removeSheep = new List<Sheep>();
                foreach (Sheep sheep in sheepList)
                {
                    sheep.Animate();
                    sheep.Move();

                    if (sheep.posX >= spawn_rightBot.Location.X)
                    {
                        if(sheep.team) PlayerLeftPoint += (sheep.type * 25);
                        pl_label.Text = PlayerLeftPoint + " Pts";
                        removeSheep.Add(sheep);
                        if (sheep.row == 1)
                        {
                            topLeftStrength--;
                            topLeftSheep.Remove(sheep);
                        }
                        else if (sheep.row == 2)
                        {
                            midLeftStrength--;
                            midLeftSheep.Remove(sheep);
                        }
                        else
                        {
                            botLeftStrength--;
                            botLeftSheep.Remove(sheep);
                        }
                    }

                    if (sheep.posX <= spawn_leftBot.Location.X)
                    {
                        if(!sheep.team) PlayerRightPoint += (sheep.type * 25);
                        pr_label.Text = PlayerRightPoint + " Pts";
                        removeSheep.Add(sheep);

                        if (sheep.row == 1)
                        {
                            topRightStrength++;
                            topRightSheep.Remove(sheep);
                        }
                        else if (sheep.row == 2)
                        {
                            midRightStrength++;
                            midRightSheep.Remove(sheep);
                        }
                        else
                        {
                            botRightStrength++;
                            botRightSheep.Remove(sheep);
                        }
                    }
                }

                foreach (Sheep sheepr in removeSheep)
                {
                    sheepList.Remove(sheepr);
                }

                Invalidate();
            }
        }

        private void SpawnTimer_Tick(object sender, EventArgs e)
        {
            if (CooldownL > 0)
            {
                CooldownL--;
            }

            if (CooldownR > 0)
            {
                CooldownR--;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (Sheep sheep in sheepList)
            {
                g.DrawImage(sheep.GetImage(), sheep.posX, sheep.posY, sheep.width, sheep.height);
            }
        }

        private void CountStrength()
        {
            foreach (Sheep sheep in topLeftSheep)
            {
                int i = 0;
                foreach (Sheep sheepl in topLeftSheep)
                {
                    if (sheepl.posX != sheep.posX && sheepl.posX + sheepl.width == sheep.posX)
                    {
                        sheepl.posX -= sheepl.moveDir;
                    }

                    i += sheepl.moveDir;
                }

                topLeftStrength = i;
            }

            foreach (Sheep sheep in midLeftSheep)
            {
                int i = 0;
                foreach (Sheep sheepl in midLeftSheep)
                {
                    if (sheepl.posX != sheep.posX && sheepl.posX + sheepl.width == sheep.posX)
                    {
                        sheepl.posX -= sheepl.moveDir;
                    }

                    i += sheepl.moveDir;
                }
                midLeftStrength = i;
            }

            foreach(Sheep sheep in botLeftSheep)
            {
                int i = 0;
                foreach (Sheep sheepl in botLeftSheep)
                {
                    if (sheepl.posX != sheep.posX && sheepl.posX + sheepl.width == sheep.posX)
                    {
                        sheepl.posX -= sheepl.moveDir;
                    }

                    i += sheepl.moveDir;
                }
                botLeftStrength = i;
            }

            foreach (Sheep sheep in topRightSheep)
            {
                int i = 0;
                foreach (Sheep sheepl in topRightSheep)
                {
                    if (sheepl.posX != sheep.posX && sheepl.posX + sheepl.width == sheep.posX)
                    {
                        sheepl.posX -= sheepl.moveDir;
                    }

                    i += sheepl.moveDir;
                }

                topRightStrength = i;
            }

            foreach (Sheep sheep in midRightSheep)
            {
                int i = 0;
                foreach (Sheep sheepl in midRightSheep)
                {
                    if (sheepl.posX != sheep.posX && sheepl.posX + sheepl.width == sheep.posX)
                    {
                        sheepl.posX -= sheepl.moveDir;
                    }

                    i += sheepl.moveDir;
                }

                midRightStrength = i;
            }

            foreach (Sheep sheep in botRightSheep)
            {
                int i = 0;
                foreach (Sheep sheepl in botRightSheep)
                {
                    if (sheepl.posX != sheep.posX && sheepl.posX + sheepl.width == sheep.posX)
                    {
                        sheepl.posX -= sheepl.moveDir;
                    }

                    i += sheepl.moveDir;
                }

                botRightStrength = i;
            }

        }

        private void CrashTimer_Tick(object sender, EventArgs e)
        {
            CountStrength();

            foreach (Sheep sheepl in topLeftSheep)
            {
                foreach (Sheep sheepr in topRightSheep)
                {
                    if (sheepl.posX + sheepl.width > sheepr.posX)
                    {
                        sheepl.posX += sheepr.moveDir + topRightStrength;
                        sheepr.posX += sheepl.moveDir + topLeftStrength;
                    }
                }
            }

            foreach (Sheep sheepl in midLeftSheep)
            {
                foreach (Sheep sheepr in midRightSheep)
                {
                    if (sheepl.posX + sheepl.width > sheepr.posX)
                    {
                        sheepl.posX += sheepr.moveDir + midRightStrength;
                        sheepr.posX += sheepl.moveDir + midLeftStrength;
                    }
                }
            }

            foreach (Sheep sheepl in botLeftSheep)
            {
                foreach (Sheep sheepr in botRightSheep)
                {
                    if (sheepl.posX + sheepl.width > sheepr.posX)
                    {
                        sheepl.posX += sheepr.moveDir + botRightStrength;
                        sheepr.posX += sheepl.moveDir + botLeftStrength;
                    }
                }
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            gameTimer--;

            if(gameTimer == 0)
            {
                GameTimer.Stop();
                AnimatorTimer.Stop();
                SpawnTimer.Stop();
                CrashTimer.Stop();

                sheepList.Clear();
                topLeftSheep.Clear();
                midLeftSheep.Clear();
                botLeftSheep.Clear();
                topRightSheep.Clear();
                midRightSheep.Clear();
                botRightSheep.Clear();

                string winner = (PlayerRightPoint>PlayerLeftPoint)? "Conratulations Player Right!" : (PlayerRightPoint==PlayerLeftPoint) ? "Draw!" : "Conratulations Player Left!";
                int choice = (int)MessageBox.Show(winner, "GAME ENDED!", MessageBoxButtons.OK);

                this.Close();
            }

            timeLabel.Text = Math.Abs(gameTimer/60) + " : " + (gameTimer % 60);
        }
    }
}
