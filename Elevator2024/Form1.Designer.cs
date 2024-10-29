namespace Elevator2024
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            MyElevator = new PictureBox();
            pictureBox1 = new PictureBox();
            Button1 = new Button();
            ButtonG = new Button();
            ButtonOpen = new Button();
            ButtonClose = new Button();
            ElevatorTimer = new System.Windows.Forms.Timer(components);
            LeftDoor = new PictureBox();
            RightDoor = new PictureBox();
            DoorTimer = new System.Windows.Forms.Timer(components);
            LeftDoor2 = new PictureBox();
            RightDoor2 = new PictureBox();
            dataGridViewLogs = new DataGridView();
            UpButton = new Button();
            UpButton2 = new Button();
            DownButon = new Button();
            DownButton2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            firstfloorlabel = new Label();
            panel3 = new Panel();
            DeleteButton2 = new Button();
            ((System.ComponentModel.ISupportInitialize)MyElevator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LeftDoor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RightDoor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LeftDoor2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RightDoor2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MyElevator
            // 
            MyElevator.BackgroundImage = Properties.Resources.GoldOpen;
            MyElevator.BackgroundImageLayout = ImageLayout.Stretch;
            MyElevator.Location = new Point(128, 434);
            MyElevator.Name = "MyElevator";
            MyElevator.Size = new Size(180, 251);
            MyElevator.TabIndex = 0;
            MyElevator.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.PlainGold;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(480, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 327);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Button1
            // 
            Button1.BackgroundImage = Properties.Resources.Button1Gold;
            Button1.BackgroundImageLayout = ImageLayout.Stretch;
            Button1.Location = new Point(556, 147);
            Button1.Name = "Button1";
            Button1.Size = new Size(55, 52);
            Button1.TabIndex = 2;
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_click;
            // 
            // ButtonG
            // 
            ButtonG.BackgroundImage = Properties.Resources.ButtonGGold;
            ButtonG.BackgroundImageLayout = ImageLayout.Stretch;
            ButtonG.Location = new Point(556, 233);
            ButtonG.Name = "ButtonG";
            ButtonG.Size = new Size(55, 53);
            ButtonG.TabIndex = 3;
            ButtonG.UseVisualStyleBackColor = true;
            ButtonG.Click += ButtonG_click;
            // 
            // ButtonOpen
            // 
            ButtonOpen.BackgroundImage = Properties.Resources.closebutton;
            ButtonOpen.BackgroundImageLayout = ImageLayout.Stretch;
            ButtonOpen.Location = new Point(507, 347);
            ButtonOpen.Name = "ButtonOpen";
            ButtonOpen.Size = new Size(56, 56);
            ButtonOpen.TabIndex = 4;
            ButtonOpen.UseVisualStyleBackColor = true;
            ButtonOpen.Click += Button_Open_Click;
            // 
            // ButtonClose
            // 
            ButtonClose.BackgroundImage = Properties.Resources.closebutton1;
            ButtonClose.BackgroundImageLayout = ImageLayout.Stretch;
            ButtonClose.Location = new Point(606, 347);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(56, 56);
            ButtonClose.TabIndex = 5;
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += Button_Close_Click;
            // 
            // ElevatorTimer
            // 
            ElevatorTimer.Interval = 30;
            // 
            // LeftDoor
            // 
            LeftDoor.BackgroundImage = Properties.Resources.GoldLeftDoor;
            LeftDoor.BackgroundImageLayout = ImageLayout.Stretch;
            LeftDoor.Location = new Point(128, 435);
            LeftDoor.Name = "LeftDoor";
            LeftDoor.Size = new Size(92, 251);
            LeftDoor.TabIndex = 6;
            LeftDoor.TabStop = false;
            LeftDoor.Click += Button_Close_Click;
            // 
            // RightDoor
            // 
            RightDoor.BackgroundImage = Properties.Resources.GoldRightDoor;
            RightDoor.BackgroundImageLayout = ImageLayout.Stretch;
            RightDoor.Location = new Point(220, 435);
            RightDoor.Name = "RightDoor";
            RightDoor.Size = new Size(89, 251);
            RightDoor.TabIndex = 7;
            RightDoor.TabStop = false;
            // 
            // LeftDoor2
            // 
            LeftDoor2.BackgroundImage = Properties.Resources.GoldLeftDoor1;
            LeftDoor2.BackgroundImageLayout = ImageLayout.Stretch;
            LeftDoor2.Location = new Point(128, -1);
            LeftDoor2.Name = "LeftDoor2";
            LeftDoor2.Size = new Size(92, 251);
            LeftDoor2.TabIndex = 9;
            LeftDoor2.TabStop = false;
            // 
            // RightDoor2
            // 
            RightDoor2.BackgroundImage = Properties.Resources.GoldRightDoor1;
            RightDoor2.BackgroundImageLayout = ImageLayout.Stretch;
            RightDoor2.Location = new Point(220, -1);
            RightDoor2.Name = "RightDoor2";
            RightDoor2.Size = new Size(92, 251);
            RightDoor2.TabIndex = 10;
            RightDoor2.TabStop = false;
            // 
            // dataGridViewLogs
            // 
            dataGridViewLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLogs.Location = new Point(925, 56);
            dataGridViewLogs.Name = "dataGridViewLogs";
            dataGridViewLogs.RowHeadersWidth = 51;
            dataGridViewLogs.Size = new Size(415, 720);
            dataGridViewLogs.TabIndex = 11;
            // 
            // UpButton
            // 
            UpButton.BackgroundImage = Properties.Resources.UpGButton2;
            UpButton.BackgroundImageLayout = ImageLayout.Stretch;
            UpButton.Location = new Point(385, 110);
            UpButton.Name = "UpButton";
            UpButton.Size = new Size(31, 33);
            UpButton.TabIndex = 12;
            UpButton.UseVisualStyleBackColor = true;
            // 
            // UpButton2
            // 
            UpButton2.BackgroundImage = Properties.Resources.UpGButton3;
            UpButton2.BackgroundImageLayout = ImageLayout.Stretch;
            UpButton2.Location = new Point(385, 524);
            UpButton2.Name = "UpButton2";
            UpButton2.Size = new Size(31, 29);
            UpButton2.TabIndex = 13;
            UpButton2.UseVisualStyleBackColor = true;
            UpButton2.Click += ButtonG_click;
            // 
            // DownButon
            // 
            DownButon.BackgroundImage = Properties.Resources.DownButton;
            DownButon.BackgroundImageLayout = ImageLayout.Stretch;
            DownButon.Location = new Point(385, 138);
            DownButon.Name = "DownButon";
            DownButon.Size = new Size(31, 33);
            DownButon.TabIndex = 14;
            DownButon.UseVisualStyleBackColor = true;
            DownButon.Click += Button1_click;
            // 
            // DownButton2
            // 
            DownButton2.BackgroundImage = Properties.Resources.DownButton;
            DownButton2.BackgroundImageLayout = ImageLayout.Stretch;
            DownButton2.Location = new Point(385, 550);
            DownButton2.Name = "DownButton2";
            DownButton2.Size = new Size(31, 29);
            DownButton2.TabIndex = 15;
            DownButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(522, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(115, 45);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(firstfloorlabel);
            panel2.Location = new Point(385, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(31, 45);
            panel2.TabIndex = 17;
            // 
            // firstfloorlabel
            // 
            firstfloorlabel.AutoSize = true;
            firstfloorlabel.Location = new Point(14, 16);
            firstfloorlabel.Name = "firstfloorlabel";
            firstfloorlabel.Size = new Size(19, 20);
            firstfloorlabel.TabIndex = 0;
            firstfloorlabel.Text = "G";
            // 
            // panel3
            // 
            panel3.Location = new Point(385, 482);
            panel3.Name = "panel3";
            panel3.Size = new Size(31, 45);
            panel3.TabIndex = 17;
            // 
            // DeleteButton2
            // 
            DeleteButton2.Location = new Point(1209, 21);
            DeleteButton2.Name = "DeleteButton2";
            DeleteButton2.Size = new Size(131, 29);
            DeleteButton2.TabIndex = 18;
            DeleteButton2.Text = "Clear All Data";
            DeleteButton2.UseVisualStyleBackColor = true;
            DeleteButton2.Click += DeleteButton;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 674);
            Controls.Add(DeleteButton2);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(DownButton2);
            Controls.Add(DownButon);
            Controls.Add(UpButton2);
            Controls.Add(UpButton);
            Controls.Add(dataGridViewLogs);
            Controls.Add(RightDoor2);
            Controls.Add(LeftDoor2);
            Controls.Add(RightDoor);
            Controls.Add(LeftDoor);
            Controls.Add(ButtonClose);
            Controls.Add(ButtonOpen);
            Controls.Add(ButtonG);
            Controls.Add(Button1);
            Controls.Add(pictureBox1);
            Controls.Add(MyElevator);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_load;
            Click += DeleteButton;
            ((System.ComponentModel.ISupportInitialize)MyElevator).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)LeftDoor).EndInit();
            ((System.ComponentModel.ISupportInitialize)RightDoor).EndInit();
            ((System.ComponentModel.ISupportInitialize)LeftDoor2).EndInit();
            ((System.ComponentModel.ISupportInitialize)RightDoor2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox MyElevator;
        private PictureBox pictureBox1;
        private Button Button1;
        private Button ButtonG;
        private Button ButtonOpen;
        private Button ButtonClose;
        private System.Windows.Forms.Timer ElevatorTimer;
        private PictureBox LeftDoor;
        private PictureBox RightDoor;
        private System.Windows.Forms.Timer DoorTimer;
        private PictureBox LeftDoor2;
        private PictureBox RightDoor2;
        private DataGridView dataGridViewLogs;
        private Button UpButton;
        private Button UpButton2;
        private Button DownButon;
        private Button DownButton2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label firstfloorlabel;
        private Button DeleteButton2;
        //private Button DeleteButton;
    }
}
