namespace colours_of_the_rainbow
{
    partial class form_main
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.btn_readColours = new System.Windows.Forms.Button();
            this.lv_colours = new System.Windows.Forms.ListView();
            this.Colour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hexcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RGBA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rtb_json = new System.Windows.Forms.RichTextBox();
            this.lbl_json = new System.Windows.Forms.Label();
            this.lbl_listview = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.btn_readFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_readColours
            // 
            this.btn_readColours.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_readColours.Location = new System.Drawing.Point(12, 12);
            this.btn_readColours.Name = "btn_readColours";
            this.btn_readColours.Size = new System.Drawing.Size(83, 241);
            this.btn_readColours.TabIndex = 0;
            this.btn_readColours.Text = "1";
            this.btn_readColours.UseVisualStyleBackColor = true;
            this.btn_readColours.Click += new System.EventHandler(this.btn_readColours_Click);
            // 
            // lv_colours
            // 
            this.lv_colours.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Colour,
            this.Hexcode,
            this.RGBA});
            this.lv_colours.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lv_colours.Location = new System.Drawing.Point(673, 12);
            this.lv_colours.Name = "lv_colours";
            this.lv_colours.Size = new System.Drawing.Size(395, 325);
            this.lv_colours.TabIndex = 1;
            this.lv_colours.UseCompatibleStateImageBehavior = false;
            // 
            // Colour
            // 
            this.Colour.Text = "Name";
            this.Colour.Width = 120;
            // 
            // Hexcode
            // 
            this.Hexcode.Text = "Hexcode";
            // 
            // RGBA
            // 
            this.RGBA.Text = "RGBA";
            this.RGBA.Width = 200;
            // 
            // rtb_json
            // 
            this.rtb_json.Location = new System.Drawing.Point(101, 12);
            this.rtb_json.Name = "rtb_json";
            this.rtb_json.Size = new System.Drawing.Size(566, 325);
            this.rtb_json.TabIndex = 2;
            this.rtb_json.Text = "";
            // 
            // lbl_json
            // 
            this.lbl_json.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_json.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_json.Location = new System.Drawing.Point(101, 340);
            this.lbl_json.Name = "lbl_json";
            this.lbl_json.Size = new System.Drawing.Size(566, 32);
            this.lbl_json.TabIndex = 3;
            this.lbl_json.Text = "Colour data in JSON format";
            this.lbl_json.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_listview
            // 
            this.lbl_listview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_listview.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_listview.Location = new System.Drawing.Point(673, 340);
            this.lbl_listview.Name = "lbl_listview";
            this.lbl_listview.Size = new System.Drawing.Size(395, 32);
            this.lbl_listview.TabIndex = 4;
            this.lbl_listview.Text = "List of colours";
            this.lbl_listview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_author
            // 
            this.lbl_author.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.Location = new System.Drawing.Point(766, 479);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(302, 19);
            this.lbl_author.TabIndex = 5;
            this.lbl_author.Text = "Created by Ben Hagan, completed 11th of November 2017";
            this.lbl_author.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btn_readFile
            // 
            this.btn_readFile.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_readFile.Location = new System.Drawing.Point(12, 254);
            this.btn_readFile.Name = "btn_readFile";
            this.btn_readFile.Size = new System.Drawing.Size(83, 241);
            this.btn_readFile.TabIndex = 6;
            this.btn_readFile.Text = "2";
            this.btn_readFile.UseVisualStyleBackColor = true;
            this.btn_readFile.Click += new System.EventHandler(this.btn_readFile_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(967, 88);
            this.label1.TabIndex = 7;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1080, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_readFile);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.lbl_listview);
            this.Controls.Add(this.lbl_json);
            this.Controls.Add(this.rtb_json);
            this.Controls.Add(this.lv_colours);
            this.Controls.Add(this.btn_readColours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_main";
            this.Text = "Ben\'s Magical Colour Thingy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_readColours;
        private System.Windows.Forms.ListView lv_colours;
        private System.Windows.Forms.RichTextBox rtb_json;
        private System.Windows.Forms.ColumnHeader Colour;
        private System.Windows.Forms.ColumnHeader Hexcode;
        private System.Windows.Forms.ColumnHeader RGBA;
        private System.Windows.Forms.Label lbl_json;
        private System.Windows.Forms.Label lbl_listview;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Button btn_readFile;
        private System.Windows.Forms.Label label1;
    }
}

