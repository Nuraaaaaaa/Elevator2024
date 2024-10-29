//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Elevator2024
//{
//    internal class Lift
//    {
//        public void Button1_click(object sender, EventArgs e)
//        {
//            isMovingUp = true;
//            isMovingDown = false;
//            ElevatorTimer.Start();
//            ButtonG.Enabled = false;
//            logEvents("Lift Moving Up");
//        }
//        public void ButtonG_click(object sender, EventArgs e)
//        {
//            isMovingUp = false;
//            isMovingDown = true;
//            ElevatorTimer.Start();
//            Button1.Enabled = false;
//            logEvents("Lift Moving Down");
//        }
//        public void ElevatorTimer_Tick(object sender, EventArgs e)
//        {
//            if (isMovingUp)
//            {
//                Button1.BackColor = Color.LightGreen;
//                if (MyElevator.Top > 0)
//                {
//                    MyElevator.Top -= LiftSpeed;
//                }
//                else
//                {
//                    firstfloorlabel.Text = "1"; //Added
//                    MyElevator.Top = 0;
//                    ElevatorTimer.Stop();
//                    ButtonG.Enabled = true;
//                }
//            }

//            if (isMovingDown)
//            {
//                ButtonG.BackColor = Color.LightGreen;
//                if (MyElevator.Bottom < this.ClientSize.Height)
//                {
//                    MyElevator.Top += LiftSpeed;
//                }
//                else
//                {
//                    firstfloorlabel.Text = "G"; //Added

//                    ElevatorTimer.Stop();
//                    Button1.Enabled = true;
//                }
//            }
//        }
//    }
//}
