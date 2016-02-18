namespace QTetris
{
    partial class TetrisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbTetrisMap = new System.Windows.Forms.PictureBox();
            this.bStart = new System.Windows.Forms.Button();
            this.lMapX = new System.Windows.Forms.Label();
            this.lMapY = new System.Windows.Forms.Label();
            this.tbMapX = new System.Windows.Forms.TextBox();
            this.tbMapY = new System.Windows.Forms.TextBox();
            this.timerFall = new System.Windows.Forms.Timer(this.components);
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.lSpeed = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.lPoints = new System.Windows.Forms.Label();
            this.gbPoints = new System.Windows.Forms.GroupBox();
            this.gbNewGame = new System.Windows.Forms.GroupBox();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbNextItem = new System.Windows.Forms.GroupBox();
            this.pbFallItem = new System.Windows.Forms.PictureBox();
            this.gbHighScore = new System.Windows.Forms.GroupBox();
            this.lbHighScore = new System.Windows.Forms.ListBox();
            this.gbLevel = new System.Windows.Forms.GroupBox();
            this.lLevel = new System.Windows.Forms.Label();
            this.tbPoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTetrisMap)).BeginInit();
            this.gbPoints.SuspendLayout();
            this.gbNewGame.SuspendLayout();
            this.gbNextItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFallItem)).BeginInit();
            this.gbHighScore.SuspendLayout();
            this.gbLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTetrisMap
            // 
            this.pbTetrisMap.Location = new System.Drawing.Point(124, 21);
            this.pbTetrisMap.Name = "pbTetrisMap";
            this.pbTetrisMap.Size = new System.Drawing.Size(200, 400);
            this.pbTetrisMap.TabIndex = 0;
            this.pbTetrisMap.TabStop = false;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(6, 20);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(87, 22);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // lMapX
            // 
            this.lMapX.AutoSize = true;
            this.lMapX.Location = new System.Drawing.Point(3, 48);
            this.lMapX.Name = "lMapX";
            this.lMapX.Size = new System.Drawing.Size(47, 13);
            this.lMapX.TabIndex = 2;
            this.lMapX.Text = "Map X:";
            // 
            // lMapY
            // 
            this.lMapY.AutoSize = true;
            this.lMapY.Location = new System.Drawing.Point(3, 70);
            this.lMapY.Name = "lMapY";
            this.lMapY.Size = new System.Drawing.Size(46, 13);
            this.lMapY.TabIndex = 3;
            this.lMapY.Text = "Map Y:";
            // 
            // tbMapX
            // 
            this.tbMapX.Location = new System.Drawing.Point(52, 45);
            this.tbMapX.Name = "tbMapX";
            this.tbMapX.Size = new System.Drawing.Size(41, 21);
            this.tbMapX.TabIndex = 4;
            this.tbMapX.Text = "8";
            // 
            // tbMapY
            // 
            this.tbMapY.Location = new System.Drawing.Point(52, 67);
            this.tbMapY.Name = "tbMapY";
            this.tbMapY.Size = new System.Drawing.Size(41, 21);
            this.tbMapY.TabIndex = 5;
            this.tbMapY.Text = "20";
            // 
            // timerFall
            // 
            this.timerFall.Interval = 1000;
            this.timerFall.Tick += new System.EventHandler(this.timerFall_Tick);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // lSpeed
            // 
            this.lSpeed.AutoSize = true;
            this.lSpeed.Location = new System.Drawing.Point(6, 42);
            this.lSpeed.Name = "lSpeed";
            this.lSpeed.Size = new System.Drawing.Size(48, 13);
            this.lSpeed.TabIndex = 7;
            this.lSpeed.Text = "Speed:";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Enabled = false;
            this.tbSpeed.Location = new System.Drawing.Point(9, 58);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(82, 21);
            this.tbSpeed.TabIndex = 8;
            this.tbSpeed.Text = "1000";
            // 
            // lPoints
            // 
            this.lPoints.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPoints.Location = new System.Drawing.Point(7, 19);
            this.lPoints.Name = "lPoints";
            this.lPoints.Size = new System.Drawing.Size(111, 23);
            this.lPoints.TabIndex = 10;
            this.lPoints.Text = "0";
            this.lPoints.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbPoints
            // 
            this.gbPoints.Controls.Add(this.lPoints);
            this.gbPoints.Location = new System.Drawing.Point(339, 21);
            this.gbPoints.Name = "gbPoints";
            this.gbPoints.Size = new System.Drawing.Size(125, 53);
            this.gbPoints.TabIndex = 11;
            this.gbPoints.TabStop = false;
            this.gbPoints.Text = "Points";
            // 
            // gbNewGame
            // 
            this.gbNewGame.Controls.Add(this.cbLevel);
            this.gbNewGame.Controls.Add(this.label1);
            this.gbNewGame.Controls.Add(this.bStart);
            this.gbNewGame.Controls.Add(this.lMapX);
            this.gbNewGame.Controls.Add(this.tbMapX);
            this.gbNewGame.Controls.Add(this.lMapY);
            this.gbNewGame.Controls.Add(this.tbMapY);
            this.gbNewGame.Location = new System.Drawing.Point(10, 21);
            this.gbNewGame.Name = "gbNewGame";
            this.gbNewGame.Size = new System.Drawing.Size(99, 118);
            this.gbNewGame.TabIndex = 12;
            this.gbNewGame.TabStop = false;
            this.gbNewGame.Text = "New game";
            // 
            // cbLevel
            // 
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Location = new System.Drawing.Point(52, 90);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(41, 21);
            this.cbLevel.TabIndex = 7;
            this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Level:";
            // 
            // gbNextItem
            // 
            this.gbNextItem.Controls.Add(this.pbFallItem);
            this.gbNextItem.Location = new System.Drawing.Point(339, 91);
            this.gbNextItem.Name = "gbNextItem";
            this.gbNextItem.Size = new System.Drawing.Size(125, 131);
            this.gbNextItem.TabIndex = 13;
            this.gbNextItem.TabStop = false;
            this.gbNextItem.Text = "Next item";
            // 
            // pbFallItem
            // 
            this.pbFallItem.Location = new System.Drawing.Point(11, 20);
            this.pbFallItem.Name = "pbFallItem";
            this.pbFallItem.Size = new System.Drawing.Size(100, 100);
            this.pbFallItem.TabIndex = 0;
            this.pbFallItem.TabStop = false;
            // 
            // gbHighScore
            // 
            this.gbHighScore.Controls.Add(this.lbHighScore);
            this.gbHighScore.Location = new System.Drawing.Point(339, 238);
            this.gbHighScore.Name = "gbHighScore";
            this.gbHighScore.Size = new System.Drawing.Size(125, 183);
            this.gbHighScore.TabIndex = 14;
            this.gbHighScore.TabStop = false;
            this.gbHighScore.Text = "High Score";
            // 
            // lbHighScore
            // 
            this.lbHighScore.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbHighScore.FormattingEnabled = true;
            this.lbHighScore.ItemHeight = 14;
            this.lbHighScore.Location = new System.Drawing.Point(6, 20);
            this.lbHighScore.Name = "lbHighScore";
            this.lbHighScore.Size = new System.Drawing.Size(112, 144);
            this.lbHighScore.TabIndex = 0;
            // 
            // gbLevel
            // 
            this.gbLevel.Controls.Add(this.lLevel);
            this.gbLevel.Controls.Add(this.tbPoint);
            this.gbLevel.Controls.Add(this.label2);
            this.gbLevel.Controls.Add(this.lSpeed);
            this.gbLevel.Controls.Add(this.tbSpeed);
            this.gbLevel.Location = new System.Drawing.Point(10, 145);
            this.gbLevel.Name = "gbLevel";
            this.gbLevel.Size = new System.Drawing.Size(99, 125);
            this.gbLevel.TabIndex = 15;
            this.gbLevel.TabStop = false;
            this.gbLevel.Text = "Level";
            // 
            // lLevel
            // 
            this.lLevel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lLevel.Location = new System.Drawing.Point(6, 17);
            this.lLevel.Name = "lLevel";
            this.lLevel.Size = new System.Drawing.Size(85, 19);
            this.lLevel.TabIndex = 11;
            this.lLevel.Text = "L1";
            this.lLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPoint
            // 
            this.tbPoint.Enabled = false;
            this.tbPoint.Location = new System.Drawing.Point(9, 98);
            this.tbPoint.Name = "tbPoint";
            this.tbPoint.Size = new System.Drawing.Size(82, 21);
            this.tbPoint.TabIndex = 10;
            this.tbPoint.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Point:";
            // 
            // TetrisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 440);
            this.Controls.Add(this.gbLevel);
            this.Controls.Add(this.gbHighScore);
            this.Controls.Add(this.gbNextItem);
            this.Controls.Add(this.gbNewGame);
            this.Controls.Add(this.gbPoints);
            this.Controls.Add(this.pbTetrisMap);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "TetrisForm";
            this.Text = "Q Tetris";
            this.Load += new System.EventHandler(this.TetrisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTetrisMap)).EndInit();
            this.gbPoints.ResumeLayout(false);
            this.gbNewGame.ResumeLayout(false);
            this.gbNewGame.PerformLayout();
            this.gbNextItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFallItem)).EndInit();
            this.gbHighScore.ResumeLayout(false);
            this.gbLevel.ResumeLayout(false);
            this.gbLevel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTetrisMap;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Label lMapX;
        private System.Windows.Forms.Label lMapY;
        private System.Windows.Forms.TextBox tbMapX;
        private System.Windows.Forms.TextBox tbMapY;
        private System.Windows.Forms.Timer timerFall;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Label lSpeed;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.Label lPoints;
        private System.Windows.Forms.GroupBox gbPoints;
        private System.Windows.Forms.GroupBox gbNewGame;
        private System.Windows.Forms.GroupBox gbNextItem;
        private System.Windows.Forms.PictureBox pbFallItem;
        private System.Windows.Forms.GroupBox gbHighScore;
        private System.Windows.Forms.ListBox lbHighScore;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbLevel;
        private System.Windows.Forms.Label lLevel;
        private System.Windows.Forms.TextBox tbPoint;
        private System.Windows.Forms.Label label2;
    }
}

