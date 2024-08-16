using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_PAD_REMAKE
{
    internal class Sheep : Button
    {
        private short animatorCtr;

        public int posX;
        public int posY;
        public int width;
        public int height;
        public short type;
        public bool team;
        public short row;
        public int moveDir;
        public int defMoveDir;

        public Sheep(bool team, short type, short row, int posX, int posY, int width, int height)
        {
            this.team = team;
            this.type = type;
            this.row = row;
            this.animatorCtr = -1;
            this.posX = posX;
            this.posY = posY;
            this.width = width;
            this.height = height;

            if (team == true) // true = team left
            {
                this.moveDir = this.type;
            }
            else // false = team right
            {
                this.moveDir = this.type*-1;
            }
            
            this.defMoveDir = this.moveDir;
        }

        public Image GetImage()
        {
            if (team)
            {
                if (type == 1)
                {
                    if (animatorCtr == 0) return UTS_PAD_REMAKE.Properties.Resources.run_1;
                    else if (animatorCtr == 1) return UTS_PAD_REMAKE.Properties.Resources.run_2;
                    else if (animatorCtr == 2) return UTS_PAD_REMAKE.Properties.Resources.run_3;
                    else if (animatorCtr == 3) return UTS_PAD_REMAKE.Properties.Resources.run_4;
                    else if (animatorCtr == 4) return UTS_PAD_REMAKE.Properties.Resources.run_5;
                    else
                    {
                        animatorCtr = -1;
                        return UTS_PAD_REMAKE.Properties.Resources.run_6;
                    }
                }
                else if (type == 2)
                {
                    if (animatorCtr == 0) return UTS_PAD_REMAKE.Properties.Resources.push_1;
                    else if (animatorCtr == 1) return UTS_PAD_REMAKE.Properties.Resources.push_2;
                    else
                    {
                        animatorCtr = -1;
                        return UTS_PAD_REMAKE.Properties.Resources.push_3;
                    }
                }
                else
                {
                    if (animatorCtr == 0) return UTS_PAD_REMAKE.Properties.Resources.push_1;
                    else if (animatorCtr == 1) return UTS_PAD_REMAKE.Properties.Resources.push_2;
                    else
                    {
                        animatorCtr = -1;
                        return UTS_PAD_REMAKE.Properties.Resources.push_3;
                    }
                }
            }
            else
            {
                if (type == 1)
                {
                    if (animatorCtr == 0) return UTS_PAD_REMAKE.Properties.Resources.runLeft_1;
                    else if (animatorCtr == 1) return UTS_PAD_REMAKE.Properties.Resources.runLeft_2;
                    else if (animatorCtr == 2) return UTS_PAD_REMAKE.Properties.Resources.runLeft_3;
                    else if (animatorCtr == 3) return UTS_PAD_REMAKE.Properties.Resources.runLeft_4;
                    else if (animatorCtr == 4) return UTS_PAD_REMAKE.Properties.Resources.runLeft_5;
                    else
                    {
                        animatorCtr = -1;
                        return UTS_PAD_REMAKE.Properties.Resources.runLeft_6;
                    }
                }
                else if (type == 2)
                {
                    if (animatorCtr == 0) return UTS_PAD_REMAKE.Properties.Resources.pushLeft_1;
                    else if (animatorCtr == 1) return UTS_PAD_REMAKE.Properties.Resources.pushLeft_2;
                    else
                    {
                        animatorCtr = -1;
                        return UTS_PAD_REMAKE.Properties.Resources.pushLeft_3;
                    }
                }
                else
                {
                    if (animatorCtr == 0) return UTS_PAD_REMAKE.Properties.Resources.runLeft_1;
                    else if (animatorCtr == 1) return UTS_PAD_REMAKE.Properties.Resources.runLeft_2;
                    else if (animatorCtr == 2) return UTS_PAD_REMAKE.Properties.Resources.runLeft_3;
                    else if (animatorCtr == 3) return UTS_PAD_REMAKE.Properties.Resources.runLeft_4;
                    else if (animatorCtr == 4) return UTS_PAD_REMAKE.Properties.Resources.runLeft_5;
                    else
                    {
                        animatorCtr = -1;
                        return UTS_PAD_REMAKE.Properties.Resources.runLeft_6;
                    }
                }
            }
        }

        public void Animate()
        {
            animatorCtr++;
        }

        public void Move()
        {
            this.posX += moveDir;
        }

        public void SetMoveDir(int moveDir)
        {
            this.posX += moveDir;
            
        }
    }
}
