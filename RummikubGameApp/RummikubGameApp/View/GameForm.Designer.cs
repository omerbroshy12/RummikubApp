
namespace RummikubGameApp
{
    partial class RumiApp
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
            this.ByNumber = new System.Windows.Forms.Button();
            this.ByColor = new System.Windows.Forms.Button();
            this.TileAdd = new System.Windows.Forms.Button();
            this.opponentTilesLeft = new System.Windows.Forms.Label();
            this.MyTilesLeft = new System.Windows.Forms.Label();
            this.rewindbutton = new System.Windows.Forms.Button();
            this.donebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ByNumber
            // 
            this.ByNumber.BackColor = System.Drawing.Color.CadetBlue;
            this.ByNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ByNumber.Location = new System.Drawing.Point(891, 128);
            this.ByNumber.Name = "ByNumber";
            this.ByNumber.Size = new System.Drawing.Size(60, 60);
            this.ByNumber.TabIndex = 1;
            this.ByNumber.Text = "789";
            this.ByNumber.UseVisualStyleBackColor = false;
            this.ByNumber.Click += new System.EventHandler(this.ByNumber_Click);
            // 
            // ByColor
            // 
            this.ByColor.BackColor = System.Drawing.Color.CadetBlue;
            this.ByColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ByColor.Location = new System.Drawing.Point(891, 194);
            this.ByColor.Name = "ByColor";
            this.ByColor.Size = new System.Drawing.Size(60, 60);
            this.ByColor.TabIndex = 2;
            this.ByColor.Text = "777";
            this.ByColor.UseVisualStyleBackColor = false;
            this.ByColor.Click += new System.EventHandler(this.ByColor_Click);
            // 
            // TileAdd
            // 
            this.TileAdd.BackColor = System.Drawing.Color.CadetBlue;
            this.TileAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TileAdd.Location = new System.Drawing.Point(876, 272);
            this.TileAdd.Name = "TileAdd";
            this.TileAdd.Size = new System.Drawing.Size(75, 126);
            this.TileAdd.TabIndex = 3;
            this.TileAdd.Text = "+";
            this.TileAdd.UseVisualStyleBackColor = false;
            this.TileAdd.Click += new System.EventHandler(this.PlusOrCheck_Click);
            // 
            // opponentTilesLeft
            // 
            this.opponentTilesLeft.AutoSize = true;
            this.opponentTilesLeft.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opponentTilesLeft.Location = new System.Drawing.Point(12, 34);
            this.opponentTilesLeft.Name = "opponentTilesLeft";
            this.opponentTilesLeft.Size = new System.Drawing.Size(192, 17);
            this.opponentTilesLeft.TabIndex = 5;
            this.opponentTilesLeft.Text = "Opponent tiles left: 14";
            // 
            // MyTilesLeft
            // 
            this.MyTilesLeft.AutoSize = true;
            this.MyTilesLeft.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyTilesLeft.Location = new System.Drawing.Point(12, 340);
            this.MyTilesLeft.Name = "MyTilesLeft";
            this.MyTilesLeft.Size = new System.Drawing.Size(120, 17);
            this.MyTilesLeft.TabIndex = 6;
            this.MyTilesLeft.Text = "Tiles left: 14";
            // 
            // rewindbutton
            // 
            this.rewindbutton.BackColor = System.Drawing.Color.CadetBlue;
            this.rewindbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rewindbutton.Location = new System.Drawing.Point(820, 416);
            this.rewindbutton.Name = "rewindbutton";
            this.rewindbutton.Size = new System.Drawing.Size(75, 60);
            this.rewindbutton.TabIndex = 10;
            this.rewindbutton.Text = "rewind";
            this.rewindbutton.UseVisualStyleBackColor = false;
            this.rewindbutton.Click += new System.EventHandler(this.rewindbutton_Click_1);
            // 
            // donebutton
            // 
            this.donebutton.BackColor = System.Drawing.Color.CadetBlue;
            this.donebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.donebutton.Location = new System.Drawing.Point(901, 416);
            this.donebutton.Name = "donebutton";
            this.donebutton.Size = new System.Drawing.Size(60, 60);
            this.donebutton.TabIndex = 11;
            this.donebutton.Text = "done";
            this.donebutton.UseVisualStyleBackColor = false;
            this.donebutton.Click += new System.EventHandler(this.donebutton_Click_1);
            // 
            // RumiApp
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Row;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(963, 507);
            this.Controls.Add(this.donebutton);
            this.Controls.Add(this.rewindbutton);
            this.Controls.Add(this.MyTilesLeft);
            this.Controls.Add(this.opponentTilesLeft);
            this.Controls.Add(this.TileAdd);
            this.Controls.Add(this.ByColor);
            this.Controls.Add(this.ByNumber);
            this.Name = "RumiApp";
            this.Text = "Rummikub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ByNumber;
        private System.Windows.Forms.Button ByColor;
        private System.Windows.Forms.Button TileAdd;
        private System.Windows.Forms.Label opponentTilesLeft;
        private System.Windows.Forms.Label MyTilesLeft;
        private System.Windows.Forms.Button rewindbutton;
        private System.Windows.Forms.Button donebutton;
    }
}

