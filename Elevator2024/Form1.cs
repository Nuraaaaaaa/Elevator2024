using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Elevator2024
{
    public partial class Form1 : Form
    {
        bool isMovingUp = false;
        bool isMovingDown = false;
        int LiftSpeed = 5;
        bool isClosing = false;
        bool isOpening = false;
        int doorSpeed = 5;

        int doorMaxOpenWidth;

        DBContext dbContext = new DBContext();

        string connectionString = @"Server = LAPTOP-1HGG9AAR; Database = NuraTest; Trusted_Connection= True;";

        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            doorMaxOpenWidth = MyElevator.Width / 2 + 50;

            dataGridViewLogs.ColumnCount = 4; // changed from 2 to 3
            dataGridViewLogs.Columns[0].Name = "Id"; //Added this new line to display Ids
            dataGridViewLogs.Columns[1].Name = "Time";
            dataGridViewLogs.Columns[2].Name = "Events";
            dataGridViewLogs.Columns[3].Name = "Date"; //Added this new line for date

            dt.Columns.Add("Id");
            dt.Columns.Add("LogTime");
            dt.Columns.Add("EventDescription");
            dt.Columns.Add("LogDate"); //Added this new line for Date 

        }

        private void logEvents(string message)
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss");
            string currentDate = DateTime.Now.ToString("yyyy:MM:dd");

            dt.Rows.Add(currentTime, message, currentDate);

            dataGridViewLogs.Rows.Add(currentTime, message, currentDate);

            dbContext.InsertLogsIntoDB(dt);

        }

        
        

        private void Form1_load(object sender, EventArgs e)
        {
            dbContext.loadLogsFromDB(dt, dataGridViewLogs);
        }

        public void Button1_click(object sender, EventArgs e)
        {
            isMovingUp = true;
            isMovingDown = false;
            ElevatorTimer.Start();
            ButtonG.Enabled = false;
            logEvents("Lift Moving Up");
        }
        public void ButtonG_click(object sender, EventArgs e)
        {
            isMovingUp = false;
            isMovingDown = true;
            ElevatorTimer.Start();
            Button1.Enabled = false;
            logEvents("Lift Moving Down");
        }

        private void Button_Open_Click(object sender, EventArgs e)
        {
            isOpening = true;
            isClosing = false;
            DoorTimer.Start();
            ButtonClose.Enabled = false;
            logEvents("Lift is Opening");
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            isClosing = true;
            isOpening = false;
            DoorTimer.Start();
            logEvents("Lift is Closing");
        }

        private void DeleteButton(object sender, EventArgs e)
        {
            dbContext.DeleteLogs();
            dbContext.loadLogsFromDB(dt, dataGridViewLogs);

        }

        /*private void Door_Timer_Tick (object sender, EventArgs e)
        {   if(MyElevator.Top != 0)
            {

            if (isOpening)
            {
                if(LeftDoor.Left > doorMaxOpenWidth / 2 )
                {
                    LeftDoor.Left -= doorSpeed;
                    RightDoor.Left += doorSpeed;
                }
                else
                {
                    DoorTimer.Stop();
                    ButtonClose.Enabled = true;
                }

            }

                if (isClosing)
                {
                    if (LeftDoor.Right < MyElevator.Width + doorMaxOpenWidth / 2 - 30)
                    {
                        LeftDoor.Left += doorSpeed;
                        RightDoor.Left -= doorSpeed;
                    }
                    else
                    {
                        DoorTimer.Stop();
                    }
                }  
            }
            else
            {

                if (isOpening)
                {
                    if (LeftDoor2.Left > doorMaxOpenWidth / 2)
                    {
                        LeftDoor2.Left -= doorSpeed;
                        RightDoor2.Left += doorSpeed;
                    }
                    else
                    {
                        DoorTimer.Stop();
                        ButtonClose.Enabled = true;
                    }

                }

                if (isClosing)
                {
                    if (LeftDoor2.Right < MyElevator.Width + doorMaxOpenWidth / 2 - 30)
                    {
                        LeftDoor2.Left += doorSpeed;
                        RightDoor2.Left -= doorSpeed;
                    }
                    else
                    {
                        DoorTimer.Stop();
                    }
                }
            }
        
        }*/

        /*public void ElevatorTimer_Tick(object sender, EventArgs e)
        {
            if (isMovingUp)
            {
                Button1.BackColor = Color.LightGreen;
                if (MyElevator.Top > 0)
                {
                    MyElevator.Top -= LiftSpeed;
                }
                else
                {
                    firstfloorlabel.Text = "1"; //Added
                    MyElevator.Top = 0;
                    ElevatorTimer.Stop();
                    ButtonG.Enabled = true;
                }
            }
            
            if (isMovingDown)
            {
                ButtonG.BackColor = Color.LightGreen;
                if(MyElevator.Bottom < this.ClientSize.Height)
                {
                    MyElevator.Top += LiftSpeed;
                }
                else
                {
                    firstfloorlabel.Text = "G"; //Added

                    ElevatorTimer.Stop();
                    Button1.Enabled = true;
                }
            }
        }*/


    }

}
