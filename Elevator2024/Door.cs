using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace Elevator2024
{
    internal class Door
    {
        PictureBox myElevator;
        PictureBox leftDoor;
        PictureBox rightDoor;
        PictureBox leftDoor2;
        PictureBox rightDoor2;
        bool isOpening;
        bool isClosing;
        int doorSpeed;
        int doorMaxOpenWidth;

        Timer doorTimer;

        Button buttonClose;
        public Door()
        {
            
        }

        public Door(PictureBox myElevator,
        PictureBox leftDoor,
        PictureBox rightDoor,
        PictureBox leftDoor2,
        PictureBox rightDoor2,
        bool isOpening,
        bool isClosing,
        int doorSpeed,
        int doorMaxOpenWidth,

        Timer doorTimer,

        Button buttonClose)
            {
                this.myElevator = myElevator;
            this.leftDoor = leftDoor;
            this.rightDoor = rightDoor;
            this.leftDoor2 = leftDoor2;
            this.rightDoor2 = rightDoor2;
            this.doorSpeed = doorSpeed;
            this.isOpening = isOpening;
            this.isClosing = isClosing;
            this.doorMaxOpenWidth = doorMaxOpenWidth;
            }
        private void Button_Open_Click(object sender, EventArgs e)
        {
            isOpening = true;
            isClosing = false;
            doorTimer.Start();
            buttonClose.Enabled = false;
            //logEvents("Lift is Opening");
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            isClosing = true;
            isOpening = false;
            doorTimer.Start();
            //logEvents("Lift is Closing");
        }
        private void Door_Timer_Tick(object sender, EventArgs e)
        {
            if (myElevator.Top != 0)
            {

                if (isOpening)
                {
                    if (leftDoor.Left > doorMaxOpenWidth / 2)
                    {
                        leftDoor.Left -= doorSpeed;
                        rightDoor.Left += doorSpeed;
                    }
                    else
                    {
                        doorTimer.Stop();
                        buttonClose.Enabled = true;
                    }

                }

                if (isClosing)
                {
                    if (leftDoor.Right < myElevator.Width + doorMaxOpenWidth / 2 - 30)
                    {
                        leftDoor.Left += doorSpeed;
                        rightDoor.Left -= doorSpeed;
                    }
                    else
                    {
                        doorTimer.Stop();
                    }
                }
            }
            else
            {

                if (isOpening)
                {
                    if (leftDoor2.Left > doorMaxOpenWidth / 2)
                    {
                        leftDoor2.Left -= doorSpeed;
                        rightDoor2.Left += doorSpeed;
                    }
                    else
                    {
                        doorTimer.Stop();
                        buttonClose.Enabled = true;
                    }

                }

                if (isClosing)
                {
                    if (leftDoor2.Right < myElevator.Width + doorMaxOpenWidth / 2 - 30)
                    {
                        leftDoor2.Left += doorSpeed;
                        rightDoor2.Left -= doorSpeed;
                    }
                    else
                    {
                        doorTimer.Stop();
                    }
                }
            }

        } 
    }
}
